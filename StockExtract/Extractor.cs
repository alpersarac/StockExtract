using StockExtract.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StockExtract
{
    public partial class Extractor : Form
    {
        SqlAdapter sqlAdapter;
        public Extractor()
        {
            InitializeComponent();
        }
        private void Extractor_Load(object sender, EventArgs e)
        {
            //SQL connection instance for the credentials which comes from app.config file.
            sqlAdapter = new SqlAdapter();
            //Method in order to check whether application connects the database or not.
            sqlAdapter.ConnectToDatabase();
            //Setting the DataGridView's background color.
            SetDataGridViewColor();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Running the store procedure and carrying out the other things such as checking existence of the store procedure, calculating the amount.
            dtStockGrid.DataSource = sqlAdapter.RunTheProcedure(txbProductCode.Text, Convert.ToInt32((dtpStartDate.Value).ToOADate()), Convert.ToInt32((dtpEndDate.Value).ToOADate()));
        }
        private void SetDataGridViewColor()
        {
            Color PurpleColor = Color.FromArgb(192, 192, 255);
            dtStockGrid.DefaultCellStyle.BackColor = PurpleColor;
            dtStockGrid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dtStockGrid.ColumnHeadersDefaultCellStyle.BackColor = PurpleColor;
            dtStockGrid.EnableHeadersVisualStyles = false;
        }
        private void saveAsExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtStockGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("File Error, it is not possible to write on this disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dtStockGrid.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dtStockGrid.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dtStockGrid.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dtStockGrid.Rows.Count-1; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dtStockGrid.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Stock table saved successfully.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There isn't any stock to print.", "Info");
            }
        }

    }
}

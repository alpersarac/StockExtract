using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExtract.Data
{
    public class StockDataProcessor
    {
        public DataTable CalculateAmount(DataTable Table)
        {
            //Creating a data column object to put in the DataTable
            DataColumn dataColumn = new DataColumn("Stok Miktar", typeof(String));
            //Adding the column to DataTable
            Table.Columns.Add(dataColumn);
            //String variable to keep IslemTur to understand the stock type.
            string IslemTur = "";
            //Int variable to keep previous amount.
            int PreviousAmount = 0;
            //Foreach loop to iterate through Table(DataTable) which contains values comes from the query.
            foreach (DataRow row in Table.Rows)
            {
                //Getting IslemTur Value from Table(DataTable).
                IslemTur = row["IslemTur"].ToString();
                //If condition to understand if the type is giris or cikis.
                if (IslemTur.ToLower()=="giris")
                {
                    //Keeping Giris Miktar value by converting from string.
                    long GirisMiktar = Convert.ToInt32(Math.Floor(Convert.ToDouble(row["Giris Miktar"].ToString())));
                    //Putting the Stok Miktar value in the column.
                    row["Stok Miktar"] = (PreviousAmount + GirisMiktar).ToString();
                }
                else
                {
                    //Keeping Cikis Miktar value by converting from string.
                    long CikisMiktar = Convert.ToInt32(Math.Floor(Convert.ToDouble(row["Cikis Miktar"].ToString())));
                    //Putting the Stok Miktar value in the column.
                    row["Stok Miktar"] = (PreviousAmount - CikisMiktar).ToString();
                }
                //Keeping the previous amount.
                PreviousAmount = Convert.ToInt32(row["Stok Miktar"]);
            }
            return Table;
        }

    }
}

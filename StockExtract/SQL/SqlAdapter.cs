using StockExtract.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockExtract.SQL
{
    public class SqlAdapter
    {
        string ServerName;
        string DatabaseName;
        string Password;
        string UserName;
        string ConnetionString;
        
        public SqlAdapter() {
            try
            {
                this.ServerName = System.Configuration.ConfigurationManager.AppSettings["sqlServerName"];
                this.DatabaseName = System.Configuration.ConfigurationManager.AppSettings["sqlDatabaseName"];
                this.Password = System.Configuration.ConfigurationManager.AppSettings["sqlPassword"];
                this.UserName = System.Configuration.ConfigurationManager.AppSettings["sqlUserName"];
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to read config values, please check app.config file.");
            }
            
        }
        public bool ConnectToDatabase() {
            try
            {
                //Connection string
                ConnetionString = @"Data Source="+ ServerName + ";Initial Catalog="+DatabaseName+";User ID="+ UserName + ";Password="+Password+"";
                using (SqlConnection con = new SqlConnection(ConnetionString))
                {
                    //Opening the connection
                    con.Open();
                    //Closing the connection
                    con.Close();
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Database connection failed please check the credentials in app.config file!");
                return false;
            }
        }
        public bool CreateStoreProcedure(string DatabaseName)
        {
            try
            {
                //Store procedure query.
                string Query= " Create or Alter procedure Get_Stock " +
                              " @ProductCode NVARCHAR(50), " +
                              " @StartDate int, " +
                              " @EndDate int " +
                              " as " +
                              " EXEC ('USE ["+ DatabaseName + "];') "+
                              " begin " +
                              " SELECT " +
                              "	ROW_NUMBER() OVER(ORDER BY (SELECT SI.Tarih)) as 'Sira No', " +
                              "	CASE WHEN SI.IslemTur = 0  THEN 'Giris' WHEN SI.IslemTur=1 THEN 'Cikis' END AS IslemTur, " +
                              "	SI.EvrakNo, " +
                              "	CONVERT(VARCHAR(15), CAST(SI.Tarih - 2 AS datetime), 104) AS 'Tarih', " +
                              "	CASE WHEN SI.IslemTur = 0 and SI.Miktar!=0  THEN SI.Miktar ELSE 0 END  AS 'Giris Miktar', " +
                              "	CASE WHEN SI.IslemTur = 1 and SI.Miktar!=0  THEN SI.Miktar ELSE 0 END  AS 'Cikis Miktar' " +
                              "	FROM STI AS SI " +
                              "	LEFT JOIN STK AS S on SI.MalKodu=S.MalKodu " +
                              "	WHERE CONVERT(VARCHAR(15), CAST(@StartDate - 2 AS datetime), 104)<CONVERT(VARCHAR(15), CAST(SI.Tarih - 2 AS datetime), 104) and CONVERT(VARCHAR(15), CAST(@EndDate - 2 AS datetime), 104)>CONVERT(VARCHAR(15), CAST(SI.Tarih - 2 AS datetime), 104) " +
                              "	AND SI.MalKodu=@ProductCode " +
                              "	GROUP BY SI.IslemTur,SI.EvrakNo,SI.Tarih,SI.Miktar, SI.MalKodu " +
                              "	ORDER BY SI.Tarih ASC " +
                              " end ";
                using (SqlConnection con = new SqlConnection(ConnetionString))
                {
                    using (SqlCommand cmd = new SqlCommand(Query, con))
                    {
                        
                        //Opens the connection.
                        con.Open();
                        //Command type.
                        cmd.CommandType = CommandType.Text;
                        //Execution of the command.
                        cmd.ExecuteReader();
                        //Closes the connection.
                        con.Close();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable RunTheProcedure(string ProductCode, int StartDate, int EndDate)
        {
            try
            {
                //Method for creation of the store procedure just in case.
                CreateStoreProcedure(DatabaseName);
                //Datatable to keep the data comes from the query.
                DataTable Table = new DataTable();
                //Instance of StockDataProcessor contains CalculateAmount so as to calculate amount(StokMiktar)
                StockDataProcessor stockDataProcessor = new StockDataProcessor();
                using (SqlConnection con = new SqlConnection(ConnetionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Get_Stock", con))
                    {
                        //Decleration of the command type.
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Passing the parameters for the search items.
                        cmd.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = ProductCode;
                        cmd.Parameters.Add("@StartDate", SqlDbType.VarChar).Value = StartDate;
                        cmd.Parameters.Add("@EndDate", SqlDbType.VarChar).Value = EndDate;
                        //Opens connection in order to execute the query.
                        con.Open();
                        //Getting the data into Table(DataTable) to use source of the DataGridView.
                        Table.Load(cmd.ExecuteReader());
                        //Closes the connection.
                        con.Close();
                    }
                }
                //Calling the method calculates Amount(Stok Miktar)
                return stockDataProcessor.CalculateAmount(Table);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
      
    }
}

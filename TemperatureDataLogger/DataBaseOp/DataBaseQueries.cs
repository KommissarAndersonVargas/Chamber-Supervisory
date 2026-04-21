using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace TemperatureDataLogger
{
    public class DataBaseQueries
    {
        private static string connectionString = @"Data Source=DESKTOP-H0IIS6S\SQL2014;
                  Initial Catalog=Supervisory;
                  Persist Security Info=True;
                  User ID=sa;
                  Password=123456;
                  TrustServerCertificate=True";

        // Comando INSERT com parâmetros
        private static string insertQuery = @"
                INSERT INTO [Supervisory].[dbo].[Temperatures_Table]
                (Data_and_time, Temperature_Value, Max_Value, Min_Value)
                VALUES
                (@DataAndTime, @TemperatureValue, @MaxTemp, @MinTemp);
            ";

        public static string InsertQuery
        {
            get
            {
                return insertQuery;
            }
        }

        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

        public static void InsertDatabaseInfo(DateTime timeSpan, double temperatureValue, double maxTemp, double minTemp )
        {
            try
            {
                using (SqlConnection connStr = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(InsertQuery, connStr))
                    {
                        cmd.Parameters.Add("@DataAndTime", SqlDbType.DateTime, 100).Value = timeSpan;
                        cmd.Parameters.Add("@TemperatureValue", SqlDbType.Decimal, 100).Value = temperatureValue;
                        cmd.Parameters.Add("@MaxTemp", SqlDbType.Decimal, 100).Value = maxTemp;
                        cmd.Parameters.Add("@MinTemp", SqlDbType.Decimal, 100).Value = minTemp;

                        connStr.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        connStr.Close();

                        if(rowsAffected < 0)
                        {
                            MessageBox.Show("Nenhum dado inserido", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir dados no banco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

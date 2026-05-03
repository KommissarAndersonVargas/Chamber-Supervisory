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

        private static string getQuery = "SELECT * FROM Supervisory.dbo.Temperatures_Table " +
               "WHERE Data_and_time >= @DataHora AND Data_and_time < DATEADD(MINUTE, 1, @DataHora)";

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

        public static void InsertDatabaseInfo(DateTime timeSpan, double temperatureValue, double maxTemp, double minTemp)
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

                        if (rowsAffected < 0)
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

        public static DateTime GetDateTemperature(string timeQuery)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(getQuery, conn))
                {
                    DateTime dataHora = DateTime.ParseExact(timeQuery, "dd/MM/yyyy HH:mm", null);
                    cmd.Parameters.Add("@DataHora", System.Data.SqlDbType.DateTime).Value = dataHora;

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDateTime(result);
                    }
                    else
                    {
                        throw new Exception("Item não encontrado");
                    }
                }
            }
        }

    }
}

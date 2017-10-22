using System;
using System.Data;
using System.Data.SqlClient;

namespace Energy_Cons_DW_BI
{
    class DatabaseHandler
    {
        SqlConnection connection;
        string conStr = "Data Source = localhost; Initial catalog = energy_cons_dw; User ID=sa; Password=9212105311080";

        public DatabaseHandler()
        {
            connection = new SqlConnection(conStr);
        }

        public void insertData(string shop_code, string shop_name, string shop_location, string time_hour_min, string day_of_week, string day_of_month, string name_of_month, string year, string cons_type, double actual_cons, double actual_emission_co2, double actual_emission_nox, double actual_emission_sox, double actual_emission_particles, double actual_emission_water, double temperature)
        {
            using (connection = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("insert_records", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@shop_code", SqlDbType.NChar).Value = shop_code;
                    cmd.Parameters.AddWithValue("@shop_name", SqlDbType.NChar).Value = shop_name;
                    cmd.Parameters.AddWithValue("@shop_location", SqlDbType.NChar).Value = shop_location;
                    cmd.Parameters.AddWithValue("@time_hour_min", SqlDbType.NChar).Value = time_hour_min;
                    cmd.Parameters.AddWithValue("@day_of_week", SqlDbType.NChar).Value = day_of_week;
                    cmd.Parameters.AddWithValue("@day_of_month", SqlDbType.NChar).Value = day_of_month;
                    cmd.Parameters.AddWithValue("@name_of_month", SqlDbType.NChar).Value = name_of_month;
                    cmd.Parameters.AddWithValue("@year", SqlDbType.NChar).Value = year;
                    cmd.Parameters.AddWithValue("@consumption_type", SqlDbType.NChar).Value = cons_type;
                    cmd.Parameters.AddWithValue("@actual_consuption", SqlDbType.NChar).Value = actual_cons;
                    cmd.Parameters.AddWithValue("@actual_emission_Co2", SqlDbType.NChar).Value = actual_emission_co2;
                    cmd.Parameters.AddWithValue("@actual_emission_Nox", SqlDbType.NChar).Value = actual_emission_nox;
                    cmd.Parameters.AddWithValue("@actual_emission_Sox", SqlDbType.NChar).Value = actual_emission_sox;
                    cmd.Parameters.AddWithValue("@actual_emission_Particles", SqlDbType.NChar).Value = actual_emission_particles;
                    cmd.Parameters.AddWithValue("@actual_emission_Water", SqlDbType.NChar).Value = actual_emission_water;
                    cmd.Parameters.AddWithValue("@temperature", SqlDbType.NChar).Value = temperature;

                    connection.Open();
                    int status = cmd.ExecuteNonQuery();

                    if (status == 0)
                    {
                        Console.WriteLine("Success");
                    }
                }
            }
        }

        public void createtables()
        {

        }

        public void dropTables()
        {
            using (connection = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("truncateTables",connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    if(cmd.ExecuteNonQuery() == 0)
                    {
                        Console.WriteLine("Success");
                    }
                }
            }
        }
    }
}

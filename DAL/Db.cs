using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WebStore.DAL
{
    public class Db
    {
        //readonly SqlConnection Unclebob = new SqlConnection(ConfigurationManager.ConnectionStrings["Unclebob"].ConnectionString);

        //string connectionString = @"Database={bobschema}; Data Source=bobmysql.mysql.database.azure.com; User Id=cse482@bobmysql; Password={$J0sen0s3!}";

        public DataSet Show_data()
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=bobmysql.mysql.database.azure.com;database=bobschema;uid=ConnectMe@bobmysql;pwd=Net3Them!;";
            cnn = new MySqlConnection(connetionString);

            MySqlCommand com = new MySqlCommand("Select * from product", cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(com);

           
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //return ds;
        }


    }
    
}
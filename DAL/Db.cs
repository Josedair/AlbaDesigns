using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity;

namespace WebStore.DAL
{
    public class Db
    {
        readonly SqlConnection Bobsmyuncle = new SqlConnection(ConfigurationManager.ConnectionStrings["Bobsmyuncle"].ConnectionString);

        //string connectionString = @"Database={bobschema}; Data Source=bobmysql.mysql.database.azure.com; User Id=cse482@bobmysql; Password={$J0sen0s3!}";

        public DataSet Show_data()
        {
            
            SqlCommand com = new SqlCommand("Select * from product", Bobsmyuncle);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


    }
    
}
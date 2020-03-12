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
        readonly SqlConnection bobschemaConnectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["bobschemaConnectionString"].ConnectionString);

        string connectionString = @"Database={bobschema}; Data Source=bobmysql.mysql.database.azure.com; User Id=cse482@bobmysql; Password={$J0sen0s3!}";

        public DataSet Show_data()
        {
            SqlCommand com = new SqlCommand("Select * from product", bobschemaConnectionString);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


    }
    
}
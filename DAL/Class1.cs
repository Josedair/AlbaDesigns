using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WebStore.DAL
{
   
    
        public partial class Form1 : Form
        {
            public Form1()
            {
                //InitializeComponent();
                
            }
            private void button1_Click(object sender, EventArgs e)
            {
                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server=bobmysql.mysql.database.azure.com;database=bobschema;uid=ConnectMe@bobmysql;pwd=Net3Them!;";
                cnn = new MySqlConnection(connetionString);
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
            }
        }
    
}
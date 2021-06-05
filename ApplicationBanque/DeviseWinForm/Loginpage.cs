using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DeviseWinForm
{
    public partial class Loginpage : MaterialSkin.Controls.MaterialForm
    {
        public Loginpage()
        {
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            string userlogin = login.Text;
            string password = passwd.Text;

            string connectionstring;
            SqlConnection connexion;

            connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=APPBANQUE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connexion = new SqlConnection(connectionstring);
            connexion.Open();

            string sqlquery;
            SqlCommand command;
            SqlDataReader datareader;

            sqlquery = "select Login,password from Login where Login='" + userlogin + "'and password='" + password + "'";
            command = new SqlCommand(sqlquery, connexion);
            datareader = command.ExecuteReader();

            if (datareader.HasRows)
            {

                MessageBox.Show("connected");
                this.Close();

            }
            else
            {
                MessageBox.Show("erreur");
            }
            connexion.Close();

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}





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
using Devise_Lib;
using Atelier1_G31;

namespace DeviseWinForm
{
    public partial class GestionComptes : Form
    {
        static int cpt = 1;
        public GestionComptes()
        {
            InitializeComponent();
            dataGridView2.Hide();
            label2.Hide();
            textBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection connexion;

            connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=APPBANQUE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connexion = new SqlConnection(connectionstring);
            connexion.Open();
            string sqlquery;
            SqlCommand command;
            SqlDataReader datareader;
            
            sqlquery = "insert into Compte values('"+ ++cpt +"','" + textBox2.Text + "','" + textBox3.Text + "')";
            command = new SqlCommand(sqlquery, connexion);
            datareader = command.ExecuteReader();
            MessageBox.Show("compte ajoute");
            connexion.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection connexion;

            connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=APPBANQUE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connexion = new SqlConnection(connectionstring);
            connexion.Open();
            string sqlquery;
            SqlCommand command;
            SqlDataReader datareader;
            

            sqlquery = "update Compte set titulaire='" + textBox2.Text + "',solde='" + textBox3.Text + "' where Id='" + textBox1.Text + "'";
            command = new SqlCommand(sqlquery, connexion);
            datareader = command.ExecuteReader();
            MessageBox.Show("Compte modifie");
            connexion.Close();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[a];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection connexion;

            connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=APPBANQUE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connexion = new SqlConnection(connectionstring);
            connexion.Open();
            string sqlquery;
            sqlquery = "delete from Compte where Id='" + int.Parse(textBox1.Text) + "'";
            SqlCommand command = new SqlCommand(sqlquery, connexion);
            command.ExecuteNonQuery();
            connexion.Close();
            a = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(a);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection connexion;

            connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=APPBANQUE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connexion = new SqlConnection(connectionstring);
            connexion.Open();
            string sqlquery;
            SqlCommand command;
            SqlDataReader datareader;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("titulaire");
            dataTable.Columns.Add("solde");

            sqlquery = "select * from Compte";
            command = new SqlCommand(sqlquery, connexion);
            datareader = command.ExecuteReader();
            if (datareader.HasRows)
            {
                while (datareader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["Id"] = datareader["Id"];
                    row["titulaire"] = datareader["titulaire"];
                    row["solde"] = datareader["solde"];

                    dataTable.Rows.Add(row);
                }
                dataGridView2.DataSource = dataTable;
                dataGridView2.Show();
                
            }
            else
            {
                MessageBox.Show("aucun compte");
            }
            connexion.Close();
        }
        int a;
       
    }
}

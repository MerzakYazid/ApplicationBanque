using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Devise_Lib;
using Atelier1_G31;
using System.Data.SqlClient;

namespace DeviseWinForm
{
    public partial class GestionClient : Form
    {
        static int cpt = 2;
        public GestionClient()
        {
            InitializeComponent();
            dataGridView1.Hide();
            textBox1.Hide();
            label2.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

            sqlquery = "update Client set nom='"+textBox2.Text+"',prenom='"+textBox3.Text+"',adresse='"+textBox4.Text+"' where Id='"+textBox1.Text+"'";
            command = new SqlCommand(sqlquery, connexion);
            datareader = command.ExecuteReader();
            MessageBox.Show("Client modifie");
            connexion.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String path = @"D:\ecole\POO\DeviseWinForm\data.txt";
            String[] lines;
            string lines2;
            lines = File.ReadAllLines(path);
            lines2 = File.ReadAllText(path);
                MessageBox.Show(lines[0]);
                 MessageBox.Show(lines2);
        }
        int a;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                a = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[a];
                 textBox1.Text = row.Cells[0].Value.ToString();
                 textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
            textBox1.Show();
            label2.Show();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection connexion;

            Client c = new Client(textBox2.Text, textBox3.Text, textBox4.Text);

            connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=APPBANQUE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connexion = new SqlConnection(connectionstring);
            connexion.Open();
            string sqlquery;
            SqlCommand command;
            SqlDataReader datareader;
            
            sqlquery = c.enregistrer();
            command = new SqlCommand(sqlquery, connexion);
            datareader = command.ExecuteReader();
            MessageBox.Show("client ajoute");
            connexion.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection connexion;

            connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=APPBANQUE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connexion = new SqlConnection(connectionstring);
            connexion.Open();
            string sqlquery;
            sqlquery = "delete from Client where Id='" + int.Parse(textBox1.Text) + "'";
            SqlCommand command = new SqlCommand(sqlquery, connexion);
            command.ExecuteNonQuery();
            connexion.Close();
            a = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(a);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void GestionClient_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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
            dataTable.Columns.Add("nom");
            dataTable.Columns.Add("prenom");
            dataTable.Columns.Add("adresse");

            sqlquery = "select * from Client";
            command = new SqlCommand(sqlquery, connexion);
            datareader = command.ExecuteReader();
            if (datareader.HasRows)
            {
                while (datareader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["Id"] = datareader["Id"];
                    row["nom"] = datareader["nom"];
                    row["prenom"] = datareader["prenom"];
                    row["adresse"] = datareader["adresse"];

                    dataTable.Rows.Add(row);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Show();

            }
            else
            {
                MessageBox.Show("aucun client");
            }
            connexion.Close();
        }
    }
}

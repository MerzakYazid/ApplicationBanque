using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviseWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loginpage p = new Loginpage();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(p);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            p.Show();
            this.Hide();
            
            
        }

        private void convertisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void convertisseurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void gestionClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionClient G1 = new GestionClient();
            G1.TopLevel = false;
            G1.AutoScroll = true;
            G1.FormBorderStyle = FormBorderStyle.None;
            this.mainpanel.Controls.Clear();
            mainpanel.Controls.Add(G1);
            G1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           /* GestionClient G1 = new GestionClient();
            G1.TopLevel = false;
            G1.AutoScroll = true;
            G1.FormBorderStyle = FormBorderStyle.None;
            mainpanel.Controls.Add(G1);
            G1.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Convertisseur f = new Convertisseur() {  TopLevel = false, TopMost = true };
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.AutoSize = true;
            this.mainpanel.Controls.Clear();
            this.mainpanel.Controls.Add(f);
            f.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) { 

            
            GestionComptes c = new GestionComptes();
            c.TopLevel = false;
            c.AutoScroll = true;
            c.FormBorderStyle = FormBorderStyle.None;
            this.mainpanel.Controls.Clear();
            this.mainpanel.Controls.Add(c);
            c.Show();
        }
    }
}

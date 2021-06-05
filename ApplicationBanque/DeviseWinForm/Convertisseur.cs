using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devise_Lib;

namespace DeviseWinForm
{
    public partial class Convertisseur : Form
    {
        public Convertisseur()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double val_start =double.Parse(textRequest.Text);
            string type_start = comboBox_start.Items[comboBox_start.SelectedIndex].ToString();
            string type_end = comboBox2.Items[comboBox2.SelectedIndex].ToString();
            Devise Start;
            Devise End;
            if (type_start == "US")
            {
                Start = new US(val_start);
                
            }
            else if (type_start == "EU")
            {
                Start = new EU(val_start);
                
            }
            else
            {
                Start = new MAD(val_start);
              
            }
            End = Start.convertTo(type_end);
            textResult.Text = End.ToString();

        }

        private void Convertisseur_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

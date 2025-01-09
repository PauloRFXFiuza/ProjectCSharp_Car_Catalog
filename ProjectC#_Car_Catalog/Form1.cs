using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectC__Car_Catalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //comboBox1 refers to Brand Cars- refere-se às marcas dos carros
        //comboBox3 refers to Model Cars- refere-se aos modelos dos carros
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeFotosDosCarros = 
                Directory.GetFiles(@"C:\Users\paulo\Documents\Workspaces\C#Workspace\ProjectC#_Car_Catalog\ProjectC#_Car_Catalog\Cars");

            foreach(string img in nomeFotosDosCarros)
            {
                string[] separador = img.Split('\\');
                string[] nomeSelecionado = separador[9].Split('.');
                //MessageBox.Show(nomeSelecionado[0]);
                if(comboBox3.Text == nomeSelecionado[0])
                {
                    pictureBox2.ImageLocation = @"C:\Users\paulo\Documents\Workspaces\C#Workspace\ProjectC#_Car_Catalog\ProjectC#_Car_Catalog\Cars\" + comboBox3.Text + "." + nomeSelecionado[1];
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = string.Empty;

            if (comboBox1.Text == "Ford")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Galaxie 1962");
                comboBox3.Items.Add("Mustang 1966");
                comboBox3.Items.Add("F100 1954");
            }
            else if (comboBox1.Text == "Chevrolet")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("FleetLine 1941");
                comboBox3.Items.Add("Impala 1966");
                comboBox3.Items.Add("Malibu 1954");
            }
            else if (comboBox1.Text == "Ferrari")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("F330 1963");
                comboBox3.Items.Add("225S 1952");
            }
            else if (comboBox1.Text == "Audi")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("920 Limousine 1939");
                comboBox3.Items.Add("10-26 HP 1911");
            }
            else if (comboBox1.Text == "BMW")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("327 1939");
                comboBox3.Items.Add("503 1953");
            }
            else if (comboBox1.Text == "Gurgel")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("X12 1978");
                comboBox3.Items.Add("BR800 1989");
            }
        }
    }
}

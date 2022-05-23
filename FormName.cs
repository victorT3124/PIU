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

namespace PIU
{
    //A 2 clasa (lab2)
    public partial class FormName : Form
    {

        public string name { get; set; }
        public FormName()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //citire date de la tastatura(lab3)
        private string textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;

            return name;
        }


        //salvarea datelor in fisier text (lab3)
        public void Salvare (string _nume)
        {
            _nume = textBox1.Text;
            File.WriteAllText(@"C:\Users\Professional\source\repos\PIU\Players.txt", _nume);
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Salvare(textBox1.Text);
            Hide();
        }


    }
}

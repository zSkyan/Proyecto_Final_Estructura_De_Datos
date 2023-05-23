using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            Registro form2 = new Registro(); 
            form2.Show(); 
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso form3 = new Ingreso();
            form3.Show();
            this.Hide();
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarFechaHoraActual();
        }

        private void MostrarFechaHoraActual()
        {
            string fechaHoraActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            label3.Text = fechaHoraActual;
        }
    }
}

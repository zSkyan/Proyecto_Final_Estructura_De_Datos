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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (ValidarCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso.", "¡Bienvenido!");
                
            }
            else
            {
                MessageBox.Show("Credenciales inválidas. Por favor, intente nuevamente.", "Error de inicio de sesión");
               
            }
        }

        private bool ValidarCredenciales(string usuario, string contraseña)
        {
            return usuario == UsuarioValido && contraseña == ContraseñaValida;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoResidencias
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string user = "x";
            string password = "xxx";

            if (usuario.Text == user && contraseña.Text == password)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Nombre o Contraseña incorrectos");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace Presentaciones
{
    public partial class frmLoggin : Form
    {
        ManejadorUsuario usuario;
        ManejadorPermisos permisos;
        public static string email;
        public frmLoggin()
        {
            usuario = new ManejadorUsuario();
            permisos = new ManejadorPermisos();
            InitializeComponent();
        }
        void Ingresar()
        {
            
            if (usuario.Login(txtEmail.Text, txtPassword.Text).Equals("true"))
            {
                email = txtEmail.Text;

                frmPrincipal main = new frmPrincipal();
                main.Show();

                Close();
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister main = new frmRegister();
            main.Show();

            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
    }
}

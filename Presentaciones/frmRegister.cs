using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manejadores;
using Entidades;
using System.Windows.Forms;

namespace Presentaciones
{
    public partial class frmRegister : Form
    {
        ManejadorUsuario usuario;
        entidadUsuario euser;
        public frmRegister()
        {
            euser = new entidadUsuario();
            usuario = new ManejadorUsuario();
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLoggin main = new frmLoggin();
            main.Show();
            Close();
        }
        void GuardarEntidad()
        {
            euser.Nombre = txtNombre.Text;
            euser.ApellidoP = txtApellidoP.Text;
            euser.ApellidoM = txtApellidoM.Text;
            euser.FechaNacimiento = txtFecha.Text;
            euser.RFC = txtRFC.Text;
            euser.Email = txtEmail.Text;
            euser.Password = txtPassword.Text;
        }
        void Registrar()
        {
            if (usuario.RegistrarUsuario(euser).Equals("1"))
            {
                lblResultado.Text =  "El RFC ya existe";
            }
            else if (usuario.RegistrarUsuario(euser).Equals("2"))
            {
                lblResultado.Text = "El Email ya existe";
            }
            else if (usuario.RegistrarUsuario(euser).Equals("3"))
            {
                lblResultado.Text = "El Email tiene formato incorrecto";
            }
            else
            {
                lblResultado.Text = "Registrado correctamente";
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            GuardarEntidad();
            Registrar();
        }
    }
}

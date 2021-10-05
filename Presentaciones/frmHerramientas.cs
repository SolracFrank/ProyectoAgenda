using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace Presentaciones
{
    public partial class frmHerramientas : Form
    {
        ManejadorPermisos permisos;
        ManejadorProducto producto;
        ManejadorUsuario usuario;
        int id;
        public frmHerramientas()
        {
            permisos = new ManejadorPermisos();
            usuario = new ManejadorUsuario();
            producto = new ManejadorProducto();
            InitializeComponent();
        }

        void CargarPermisos()
        {
            foreach (var item in ManejadorPermisos.lpermisos)
            {
                if (item.Lectura == 1)
                {
                    dtgDatos.Enabled = true;
                    //herramientas.MostrarDatos(dtgDatos, txtBuscar.Text);
                    txtBuscar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Usted no tiene permisos para ver datos, pídale a un admin que lo agregue", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (item.Escritura == 1)
                {
                    btnAdd.Enabled = true;
                }
                else
                {

                }
                if (item.Actualizacion == 1)
                {
                    btnUpdate.Enabled = true;
                }
                else
                {

                }
                if (item.Eliminacion == 1)
                {
                    btnDelete.Enabled = true;
                }
                else
                {

                }
            }
        }

        void CargarDatos()
        {
            id = int.Parse(usuario.RetornarID(frmLoggin.email));
            string resultado = permisos.ComprobarExistencia(id);
            int formulario = int.Parse(permisos.ComprobarFormulario(id, nameof(frmHerramientas)));
            if (resultado == "true" && formulario > 0)
            {
                permisos.CargarPerfil(id, nameof(frmHerramientas));
                permisos.CargarPermisos(id, nameof(frmHerramientas));
                CargarPermisos();

            }
            else
            {
                MessageBox.Show("Usted no está registrado en el sistema de permisos de este formulario, pídale a un administrador que lo agregue", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //producto.MostrarDatos(dtgDatos, txtBuscar.Text);
        }

        private void frmHerramientas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmPrincipal main = new frmPrincipal();
            main.Show();

            Close();
        }
    }
}

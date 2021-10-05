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
    public partial class frmUsuarios : Form
    {
        ManejadorUsuario usuario;
        public frmUsuarios()
        {
            usuario = new ManejadorUsuario();
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            usuario.MostrarDatos(dtgUsuarios, "");
        }
    }
}

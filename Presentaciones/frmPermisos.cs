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
    public partial class frmPermisos : Form
    {
        ManejadorPermisos permisos;
        public frmPermisos()
        {
            permisos = new ManejadorPermisos();
            InitializeComponent();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            permisos.MostrarDatos(dtgPermisos, "");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciones
{
    public partial class frmAdministrar : Form
    {
        public frmAdministrar()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.Show();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            frmPermisos permisos = new frmPermisos();
            permisos.Show();
        }
    }
}

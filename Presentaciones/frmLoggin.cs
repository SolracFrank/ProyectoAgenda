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

        public frmLoggin()
        {
            usuario = new ManejadorUsuario();
            permisos = new ManejadorPermisos();
            InitializeComponent();
        }
    }
}

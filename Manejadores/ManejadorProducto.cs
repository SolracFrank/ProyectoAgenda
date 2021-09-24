using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorProducto
    {
        conexion _base;  
        public ManejadorProducto()
        {
            _base = new conexion("localhost", "root", "", "agencia", 3306);
        }

        public void MostrarDatos(DataGridView tabla, string dato)
        {
            
            tabla.DataSource = _base.ObtenerDatos(string.Format("SELECT * FROM producto WHERE Nombre LIKE '%{0}%';",dato),"producto").Tables["producto"];
            tabla.AutoResizeColumns();
        }
            
    }
}

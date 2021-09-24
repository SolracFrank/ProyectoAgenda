using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;


namespace Manejadores
{
    public class ManejadorUsuario
    {
        //public static List<>
        conexion _base;
        public ManejadorUsuario()
        {
            _base = new conexion("localhost","root","","agencia",3306);
        }

        public void IngresarDatos(entidadUsuario usuario)
        {
            _base.Consultar(string.Format("INSERT INTO usuarios VALUES(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}');",usuario.Nombre,usuario.ApellidoP,
                usuario.ApellidoM,usuario.FechaNacimiento,usuario.RFC,usuario.Email,usuario.Password));
        }





    }
}

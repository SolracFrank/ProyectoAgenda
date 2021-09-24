using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using Entidades;
using System.Threading.Tasks;

namespace Manejadores
{
    public class ManejadorPermisos
    {
       
        conexion _base;
        public static List<entidadPermisos> permisos = new List<entidadPermisos>();
        public ManejadorPermisos()
        {
            _base = new conexion("localhost", "root", "", "agencia", 3306);
        }

        public void CargarPermisos(int id)
        {
            permisos.Clear();

            foreach (var item in permisos)
            {
                item.Matricula = _base.ConsultaRetorno(string.Format("SELECT Matricula FROM Permisos WHERE (fkidUsuario = {0});",id));
                item.Lectura = int.Parse(_base.ConsultaRetorno(string.Format("SELECT Lectura FROM Permisos WHERE (fkidUsuario = {0});", id)));
                item.Escritura = int.Parse(_base.ConsultaRetorno(string.Format("SELECT Escritura FROM Permisos WHERE (fkidUsuario = {0});", id)));
                item.Actualizacion = int.Parse(_base.ConsultaRetorno(string.Format("SELECT Actualizacion FROM Permisos WHERE (fkidUsuario = {0});", id)));
                item.Eliminacion = int.Parse(_base.ConsultaRetorno(string.Format("SELECT Eliminacion FROM Permisos WHERE (fkidUsuario = {0});", id)));
                item.Formulario = _base.ConsultaRetorno(string.Format("SELECT Formulario FROM Permisos WHERE (fkidUsuario = {0});", id));
                item.FKIDUsuario = int.Parse(_base.ConsultaRetorno(string.Format("SELECT fkidUsuario FROM Permisos WHERE (fkidUsuario = {0});", id)));
            }
        }



        
    }
}

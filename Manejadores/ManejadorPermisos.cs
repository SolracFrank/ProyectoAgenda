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
        entidadPermisos epermiso;
        public static List<entidadPermisos> lpermisos = new List<entidadPermisos>();
        public ManejadorPermisos()
        {
            _base = new conexion("localhost", "root", "", "agencia", 3306);
        }

        public string ComprobarExistencia(int ID)
        {

            return _base.ConsultaRetorno(string.Format("call p_cargarpermisos({0})",ID));
        }
        public string ComprobarFormulario(int ID, string formulario)
        {
            return _base.ConsultaRetorno(string.Format("SELECT Count(*) FROM Permisos WHERE fkidUsuario = {0} AND Formulario = '{1}';", ID,formulario));
        }
        public void CargarPermisos(int id, string formulario)
        {
            lpermisos.Clear();
            
            epermiso = new entidadPermisos();
            
            epermiso.Matricula = _base.ConsultaRetorno(string.Format("SELECT Matricula FROM Permisos WHERE (fkidUsuario = {0}) AND Formulario = '{1}';", id,formulario));
            epermiso.Lectura = int.Parse(_base.ConsultaRetorno(string.Format("SELECT Lectura FROM Permisos WHERE (fkidUsuario = {0}) AND Formulario = '{1}';", id, formulario)));
            epermiso.Escritura = int.Parse(_base.ConsultaRetorno(string.Format("SELECT Escritura FROM Permisos WHERE (fkidUsuario = {0}) AND Formulario = '{1}';", id, formulario)));
            epermiso.Actualizacion = int.Parse(_base.ConsultaRetorno(string.Format("SELECT Actualizacion FROM Permisos WHERE (fkidUsuario = {0}) AND Formulario = '{1}';", id, formulario)));
            epermiso.Eliminacion = int.Parse(_base.ConsultaRetorno(string.Format("SELECT Eliminacion FROM Permisos WHERE (fkidUsuario = {0}) AND Formulario = '{1}';", id, formulario)));
            epermiso.Formulario = _base.ConsultaRetorno(string.Format("SELECT Formulario FROM Permisos WHERE (fkidUsuario = {0}) AND Formulario = '{1}';", id, formulario)); 
            epermiso.FKIDUsuario = int.Parse(_base.ConsultaRetorno(string.Format("SELECT fkidUsuario FROM Permisos WHERE (fkidUsuario = {0}) AND Formulario = '{1}';", id, formulario)));

            lpermisos.Add(epermiso);
        }



        
    }
}

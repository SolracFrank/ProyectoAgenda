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
        conexion _base;
        public ManejadorUsuario()
        {
            _base = new conexion("localhost","root","","agencia",3306);
        }
        public string Login(string email, string password)
        {
            return _base.ConsultaRetorno(string.Format("call p_Login('{0}','{1}');",email,password));
        }
        public string RegistrarUsuario(entidadUsuario usuario)
        {
           return _base.ConsultaRetorno(string.Format("CALL p_Register('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",usuario.Nombre,usuario.ApellidoP,
                usuario.ApellidoM,usuario.FechaNacimiento,usuario.RFC,usuario.Email,usuario.Password));
        }
        public string RetornarID(string email)
        {
            return _base.ConsultaRetorno(string.Format("SELECT idUsuario FROM usuarios WHERE email = '{0}';",email));
        }
    }
}

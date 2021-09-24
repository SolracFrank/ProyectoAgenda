namespace Entidades
{
    public class entidadUsuario
    {
        public entidadUsuario()
        {

        }
        public entidadUsuario(int iDusuario, string nombre, string apellidoP, string apellidoM, string fechaNacimiento, string rFC, string email, string password)
        {
            IDusuario = iDusuario;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            FechaNacimiento = fechaNacimiento;
            RFC = rFC;
            Email = email;
            Password = password;
        }
        public int IDusuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string FechaNacimiento { get; set; }
        public string RFC { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}

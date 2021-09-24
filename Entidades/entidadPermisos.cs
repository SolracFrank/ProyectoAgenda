namespace Entidades
{
    public class entidadPermisos
    {
        public entidadPermisos(string matricula, bool lectura, bool escritura, bool actualizacion, bool eliminacion, bool formulario, int fKIDUsuario)
        {
            Matricula = matricula;
            Lectura = lectura;
            Escritura = escritura;
            Actualizacion = actualizacion;
            Eliminacion = eliminacion;
            Formulario = formulario;
            FKIDUsuario = fKIDUsuario;
        }

        public string Matricula { get; set; }
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Actualizacion { get; set; }
        public bool Eliminacion { get; set; }
        public bool Formulario { get; set; }
        public int FKIDUsuario { get; set; }




    }
}

namespace Entidades
{
    public class entidadPermisos
    {
        public entidadPermisos(string matricula, int lectura, int escritura, int actualizacion, int eliminacion, string formulario, int fKIDUsuario)
        {
            Matricula = matricula;
            Lectura = lectura;
            Escritura = escritura;
            Actualizacion = actualizacion;
            Eliminacion = eliminacion;
            Formulario = formulario;
            FKIDUsuario = fKIDUsuario;
        }
        public entidadPermisos()
        {

        }

        public string Matricula { get; set; }
        public int Lectura { get; set; }
        public int Escritura { get; set; }
        public int Actualizacion { get; set; }
        public int Eliminacion { get; set; }
        public string Formulario { get; set; }
        public int FKIDUsuario { get; set; }




    }
}

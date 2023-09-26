namespace ApiPruebaTecnica.Modelo
{
    public class Trabajador
    {
        public int TrabajadorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime Fecha_Inicio_Vigencia { get; set; }
        public bool Contratado { get; set; }
    }
}

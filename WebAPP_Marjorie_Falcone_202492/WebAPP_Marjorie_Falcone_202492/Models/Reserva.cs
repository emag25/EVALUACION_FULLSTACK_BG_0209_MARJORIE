namespace WebAPP_Marjorie_Falcone_202492.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string TipoAlojamiento { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public int NumeroPersonas { get; set; }
        public List<ServicioAdicional> ServiciosAdicionales { get; set; }

    }
}

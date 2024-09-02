namespace WebAPI_Marjorie_Falcone__202492
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

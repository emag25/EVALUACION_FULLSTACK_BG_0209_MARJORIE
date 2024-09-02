using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Marjorie_Falcone__202492.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservasController : ControllerBase
    {
        private static List<Reserva> reservas = new List<Reserva>();

        [HttpGet]
        public IEnumerable<Reserva> Get()
        {
            return reservas;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var reserva = reservas.FirstOrDefault(r => r.Id == id);
            if (reserva == null)
            {
                return NotFound();
            }
            return Ok(reserva);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Reserva reserva)
        {
            reservas.Add(reserva);
            return CreatedAtAction(nameof(Get), new { id = reserva.Id }, reserva);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Reserva updatedReserva)
        {
            var reserva = reservas.FirstOrDefault(r => r.Id == id);
            if (reserva == null)
            {
                return NotFound();
            }
            reserva.TipoAlojamiento = updatedReserva.TipoAlojamiento;
            reserva.FechaEntrada = updatedReserva.FechaEntrada;
            reserva.FechaSalida = updatedReserva.FechaSalida;
            reserva.NumeroPersonas = updatedReserva.NumeroPersonas;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var reserva = reservas.FirstOrDefault(r => r.Id == id);
            if (reserva == null)
            {
                return NotFound();
            }
            reservas.Remove(reserva);
            return NoContent();
        }
    }
}

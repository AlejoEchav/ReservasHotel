using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel
{
    public class HabitacionEstandar : Reserva
    {
        public double TarifaFija { get; set; }

        public HabitacionEstandar(string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstadia, double tarifaFija)
            : base(nombreCliente, numeroHabitacion, fechaReserva, duracionEstadia)
        {
            if (tarifaFija <= 0)
                throw new ArgumentException("La tarifa debe ser mayor a 0.");

            TarifaFija = tarifaFija;
        }

        public override double CalcularCostoTotal()
        {
            return TarifaFija * DuracionEstadia;
        }
    }
}

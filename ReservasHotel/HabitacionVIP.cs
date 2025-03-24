using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel
{
    public class HabitacionVIP : Reserva
    {
        public double TarifaBase { get; set; }
        private const double DescuentoVIP = 0.20;

        public HabitacionVIP(string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstadia, double tarifaBase)
            : base(nombreCliente, numeroHabitacion, fechaReserva, duracionEstadia)
        {
            if (tarifaBase <= 0)
                throw new ArgumentException("La tarifa debe ser mayor a 0.");

            TarifaBase = tarifaBase;
        }

        public override double CalcularCostoTotal()
        {
            double total = TarifaBase * DuracionEstadia;

            if (DuracionEstadia > 5)
                total -= total * DescuentoVIP;

            return total;
        }
    }
}

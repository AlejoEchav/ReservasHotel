using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel
{
    public class HabitacionVIP : Reserva
    {
        public double TarifaPorNoche { get; set; }
        private const double DescuentoVIP = 0.20;

        public HabitacionVIP(string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstadia, double tarifaPorNoche)
            : base(nombreCliente, numeroHabitacion, fechaReserva, duracionEstadia)
        {
            if (tarifaPorNoche <= 0)
                throw new ArgumentException("La tarifa debe ser mayor a 0.");

            TarifaPorNoche = tarifaPorNoche;
        }

        public override double CalcularCostoTotal()
        {
            double total = TarifaPorNoche * DuracionEstadia;

            if (DuracionEstadia > 5)
                total -= total * DescuentoVIP;

            return total;
        }

        public new double CalcularCostoTotal(int noches)
        {
            return base.CalcularCostoTotal(noches, TarifaPorNoche);
        }
    }
}

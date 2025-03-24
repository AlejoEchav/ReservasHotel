using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel
{
    public class GestorReservas
    {
        private static GestorReservas instancia;
        private List<Reserva> listaReservas;

        private GestorReservas()
        {
            listaReservas = new List<Reserva>();
        }

        public static GestorReservas ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GestorReservas();
            }
            return instancia;
        }

        public void AgregarReserva(Reserva reserva)
        {
            foreach (var r in listaReservas)
            {
                if (r.NumeroHabitacion == reserva.NumeroHabitacion && r.FechaReserva == reserva.FechaReserva)
                {
                    throw new Exception("Ya existe una reserva para esta habitación en la misma fecha.");
                }
            }

            listaReservas.Add(reserva);
        }

        public void EliminarReserva(int numeroHabitacion, DateTime fechaReserva)
        {
            Reserva reserva = listaReservas.Find(r => r.NumeroHabitacion == numeroHabitacion && r.FechaReserva == fechaReserva);

            if (reserva != null)
            {
                listaReservas.Remove(reserva);
            }
            else
            {
                throw new Exception("No se encontró la reserva a eliminar.");
            }
        }

        public List<Reserva> ObtenerReservas()
        {
            return listaReservas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel
{
    public class GestorReservas
    {
        private static GestorReservas _instancia = new GestorReservas();
        public static GestorReservas instancia { get { return _instancia; } }

        private List<Reserva> listaReservas = new List<Reserva>();

        public void AgregarReserva(Reserva reserva)
        {
            listaReservas.Add(reserva);
        }

        public List<Reserva> ObtenerReservas()
        {
            if (listaReservas == null)
            {
                listaReservas = new List<Reserva>(); 
            }
            return listaReservas;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel
{
    public class Reserva
    {
        public string NombreCliente { get; set; }
        public int NumeroHabitacion { get; set; }
        public DateTime FechaReserva { get; set; }
        public int DuracionEstadia { get; set; }

        public Reserva(string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstadia)
        {
            if (string.IsNullOrWhiteSpace(nombreCliente))
                throw new ArgumentException("El nombre del cliente es obligatorio.");
            if (duracionEstadia < 1)
                throw new ArgumentException("La duración de la estadía debe ser mayor a 1 noche.");

            NombreCliente = nombreCliente;
            NumeroHabitacion = numeroHabitacion;
            FechaReserva = fechaReserva;
            DuracionEstadia = duracionEstadia;
        }

        public virtual double CalcularCostoTotal()
        {
            return 0; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasHotel
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {           

            if (cmbTipoHabitacion.SelectedItem != null)
            {
                string tipoHabitacion = cmbTipoHabitacion.SelectedItem.ToString();

                if (tipoHabitacion == "Estandar")
                {
                    FormReservaEstandar formEstandar = new FormReservaEstandar();
                    formEstandar.ShowDialog();
                }
                else if (tipoHabitacion == "VIP")
                {
                    FormReservaVIP formVIP = new FormReservaVIP();
                    formVIP.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de habitación antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnVerReservas_Click(object sender, EventArgs e)
        {

            var reservas = GestorReservas.instancia.ObtenerReservas();
    MessageBox.Show("Cantidad de reservas guardadas: " + reservas.Count);

            FormVerReservas formVerReservas = new FormVerReservas();
            formVerReservas.ShowDialog();
        }


    }
}

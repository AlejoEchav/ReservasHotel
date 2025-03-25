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
    public partial class FormReservaVIP: Form
    {
        public FormReservaVIP()
        {
            InitializeComponent();
        }

        private void FormReservaVIP_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                    string.IsNullOrWhiteSpace(txtNumeroHabitacion.Text) ||
                    string.IsNullOrWhiteSpace(txtDuracionEstadia.Text) ||
                    string.IsNullOrWhiteSpace(txtTarifa.Text) ||
                    string.IsNullOrWhiteSpace(txtDescuentoVIP.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtNumeroHabitacion.Text, out int numHabitacion) ||
                    !int.TryParse(txtDuracionEstadia.Text, out int duracion) ||
                    !decimal.TryParse(txtTarifa.Text, out decimal tarifa) ||
                    !decimal.TryParse(txtDescuentoVIP.Text, out decimal descuento) ||
                    duracion < 1 || tarifa <= 0 || descuento < 0 || descuento > 100)
                {
                    MessageBox.Show("Verifique los valores ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (duracion > 5)
                {
                    tarifa -= tarifa * (descuento / 100);
                }

                MessageBox.Show($"Reserva VIP guardada. Tarifa aplicada: {tarifa:C}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show($"Total de reservas en memoria: {GestorReservas.instancia.ObtenerReservas().Count}");

                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

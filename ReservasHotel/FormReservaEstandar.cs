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
    public partial class FormReservaEstandar: Form
    {
        public FormReservaEstandar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                    string.IsNullOrWhiteSpace(txtNumeroHabitacion.Text) ||
                    string.IsNullOrWhiteSpace(txtDuracionEstadia.Text) ||
                    string.IsNullOrWhiteSpace(txtTarifa.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtNumeroHabitacion.Text, out int numHabitacion) ||
                    !int.TryParse(txtDuracionEstadia.Text, out int duracion) ||
                    !decimal.TryParse(txtTarifa.Text, out decimal tarifa) ||
                    duracion < 1 || tarifa <= 0)
                {
                    MessageBox.Show("Verifique que los valores numéricos sean correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 📌 Crear el objeto Reserva
                HabitacionEstandar nuevaReserva = new HabitacionEstandar(txtNombreCliente.Text, numHabitacion, DateTime.Now, duracion, tarifa);

                // 📌 Guardar la reserva en GestorReservas
                GestorReservas.instancia.AgregarReserva(nuevaReserva);

                // 📌 Mostrar cuántas reservas hay ahora
                MessageBox.Show($"Reserva guardada con éxito.\nTotal de reservas: {GestorReservas.instancia.ObtenerReservas().Count}",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtNumeroHabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDuracionEstadia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y un punto decimal.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormReservaEstandar_Load(object sender, EventArgs e)
        {
        }
    }
}

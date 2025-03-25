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
    public partial class FormVerReservas: Form
    {
        public FormVerReservas()
        {
            InitializeComponent();
        }

        private void FormVerReservas_Load(object sender, EventArgs e)
        {

            var reservas = GestorReservas.instancia.ObtenerReservas();

            if (reservas.Count == 0)
            {
                MessageBox.Show("No hay reservas registradas.");
            }

            dgvReservas.DataSource = null;
            dgvReservas.DataSource = GestorReservas.instancia.ObtenerReservas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

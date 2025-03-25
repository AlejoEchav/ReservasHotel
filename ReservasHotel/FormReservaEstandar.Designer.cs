namespace ReservasHotel
{
    partial class FormReservaEstandar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblNumeroHabitacion = new System.Windows.Forms.Label();
            this.txtNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.lblDuracionEstadia = new System.Windows.Forms.Label();
            this.txtDuracionEstadia = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserva Habitación Estandar";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(318, 118);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(165, 20);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(211, 121);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(101, 13);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = " Nombre del cliente:";
            // 
            // lblNumeroHabitacion
            // 
            this.lblNumeroHabitacion.AutoSize = true;
            this.lblNumeroHabitacion.Location = new System.Drawing.Point(198, 155);
            this.lblNumeroHabitacion.Name = "lblNumeroHabitacion";
            this.lblNumeroHabitacion.Size = new System.Drawing.Size(114, 13);
            this.lblNumeroHabitacion.TabIndex = 3;
            this.lblNumeroHabitacion.Text = "Numero de habitación:";
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(318, 155);
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(165, 20);
            this.txtNumeroHabitacion.TabIndex = 4;
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(214, 193);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(98, 13);
            this.lblFechaReserva.TabIndex = 5;
            this.lblFechaReserva.Text = "Fecha de Reserva:";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(318, 193);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReserva.TabIndex = 6;
            // 
            // lblDuracionEstadia
            // 
            this.lblDuracionEstadia.AutoSize = true;
            this.lblDuracionEstadia.Location = new System.Drawing.Point(193, 231);
            this.lblDuracionEstadia.Name = "lblDuracionEstadia";
            this.lblDuracionEstadia.Size = new System.Drawing.Size(119, 26);
            this.lblDuracionEstadia.TabIndex = 7;
            this.lblDuracionEstadia.Text = "Duración de la Estadía:\r\n(En días)";
            // 
            // txtDuracionEstadia
            // 
            this.txtDuracionEstadia.Location = new System.Drawing.Point(319, 236);
            this.txtDuracionEstadia.Name = "txtDuracionEstadia";
            this.txtDuracionEstadia.Size = new System.Drawing.Size(164, 20);
            this.txtDuracionEstadia.TabIndex = 8;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(214, 280);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(90, 13);
            this.lblTarifa.TabIndex = 9;
            this.lblTarifa.Text = "Tarifa por Noche:";
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(319, 280);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(164, 20);
            this.txtTarifa.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(289, 323);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar Reserva";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormReservaEstandar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.txtDuracionEstadia);
            this.Controls.Add(this.lblDuracionEstadia);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.txtNumeroHabitacion);
            this.Controls.Add(this.lblNumeroHabitacion);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label1);
            this.Name = "FormReservaEstandar";
            this.Text = "FormReservaEstandar";
            this.Load += new System.EventHandler(this.FormReservaEstandar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblNumeroHabitacion;
        private System.Windows.Forms.TextBox txtNumeroHabitacion;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.Label lblDuracionEstadia;
        private System.Windows.Forms.TextBox txtDuracionEstadia;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Button btnGuardar;
    }
}
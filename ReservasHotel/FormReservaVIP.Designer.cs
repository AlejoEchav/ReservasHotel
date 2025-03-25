namespace ReservasHotel
{
    partial class FormReservaVIP
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtDuracionEstadia = new System.Windows.Forms.TextBox();
            this.lblDuracionEstadia = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.txtNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.lblNumeroHabitacion = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescuentoVIP = new System.Windows.Forms.Label();
            this.txtDescuentoVIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(334, 347);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar Reserva";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(358, 251);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(164, 20);
            this.txtTarifa.TabIndex = 22;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(253, 251);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(90, 13);
            this.lblTarifa.TabIndex = 21;
            this.lblTarifa.Text = "Tarifa por Noche:";
            // 
            // txtDuracionEstadia
            // 
            this.txtDuracionEstadia.Location = new System.Drawing.Point(358, 207);
            this.txtDuracionEstadia.Name = "txtDuracionEstadia";
            this.txtDuracionEstadia.Size = new System.Drawing.Size(164, 20);
            this.txtDuracionEstadia.TabIndex = 20;
            // 
            // lblDuracionEstadia
            // 
            this.lblDuracionEstadia.AutoSize = true;
            this.lblDuracionEstadia.Location = new System.Drawing.Point(232, 202);
            this.lblDuracionEstadia.Name = "lblDuracionEstadia";
            this.lblDuracionEstadia.Size = new System.Drawing.Size(119, 26);
            this.lblDuracionEstadia.TabIndex = 19;
            this.lblDuracionEstadia.Text = "Duración de la Estadía:\r\n(En días)";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(357, 164);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReserva.TabIndex = 18;
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(253, 164);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(98, 13);
            this.lblFechaReserva.TabIndex = 17;
            this.lblFechaReserva.Text = "Fecha de Reserva:";
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(357, 126);
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(165, 20);
            this.txtNumeroHabitacion.TabIndex = 16;
            // 
            // lblNumeroHabitacion
            // 
            this.lblNumeroHabitacion.AutoSize = true;
            this.lblNumeroHabitacion.Location = new System.Drawing.Point(237, 126);
            this.lblNumeroHabitacion.Name = "lblNumeroHabitacion";
            this.lblNumeroHabitacion.Size = new System.Drawing.Size(114, 13);
            this.lblNumeroHabitacion.TabIndex = 15;
            this.lblNumeroHabitacion.Text = "Numero de habitación:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(250, 92);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(101, 13);
            this.lblNombreCliente.TabIndex = 14;
            this.lblNombreCliente.Text = " Nombre del cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(357, 89);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(165, 20);
            this.txtNombreCliente.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reserva Habitación VIP";
            // 
            // lblDescuentoVIP
            // 
            this.lblDescuentoVIP.AutoSize = true;
            this.lblDescuentoVIP.Location = new System.Drawing.Point(252, 297);
            this.lblDescuentoVIP.Name = "lblDescuentoVIP";
            this.lblDescuentoVIP.Size = new System.Drawing.Size(99, 13);
            this.lblDescuentoVIP.TabIndex = 24;
            this.lblDescuentoVIP.Text = "Descuento (%) VIP:";
            // 
            // txtDescuentoVIP
            // 
            this.txtDescuentoVIP.Location = new System.Drawing.Point(358, 297);
            this.txtDescuentoVIP.Name = "txtDescuentoVIP";
            this.txtDescuentoVIP.Size = new System.Drawing.Size(164, 20);
            this.txtDescuentoVIP.TabIndex = 25;
            // 
            // FormReservaVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDescuentoVIP);
            this.Controls.Add(this.lblDescuentoVIP);
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
            this.Name = "FormReservaVIP";
            this.Text = "FormReservaVIP";
            this.Load += new System.EventHandler(this.FormReservaVIP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtDuracionEstadia;
        private System.Windows.Forms.Label lblDuracionEstadia;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.TextBox txtNumeroHabitacion;
        private System.Windows.Forms.Label lblNumeroHabitacion;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescuentoVIP;
        private System.Windows.Forms.TextBox txtDescuentoVIP;
    }
}
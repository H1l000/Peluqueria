namespace peluqueria
{
    partial class AnyadirServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnyadirServicios));
            panelMenu = new Panel();
            logOutButton = new Button();
            btnClientes = new Button();
            btnEmpleados = new Button();
            btnServicios = new Button();
            pictureBox1 = new PictureBox();
            btnInicio = new Button();
            panelAnyadirServicios = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panelAnyadirServicio = new Panel();
            label2 = new Label();
            label3 = new Label();
            txtBoxTituloServicio = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtBoxDescripcion = new TextBox();
            label6 = new Label();
            txtBoxBloqueDeTiempo = new TextBox();
            btnGuardarServicio = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelAnyadirServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAnyadirServicio.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkGray;
            panelMenu.Controls.Add(logOutButton);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnEmpleados);
            panelMenu.Controls.Add(btnServicios);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(181, 691);
            panelMenu.TabIndex = 2;
            // 
            // logOutButton
            // 
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Location = new Point(26, 627);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(123, 27);
            logOutButton.TabIndex = 5;
            logOutButton.Text = "Cerrar sesión";
            logOutButton.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Location = new Point(45, 378);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(75, 27);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Location = new Point(45, 285);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(75, 27);
            btnEmpleados.TabIndex = 3;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnServicios
            // 
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Location = new Point(45, 204);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(75, 23);
            btnServicios.TabIndex = 2;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnInicio
            // 
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Location = new Point(45, 118);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(75, 23);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // panelAnyadirServicios
            // 
            panelAnyadirServicios.Controls.Add(pictureBox2);
            panelAnyadirServicios.Controls.Add(label1);
            panelAnyadirServicios.Dock = DockStyle.Top;
            panelAnyadirServicios.Location = new Point(181, 0);
            panelAnyadirServicios.Name = "panelAnyadirServicios";
            panelAnyadirServicios.Size = new Size(875, 77);
            panelAnyadirServicios.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(190, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 17);
            label1.Name = "label1";
            label1.Size = new Size(344, 47);
            label1.TabIndex = 0;
            label1.Text = "AÑADIR SERVICIOS";
            // 
            // panelAnyadirServicio
            // 
            panelAnyadirServicio.Controls.Add(btnGuardarServicio);
            panelAnyadirServicio.Controls.Add(label6);
            panelAnyadirServicio.Controls.Add(txtBoxBloqueDeTiempo);
            panelAnyadirServicio.Controls.Add(label5);
            panelAnyadirServicio.Controls.Add(txtBoxDescripcion);
            panelAnyadirServicio.Controls.Add(label4);
            panelAnyadirServicio.Controls.Add(txtBoxTituloServicio);
            panelAnyadirServicio.Controls.Add(label3);
            panelAnyadirServicio.Controls.Add(label2);
            panelAnyadirServicio.Dock = DockStyle.Fill;
            panelAnyadirServicio.Location = new Point(181, 77);
            panelAnyadirServicio.Name = "panelAnyadirServicio";
            panelAnyadirServicio.Size = new Size(875, 614);
            panelAnyadirServicio.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(248, 92);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 0;
            label2.Text = "NUEVO SERVICIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(248, 147);
            label3.Name = "label3";
            label3.Size = new Size(359, 40);
            label3.TabIndex = 1;
            label3.Text = "FORMULARIO SERVICIOS";
            // 
            // txtBoxTituloServicio
            // 
            txtBoxTituloServicio.Location = new Point(248, 256);
            txtBoxTituloServicio.Name = "txtBoxTituloServicio";
            txtBoxTituloServicio.Size = new Size(359, 23);
            txtBoxTituloServicio.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 224);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 3;
            label4.Text = "Título del servicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 313);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 5;
            label5.Text = "Descripción";
            // 
            // txtBoxDescripcion
            // 
            txtBoxDescripcion.Location = new Point(248, 350);
            txtBoxDescripcion.Name = "txtBoxDescripcion";
            txtBoxDescripcion.Size = new Size(359, 23);
            txtBoxDescripcion.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(265, 412);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 7;
            label6.Text = "Bloque de tiempo";
            // 
            // txtBoxBloqueDeTiempo
            // 
            txtBoxBloqueDeTiempo.Location = new Point(248, 444);
            txtBoxBloqueDeTiempo.Name = "txtBoxBloqueDeTiempo";
            txtBoxBloqueDeTiempo.Size = new Size(359, 23);
            txtBoxBloqueDeTiempo.TabIndex = 6;
            // 
            // btnGuardarServicio
            // 
            btnGuardarServicio.BackColor = Color.IndianRed;
            btnGuardarServicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarServicio.Location = new Point(265, 515);
            btnGuardarServicio.Name = "btnGuardarServicio";
            btnGuardarServicio.Size = new Size(321, 36);
            btnGuardarServicio.TabIndex = 8;
            btnGuardarServicio.Text = "GUARDAR";
            btnGuardarServicio.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 691);
            Controls.Add(panelAnyadirServicio);
            Controls.Add(panelAnyadirServicios);
            Controls.Add(panelMenu);
            Name = "Form3";
            Text = "Form3";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelAnyadirServicios.ResumeLayout(false);
            panelAnyadirServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAnyadirServicio.ResumeLayout(false);
            panelAnyadirServicio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button logOutButton;
        private Button btnClientes;
        private Button btnEmpleados;
        private Button btnServicios;
        private PictureBox pictureBox1;
        private Button btnInicio;
        private Panel panelAnyadirServicios;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panelAnyadirServicio;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxTituloServicio;
        private Label label6;
        private TextBox txtBoxBloqueDeTiempo;
        private Label label5;
        private TextBox txtBoxDescripcion;
        private Button btnGuardarServicio;
    }
}
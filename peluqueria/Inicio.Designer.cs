namespace peluqueria
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panelMenu = new Panel();
            logOutButton = new Button();
            btnClientes = new Button();
            btnEmpleados = new Button();
            btnServicios = new Button();
            btnInicio = new Button();
            panelInicioArriba = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            numCitas = new Label();
            label2 = new Label();
            panelCitasHoy = new Panel();
            dtgrdVwCitasHoy = new DataGridView();
            panel3 = new Panel();
            numClientes = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelInicioArriba.SuspendLayout();
            panel2.SuspendLayout();
            panelCitasHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrdVwCitasHoy).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkGray;
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(logOutButton);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnEmpleados);
            panelMenu.Controls.Add(btnServicios);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(181, 691);
            panelMenu.TabIndex = 0;
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
            // panelInicioArriba
            // 
            panelInicioArriba.Controls.Add(label1);
            panelInicioArriba.Dock = DockStyle.Top;
            panelInicioArriba.Location = new Point(181, 0);
            panelInicioArriba.Name = "panelInicioArriba";
            panelInicioArriba.Size = new Size(875, 77);
            panelInicioArriba.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 18);
            label1.Name = "label1";
            label1.Size = new Size(647, 47);
            label1.TabIndex = 0;
            label1.Text = "INICIO | PANEL DE ADMINISTRACIÓN";
            // 
            // panel2
            // 
            panel2.Controls.Add(numCitas);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(232, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 128);
            panel2.TabIndex = 2;
            // 
            // numCitas
            // 
            numCitas.AutoSize = true;
            numCitas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numCitas.Location = new Point(105, 56);
            numCitas.Name = "numCitas";
            numCitas.Size = new Size(25, 30);
            numCitas.TabIndex = 1;
            numCitas.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 4);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 0;
            label2.Text = "Citas de hoy";
            // 
            // panelCitasHoy
            // 
            panelCitasHoy.Controls.Add(dtgrdVwCitasHoy);
            panelCitasHoy.Location = new Point(232, 285);
            panelCitasHoy.Name = "panelCitasHoy";
            panelCitasHoy.Size = new Size(795, 394);
            panelCitasHoy.TabIndex = 3;
            // 
            // dtgrdVwCitasHoy
            // 
            dtgrdVwCitasHoy.AllowUserToAddRows = false;
            dtgrdVwCitasHoy.AllowUserToDeleteRows = false;
            dtgrdVwCitasHoy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrdVwCitasHoy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrdVwCitasHoy.Dock = DockStyle.Fill;
            dtgrdVwCitasHoy.Location = new Point(0, 0);
            dtgrdVwCitasHoy.Name = "dtgrdVwCitasHoy";
            dtgrdVwCitasHoy.ReadOnly = true;
            dtgrdVwCitasHoy.RowHeadersVisible = false;
            dtgrdVwCitasHoy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgrdVwCitasHoy.Size = new Size(795, 394);
            dtgrdVwCitasHoy.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(numClientes);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(533, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 128);
            panel3.TabIndex = 4;
            // 
            // numClientes
            // 
            numClientes.AutoSize = true;
            numClientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numClientes.Location = new Point(105, 56);
            numClientes.Name = "numClientes";
            numClientes.Size = new Size(25, 30);
            numClientes.TabIndex = 1;
            numClientes.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 8);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 0;
            label4.Text = "Clientes atendidos hoy";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 691);
            Controls.Add(panel3);
            Controls.Add(panelCitasHoy);
            Controls.Add(panel2);
            Controls.Add(panelInicioArriba);
            Controls.Add(panelMenu);
            Name = "Inicio";
            Text = "Form1";
            Load += Inicio_Load;
            panelMenu.ResumeLayout(false);
            panelInicioArriba.ResumeLayout(false);
            panelInicioArriba.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelCitasHoy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgrdVwCitasHoy).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnInicio;
        private Button logOutButton;
        private Button btnClientes;
        private Button btnEmpleados;
        private Button btnServicios;
        private Panel panelInicioArriba;
        private Label label1;
        private Panel panel2;
        private Label numCitas;
        private Label label2;
        private Panel panelCitasHoy;
        private Panel panel3;
        private Label numClientes;
        private Label label4;
        private DataGridView dtgrdVwCitasHoy;
        private PictureBox pictureBox1;
    }
}
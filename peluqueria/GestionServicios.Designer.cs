namespace peluqueria
{
    partial class GestionServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionServicios));
            panelMenu = new Panel();
            logOutButton = new Button();
            btnClientes = new Button();
            btnEmpleados = new Button();
            btnServicios = new Button();
            pictureBox1 = new PictureBox();
            btnInicio = new Button();
            panelServicios = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panelAcciones = new Panel();
            imgAnyadirServicio = new PictureBox();
            imgEditarServicio = new PictureBox();
            imgEliminarServicio = new PictureBox();
            btnAnyadirServicio = new Button();
            btnEditarServicio = new Button();
            btnEliminarServicio = new Button();
            panelTablaServicios = new Panel();
            dtGrdVwServicios = new DataGridView();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAnyadirServicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgEditarServicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgEliminarServicio).BeginInit();
            panelTablaServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrdVwServicios).BeginInit();
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
            panelMenu.TabIndex = 1;
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
            // panelServicios
            // 
            panelServicios.Controls.Add(pictureBox2);
            panelServicios.Controls.Add(label1);
            panelServicios.Dock = DockStyle.Top;
            panelServicios.Location = new Point(181, 0);
            panelServicios.Name = "panelServicios";
            panelServicios.Size = new Size(875, 77);
            panelServicios.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 17);
            label1.Name = "label1";
            label1.Size = new Size(412, 47);
            label1.TabIndex = 0;
            label1.Text = "GESTIÓN DE SERVICIOS";
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
            // panelAcciones
            // 
            panelAcciones.Controls.Add(btnEliminarServicio);
            panelAcciones.Controls.Add(btnEditarServicio);
            panelAcciones.Controls.Add(btnAnyadirServicio);
            panelAcciones.Controls.Add(imgEliminarServicio);
            panelAcciones.Controls.Add(imgEditarServicio);
            panelAcciones.Controls.Add(imgAnyadirServicio);
            panelAcciones.Dock = DockStyle.Top;
            panelAcciones.Location = new Point(181, 77);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Padding = new Padding(10);
            panelAcciones.Size = new Size(875, 188);
            panelAcciones.TabIndex = 3;
            // 
            // imgAnyadirServicio
            // 
            imgAnyadirServicio.ErrorImage = null;
            imgAnyadirServicio.Image = (Image)resources.GetObject("imgAnyadirServicio.Image");
            imgAnyadirServicio.Location = new Point(121, 40);
            imgAnyadirServicio.Name = "imgAnyadirServicio";
            imgAnyadirServicio.Size = new Size(138, 77);
            imgAnyadirServicio.SizeMode = PictureBoxSizeMode.Zoom;
            imgAnyadirServicio.TabIndex = 0;
            imgAnyadirServicio.TabStop = false;
            // 
            // imgEditarServicio
            // 
            imgEditarServicio.Image = (Image)resources.GetObject("imgEditarServicio.Image");
            imgEditarServicio.Location = new Point(369, 41);
            imgEditarServicio.Name = "imgEditarServicio";
            imgEditarServicio.Size = new Size(143, 76);
            imgEditarServicio.SizeMode = PictureBoxSizeMode.Zoom;
            imgEditarServicio.TabIndex = 1;
            imgEditarServicio.TabStop = false;
            // 
            // imgEliminarServicio
            // 
            imgEliminarServicio.Image = (Image)resources.GetObject("imgEliminarServicio.Image");
            imgEliminarServicio.Location = new Point(638, 41);
            imgEliminarServicio.Name = "imgEliminarServicio";
            imgEliminarServicio.Size = new Size(140, 76);
            imgEliminarServicio.SizeMode = PictureBoxSizeMode.Zoom;
            imgEliminarServicio.TabIndex = 2;
            imgEliminarServicio.TabStop = false;
            // 
            // btnAnyadirServicio
            // 
            btnAnyadirServicio.BackColor = Color.Silver;
            btnAnyadirServicio.FlatStyle = FlatStyle.Flat;
            btnAnyadirServicio.Location = new Point(140, 127);
            btnAnyadirServicio.Name = "btnAnyadirServicio";
            btnAnyadirServicio.Size = new Size(106, 25);
            btnAnyadirServicio.TabIndex = 3;
            btnAnyadirServicio.Text = "Añadir servicio";
            btnAnyadirServicio.UseVisualStyleBackColor = false;
            // 
            // btnEditarServicio
            // 
            btnEditarServicio.BackColor = Color.Silver;
            btnEditarServicio.FlatStyle = FlatStyle.Flat;
            btnEditarServicio.Location = new Point(387, 127);
            btnEditarServicio.Name = "btnEditarServicio";
            btnEditarServicio.Size = new Size(106, 25);
            btnEditarServicio.TabIndex = 4;
            btnEditarServicio.Text = "Editar servicio";
            btnEditarServicio.UseVisualStyleBackColor = false;
            // 
            // btnEliminarServicio
            // 
            btnEliminarServicio.BackColor = Color.Silver;
            btnEliminarServicio.FlatStyle = FlatStyle.Flat;
            btnEliminarServicio.Location = new Point(655, 127);
            btnEliminarServicio.Name = "btnEliminarServicio";
            btnEliminarServicio.Size = new Size(106, 25);
            btnEliminarServicio.TabIndex = 5;
            btnEliminarServicio.Text = "Eliminar Servicio";
            btnEliminarServicio.UseVisualStyleBackColor = false;
            // 
            // panelTablaServicios
            // 
            panelTablaServicios.Controls.Add(dtGrdVwServicios);
            panelTablaServicios.Dock = DockStyle.Fill;
            panelTablaServicios.Location = new Point(181, 265);
            panelTablaServicios.Name = "panelTablaServicios";
            panelTablaServicios.Size = new Size(875, 426);
            panelTablaServicios.TabIndex = 4;
            // 
            // dtGrdVwServicios
            // 
            dtGrdVwServicios.AllowUserToAddRows = false;
            dtGrdVwServicios.AllowUserToDeleteRows = false;
            dtGrdVwServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGrdVwServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdVwServicios.Dock = DockStyle.Fill;
            dtGrdVwServicios.Location = new Point(0, 0);
            dtGrdVwServicios.Name = "dtGrdVwServicios";
            dtGrdVwServicios.ReadOnly = true;
            dtGrdVwServicios.RowHeadersVisible = false;
            dtGrdVwServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGrdVwServicios.Size = new Size(875, 426);
            dtGrdVwServicios.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 691);
            Controls.Add(panelTablaServicios);
            Controls.Add(panelAcciones);
            Controls.Add(panelServicios);
            Controls.Add(panelMenu);
            Name = "Form2";
            Text = "Form2";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelServicios.ResumeLayout(false);
            panelServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgAnyadirServicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgEditarServicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgEliminarServicio).EndInit();
            panelTablaServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGrdVwServicios).EndInit();
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
        private Panel panelServicios;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panelAcciones;
        private PictureBox imgAnyadirServicio;
        private PictureBox imgEliminarServicio;
        private PictureBox imgEditarServicio;
        private Button btnAnyadirServicio;
        private Button btnEditarServicio;
        private Button btnEliminarServicio;
        private Panel panelTablaServicios;
        private DataGridView dtGrdVwServicios;
    }
}
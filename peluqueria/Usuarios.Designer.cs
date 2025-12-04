namespace peluqueria
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            panelMenu = new Panel();
            panel1 = new Panel();
            logOutButton = new Button();
            btnEmpleados = new Button();
            btnServicios = new Button();
            pictureBox1 = new PictureBox();
            btnInicio = new Button();
            panelEditarServicios = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panelDGVwEmpleados = new Panel();
            btnClientes = new Button();
            dtGrdVwUsuarios = new DataGridView();
            panelAccionesUsuarios = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEditarServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelDGVwEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrdVwUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkGray;
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(logOutButton);
            panelMenu.Controls.Add(btnEmpleados);
            panelMenu.Controls.Add(btnServicios);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(181, 691);
            panelMenu.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Location = new Point(181, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 7;
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
            // panelEditarServicios
            // 
            panelEditarServicios.Controls.Add(pictureBox2);
            panelEditarServicios.Controls.Add(label1);
            panelEditarServicios.Dock = DockStyle.Top;
            panelEditarServicios.Location = new Point(181, 0);
            panelEditarServicios.Name = "panelEditarServicios";
            panelEditarServicios.Size = new Size(875, 77);
            panelEditarServicios.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(281, 18);
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
            label1.Location = new Point(373, 18);
            label1.Name = "label1";
            label1.Size = new Size(195, 47);
            label1.TabIndex = 0;
            label1.Text = "USUARIOS";
            // 
            // panelDGVwEmpleados
            // 
            panelDGVwEmpleados.Controls.Add(panelAccionesUsuarios);
            panelDGVwEmpleados.Controls.Add(dtGrdVwUsuarios);
            panelDGVwEmpleados.Dock = DockStyle.Top;
            panelDGVwEmpleados.Location = new Point(181, 77);
            panelDGVwEmpleados.Name = "panelDGVwEmpleados";
            panelDGVwEmpleados.Size = new Size(875, 614);
            panelDGVwEmpleados.TabIndex = 6;
            // 
            // btnClientes
            // 
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Location = new Point(45, 370);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(75, 27);
            btnClientes.TabIndex = 8;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // dtGrdVwUsuarios
            // 
            dtGrdVwUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdVwUsuarios.Location = new Point(0, 98);
            dtGrdVwUsuarios.Name = "dtGrdVwUsuarios";
            dtGrdVwUsuarios.Size = new Size(875, 516);
            dtGrdVwUsuarios.TabIndex = 9;
            // 
            // panelAccionesUsuarios
            // 
            panelAccionesUsuarios.Location = new Point(0, 98);
            panelAccionesUsuarios.Name = "panelAccionesUsuarios";
            panelAccionesUsuarios.Size = new Size(875, 56);
            panelAccionesUsuarios.TabIndex = 10;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 691);
            Controls.Add(panelDGVwEmpleados);
            Controls.Add(panelEditarServicios);
            Controls.Add(panelMenu);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEditarServicios.ResumeLayout(false);
            panelEditarServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelDGVwEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGrdVwUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button logOutButton;
        private Button btnEmpleados;
        private Button btnServicios;
        private PictureBox pictureBox1;
        private Button btnInicio;
        private Panel panelEditarServicios;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private Panel panelDGVwEmpleados;
        private Button btnClientes;
        private DataGridView dtGrdVwUsuarios;
        private Panel panelAccionesUsuarios;
    }
}
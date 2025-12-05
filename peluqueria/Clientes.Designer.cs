namespace peluqueria
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            panelMenu = new Panel();
            btnClientes = new Button();
            panel1 = new Panel();
            logOutButton = new Button();
            btnEmpleados = new Button();
            btnServicios = new Button();
            pictureBox1 = new PictureBox();
            btnInicio = new Button();
            panelClientes = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panelDGVClientes = new Panel();
            panelAccionesClientes = new Panel();
            dtGrdVwClientes = new DataGridView();
            panel2 = new Panel();
            btnEliminarCliente = new Button();
            btnEditarCliente = new Button();
            btnAnyadirCliente = new Button();
            imgEliminarCliente = new PictureBox();
            imgEditarCliente = new PictureBox();
            imgAnyadirCliente = new PictureBox();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelDGVClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrdVwClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgEliminarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgEditarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgAnyadirCliente).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkGray;
            panelMenu.Controls.Add(panel2);
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
            panelMenu.TabIndex = 5;
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
            // panelClientes
            // 
            panelClientes.Controls.Add(pictureBox2);
            panelClientes.Controls.Add(label1);
            panelClientes.Dock = DockStyle.Top;
            panelClientes.Location = new Point(181, 0);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(875, 77);
            panelClientes.TabIndex = 6;
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
            label1.Size = new Size(178, 47);
            label1.TabIndex = 0;
            label1.Text = "CLIENTES";
            // 
            // panelDGVClientes
            // 
            panelDGVClientes.Controls.Add(btnEliminarCliente);
            panelDGVClientes.Controls.Add(btnEditarCliente);
            panelDGVClientes.Controls.Add(btnAnyadirCliente);
            panelDGVClientes.Controls.Add(imgEliminarCliente);
            panelDGVClientes.Controls.Add(imgEditarCliente);
            panelDGVClientes.Controls.Add(imgAnyadirCliente);
            panelDGVClientes.Controls.Add(panelAccionesClientes);
            panelDGVClientes.Controls.Add(dtGrdVwClientes);
            panelDGVClientes.Dock = DockStyle.Fill;
            panelDGVClientes.Location = new Point(181, 77);
            panelDGVClientes.Name = "panelDGVClientes";
            panelDGVClientes.Size = new Size(875, 614);
            panelDGVClientes.TabIndex = 7;
            panelDGVClientes.Paint += panelDGVClientes_Paint;
            // 
            // panelAccionesClientes
            // 
            panelAccionesClientes.Location = new Point(0, 120);
            panelAccionesClientes.Name = "panelAccionesClientes";
            panelAccionesClientes.Size = new Size(875, 34);
            panelAccionesClientes.TabIndex = 11;
            // 
            // dtGrdVwClientes
            // 
            dtGrdVwClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdVwClientes.Location = new Point(0, 127);
            dtGrdVwClientes.Name = "dtGrdVwClientes";
            dtGrdVwClientes.Size = new Size(875, 487);
            dtGrdVwClientes.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Location = new Point(181, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(875, 105);
            panel2.TabIndex = 12;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.Silver;
            btnEliminarCliente.FlatStyle = FlatStyle.Flat;
            btnEliminarCliente.Location = new Point(633, 89);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(106, 25);
            btnEliminarCliente.TabIndex = 17;
            btnEliminarCliente.Text = "Eliminar cliente";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.Silver;
            btnEditarCliente.FlatStyle = FlatStyle.Flat;
            btnEditarCliente.Location = new Point(365, 89);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(106, 25);
            btnEditarCliente.TabIndex = 16;
            btnEditarCliente.Text = "Editar cliente";
            btnEditarCliente.UseVisualStyleBackColor = false;
            // 
            // btnAnyadirCliente
            // 
            btnAnyadirCliente.BackColor = Color.Silver;
            btnAnyadirCliente.FlatStyle = FlatStyle.Flat;
            btnAnyadirCliente.Location = new Point(118, 89);
            btnAnyadirCliente.Name = "btnAnyadirCliente";
            btnAnyadirCliente.Size = new Size(106, 25);
            btnAnyadirCliente.TabIndex = 15;
            btnAnyadirCliente.Text = "Añadir cliente";
            btnAnyadirCliente.UseVisualStyleBackColor = false;
            // 
            // imgEliminarCliente
            // 
            imgEliminarCliente.Image = (Image)resources.GetObject("imgEliminarCliente.Image");
            imgEliminarCliente.Location = new Point(616, 3);
            imgEliminarCliente.Name = "imgEliminarCliente";
            imgEliminarCliente.Size = new Size(140, 76);
            imgEliminarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            imgEliminarCliente.TabIndex = 14;
            imgEliminarCliente.TabStop = false;
            // 
            // imgEditarCliente
            // 
            imgEditarCliente.Image = (Image)resources.GetObject("imgEditarCliente.Image");
            imgEditarCliente.Location = new Point(347, 3);
            imgEditarCliente.Name = "imgEditarCliente";
            imgEditarCliente.Size = new Size(143, 76);
            imgEditarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            imgEditarCliente.TabIndex = 13;
            imgEditarCliente.TabStop = false;
            // 
            // imgAnyadirCliente
            // 
            imgAnyadirCliente.ErrorImage = null;
            imgAnyadirCliente.Image = (Image)resources.GetObject("imgAnyadirCliente.Image");
            imgAnyadirCliente.Location = new Point(99, 2);
            imgAnyadirCliente.Name = "imgAnyadirCliente";
            imgAnyadirCliente.Size = new Size(138, 77);
            imgAnyadirCliente.SizeMode = PictureBoxSizeMode.Zoom;
            imgAnyadirCliente.TabIndex = 12;
            imgAnyadirCliente.TabStop = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 691);
            Controls.Add(panelDGVClientes);
            Controls.Add(panelClientes);
            Controls.Add(panelMenu);
            Name = "Clientes";
            Text = "Form1";
            Load += Clientes_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelDGVClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGrdVwClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgEliminarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgEditarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgAnyadirCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnClientes;
        private Panel panel1;
        private Button logOutButton;
        private Button btnEmpleados;
        private Button btnServicios;
        private PictureBox pictureBox1;
        private Button btnInicio;
        private Panel panelClientes;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panelDGVClientes;
        private DataGridView dtGrdVwClientes;
        private Panel panelAccionesClientes;
        private Panel panel2;
        private Button btnEliminarCliente;
        private Button btnEditarCliente;
        private Button btnAnyadirCliente;
        private PictureBox imgEliminarCliente;
        private PictureBox imgEditarCliente;
        private PictureBox imgAnyadirCliente;
    }
}
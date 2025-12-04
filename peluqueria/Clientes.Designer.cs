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
            dtGrdVwClientes = new DataGridView();
            panelAccionesClientes = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelDGVClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrdVwClientes).BeginInit();
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
            panelDGVClientes.Controls.Add(panelAccionesClientes);
            panelDGVClientes.Controls.Add(dtGrdVwClientes);
            panelDGVClientes.Dock = DockStyle.Fill;
            panelDGVClientes.Location = new Point(181, 77);
            panelDGVClientes.Name = "panelDGVClientes";
            panelDGVClientes.Size = new Size(875, 614);
            panelDGVClientes.TabIndex = 7;
            // 
            // dtGrdVwClientes
            // 
            dtGrdVwClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdVwClientes.Location = new Point(0, 98);
            dtGrdVwClientes.Name = "dtGrdVwClientes";
            dtGrdVwClientes.Size = new Size(875, 516);
            dtGrdVwClientes.TabIndex = 8;
            // 
            // panelAccionesClientes
            // 
            panelAccionesClientes.Location = new Point(0, 98);
            panelAccionesClientes.Name = "panelAccionesClientes";
            panelAccionesClientes.Size = new Size(875, 56);
            panelAccionesClientes.TabIndex = 11;
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
            Load += this.Clientes_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelDGVClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGrdVwClientes).EndInit();
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
    }
}
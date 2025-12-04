namespace peluqueria
{
    partial class EliminarServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarServicios));
            panelMenu = new Panel();
            logOutButton = new Button();
            btnClientes = new Button();
            btnEmpleados = new Button();
            btnServicios = new Button();
            pictureBox1 = new PictureBox();
            btnInicio = new Button();
            panelEliminarServicios = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            txtBoxIDEliminar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnGuardarServicioEdit = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEliminarServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panelMenu.TabIndex = 4;
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
            // panelEliminarServicios
            // 
            panelEliminarServicios.Controls.Add(pictureBox2);
            panelEliminarServicios.Controls.Add(label1);
            panelEliminarServicios.Dock = DockStyle.Top;
            panelEliminarServicios.Location = new Point(181, 0);
            panelEliminarServicios.Name = "panelEliminarServicios";
            panelEliminarServicios.Size = new Size(875, 77);
            panelEliminarServicios.TabIndex = 5;
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
            label1.Size = new Size(375, 47);
            label1.TabIndex = 0;
            label1.Text = "ELIMINAR SERVICIOS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(471, 344);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 12;
            label7.Text = "ID";
            // 
            // txtBoxIDEliminar
            // 
            txtBoxIDEliminar.Location = new Point(451, 374);
            txtBoxIDEliminar.Name = "txtBoxIDEliminar";
            txtBoxIDEliminar.Size = new Size(359, 23);
            txtBoxIDEliminar.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(451, 251);
            label3.Name = "label3";
            label3.Size = new Size(403, 40);
            label3.TabIndex = 14;
            label3.Text = "ELIMINACIÓN DE SERVICIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(451, 196);
            label2.Name = "label2";
            label2.Size = new Size(202, 25);
            label2.TabIndex = 13;
            label2.Text = "ELIMINAR SERVICIOS";
            // 
            // btnGuardarServicioEdit
            // 
            btnGuardarServicioEdit.BackColor = Color.IndianRed;
            btnGuardarServicioEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarServicioEdit.Location = new Point(463, 464);
            btnGuardarServicioEdit.Name = "btnGuardarServicioEdit";
            btnGuardarServicioEdit.Size = new Size(321, 36);
            btnGuardarServicioEdit.TabIndex = 15;
            btnGuardarServicioEdit.Text = "ELIMINAR";
            btnGuardarServicioEdit.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 691);
            Controls.Add(btnGuardarServicioEdit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(txtBoxIDEliminar);
            Controls.Add(panelEliminarServicios);
            Controls.Add(panelMenu);
            Name = "Form5";
            Text = "Form5";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEliminarServicios.ResumeLayout(false);
            panelEliminarServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button logOutButton;
        private Button btnClientes;
        private Button btnEmpleados;
        private Button btnServicios;
        private PictureBox pictureBox1;
        private Button btnInicio;
        private Panel panelEliminarServicios;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label7;
        private TextBox txtBoxIDEliminar;
        private Label label3;
        private Label label2;
        private Button btnGuardarServicioEdit;
    }
}
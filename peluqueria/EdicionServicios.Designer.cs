namespace peluqueria
{
    partial class EdicionServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionServicios));
            panelMenu = new Panel();
            logOutButton = new Button();
            btnUsuarios = new Button();
            btnServicios = new Button();
            pictureBox1 = new PictureBox();
            btnInicio = new Button();
            panelEditarServicios = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panelEditarServicio = new Panel();
            label7 = new Label();
            txtBoxID = new TextBox();
            btnGuardarServicioEdit = new Button();
            label6 = new Label();
            txtBoxBloqueDeTiempoEdit = new TextBox();
            label5 = new Label();
            txtBoxDescripcionEdit = new TextBox();
            label4 = new Label();
            txtBoxTituloServicioEdit = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEditarServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelEditarServicio.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkGray;
            panelMenu.Controls.Add(logOutButton);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnServicios);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(181, 691);
            panelMenu.TabIndex = 3;
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
            // btnUsuarios
            // 
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Location = new Point(45, 285);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(75, 27);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
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
            panelEditarServicios.TabIndex = 4;
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
            label1.Size = new Size(329, 47);
            label1.TabIndex = 0;
            label1.Text = "EDITAR SERVICIOS";
            // 
            // panelEditarServicio
            // 
            panelEditarServicio.Controls.Add(label7);
            panelEditarServicio.Controls.Add(txtBoxID);
            panelEditarServicio.Controls.Add(btnGuardarServicioEdit);
            panelEditarServicio.Controls.Add(label6);
            panelEditarServicio.Controls.Add(txtBoxBloqueDeTiempoEdit);
            panelEditarServicio.Controls.Add(label5);
            panelEditarServicio.Controls.Add(txtBoxDescripcionEdit);
            panelEditarServicio.Controls.Add(label4);
            panelEditarServicio.Controls.Add(txtBoxTituloServicioEdit);
            panelEditarServicio.Controls.Add(label3);
            panelEditarServicio.Controls.Add(label2);
            panelEditarServicio.Dock = DockStyle.Fill;
            panelEditarServicio.Location = new Point(181, 77);
            panelEditarServicio.Name = "panelEditarServicio";
            panelEditarServicio.Size = new Size(875, 614);
            panelEditarServicio.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(272, 169);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 10;
            label7.Text = "ID";
            // 
            // txtBoxID
            // 
            txtBoxID.Location = new Point(252, 199);
            txtBoxID.Name = "txtBoxID";
            txtBoxID.Size = new Size(359, 23);
            txtBoxID.TabIndex = 9;
            // 
            // btnGuardarServicioEdit
            // 
            btnGuardarServicioEdit.BackColor = Color.IndianRed;
            btnGuardarServicioEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarServicioEdit.Location = new Point(269, 549);
            btnGuardarServicioEdit.Name = "btnGuardarServicioEdit";
            btnGuardarServicioEdit.Size = new Size(321, 36);
            btnGuardarServicioEdit.TabIndex = 8;
            btnGuardarServicioEdit.Text = "GUARDAR";
            btnGuardarServicioEdit.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 446);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 7;
            label6.Text = "Bloque de tiempo";
            // 
            // txtBoxBloqueDeTiempoEdit
            // 
            txtBoxBloqueDeTiempoEdit.Location = new Point(252, 478);
            txtBoxBloqueDeTiempoEdit.Name = "txtBoxBloqueDeTiempoEdit";
            txtBoxBloqueDeTiempoEdit.Size = new Size(359, 23);
            txtBoxBloqueDeTiempoEdit.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 347);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 5;
            label5.Text = "Descripción";
            // 
            // txtBoxDescripcionEdit
            // 
            txtBoxDescripcionEdit.Location = new Point(252, 384);
            txtBoxDescripcionEdit.Name = "txtBoxDescripcionEdit";
            txtBoxDescripcionEdit.Size = new Size(359, 23);
            txtBoxDescripcionEdit.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 258);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 3;
            label4.Text = "Título del servicio";
            // 
            // txtBoxTituloServicioEdit
            // 
            txtBoxTituloServicioEdit.Location = new Point(252, 290);
            txtBoxTituloServicioEdit.Name = "txtBoxTituloServicioEdit";
            txtBoxTituloServicioEdit.Size = new Size(359, 23);
            txtBoxTituloServicioEdit.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(248, 105);
            label3.Name = "label3";
            label3.Size = new Size(329, 40);
            label3.TabIndex = 1;
            label3.Text = "EDICIÓN DE SERVICIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(248, 50);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 0;
            label2.Text = "EDITAR SERVICIOS";
            // 
            // EdicionServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 691);
            Controls.Add(panelEditarServicio);
            Controls.Add(panelEditarServicios);
            Controls.Add(panelMenu);
            Name = "EdicionServicios";
            Text = "Form4";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEditarServicios.ResumeLayout(false);
            panelEditarServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelEditarServicio.ResumeLayout(false);
            panelEditarServicio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button logOutButton;
        private Button btnUsuarios;
        private Button btnServicios;
        private PictureBox pictureBox1;
        private Button btnInicio;
        private Panel panelEditarServicios;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panelEditarServicio;
        private Button btnGuardarServicioEdit;
        private Label label6;
        private TextBox txtBoxBloqueDeTiempoEdit;
        private Label label5;
        private TextBox txtBoxDescripcionEdit;
        private Label label4;
        private TextBox txtBoxTituloServicioEdit;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox txtBoxID;
    }
}
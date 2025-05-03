namespace bibliotecaForm.Formularios
{
    partial class FormPrestarLibro
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
            listLectores = new ListBox();
            listLibros = new ListBox();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtCantidadPrestamos = new TextBox();
            lblLectores = new Label();
            lblCantLibrosPrestados = new Label();
            lblEdadLector = new Label();
            lblNombreLector = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblLibros = new Label();
            txtEditorial = new TextBox();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            btnPrestar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // listLectores
            // 
            listLectores.FormattingEnabled = true;
            listLectores.HorizontalScrollbar = true;
            listLectores.ItemHeight = 15;
            listLectores.Location = new Point(46, 63);
            listLectores.Name = "listLectores";
            listLectores.Size = new Size(312, 94);
            listLectores.TabIndex = 0;
            listLectores.SelectedIndexChanged += listLectores_SelectedIndexChanged;
            // 
            // listLibros
            // 
            listLibros.FormattingEnabled = true;
            listLibros.HorizontalScrollbar = true;
            listLibros.ItemHeight = 15;
            listLibros.Location = new Point(46, 211);
            listLibros.Name = "listLibros";
            listLibros.RightToLeft = RightToLeft.No;
            listLibros.Size = new Size(312, 94);
            listLibros.TabIndex = 1;
            listLibros.SelectedIndexChanged += listLibros_SelectedIndexChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(506, 103);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(100, 54);
            txtDni.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(375, 103);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(100, 54);
            txtNombre.TabIndex = 3;
            // 
            // txtCantidadPrestamos
            // 
            txtCantidadPrestamos.Location = new Point(634, 103);
            txtCantidadPrestamos.Multiline = true;
            txtCantidadPrestamos.Name = "txtCantidadPrestamos";
            txtCantidadPrestamos.ReadOnly = true;
            txtCantidadPrestamos.Size = new Size(100, 54);
            txtCantidadPrestamos.TabIndex = 4;
            txtCantidadPrestamos.TextChanged += txtCantidadPrestamos_TextChanged;
            // 
            // lblLectores
            // 
            lblLectores.AutoSize = true;
            lblLectores.Location = new Point(46, 45);
            lblLectores.Name = "lblLectores";
            lblLectores.Size = new Size(118, 15);
            lblLectores.TabIndex = 5;
            lblLectores.Text = "SELECCIONE LECTOR";
            // 
            // lblCantLibrosPrestados
            // 
            lblCantLibrosPrestados.AutoSize = true;
            lblCantLibrosPrestados.Location = new Point(634, 85);
            lblCantLibrosPrestados.Name = "lblCantLibrosPrestados";
            lblCantLibrosPrestados.Size = new Size(79, 15);
            lblCantLibrosPrestados.TabIndex = 6;
            lblCantLibrosPrestados.Text = "N° Prestamos";
            // 
            // lblEdadLector
            // 
            lblEdadLector.AutoSize = true;
            lblEdadLector.Location = new Point(506, 85);
            lblEdadLector.Name = "lblEdadLector";
            lblEdadLector.Size = new Size(27, 15);
            lblEdadLector.TabIndex = 7;
            lblEdadLector.Text = "DNI";
            // 
            // lblNombreLector
            // 
            lblNombreLector.AutoSize = true;
            lblNombreLector.Location = new Point(375, 85);
            lblNombreLector.Name = "lblNombreLector";
            lblNombreLector.Size = new Size(51, 15);
            lblNombreLector.TabIndex = 8;
            lblNombreLector.Text = "Nombre";
            lblNombreLector.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 233);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 15;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 233);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 14;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(634, 233);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 13;
            label3.Text = "Editorial";
            // 
            // lblLibros
            // 
            lblLibros.AutoSize = true;
            lblLibros.Location = new Point(46, 193);
            lblLibros.Name = "lblLibros";
            lblLibros.Size = new Size(109, 15);
            lblLibros.TabIndex = 12;
            lblLibros.Text = "SELECCIONE LIBRO";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(634, 251);
            txtEditorial.Multiline = true;
            txtEditorial.Name = "txtEditorial";
            txtEditorial.ReadOnly = true;
            txtEditorial.Size = new Size(100, 54);
            txtEditorial.TabIndex = 11;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(375, 251);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(100, 54);
            txtTitulo.TabIndex = 10;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(506, 251);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.ReadOnly = true;
            txtAutor.Size = new Size(100, 54);
            txtAutor.TabIndex = 9;
            // 
            // btnPrestar
            // 
            btnPrestar.Font = new Font("Segoe UI", 20F);
            btnPrestar.Location = new Point(176, 353);
            btnPrestar.Name = "btnPrestar";
            btnPrestar.Size = new Size(170, 60);
            btnPrestar.TabIndex = 16;
            btnPrestar.Text = "PRESTAR";
            btnPrestar.UseVisualStyleBackColor = true;
            btnPrestar.Click += btnPrestar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 20F);
            btnCancelar.Location = new Point(425, 353);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(169, 60);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormPrestarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnPrestar);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblLibros);
            Controls.Add(txtEditorial);
            Controls.Add(txtTitulo);
            Controls.Add(txtAutor);
            Controls.Add(lblNombreLector);
            Controls.Add(lblEdadLector);
            Controls.Add(lblCantLibrosPrestados);
            Controls.Add(lblLectores);
            Controls.Add(txtCantidadPrestamos);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(listLibros);
            Controls.Add(listLectores);
            Name = "FormPrestarLibro";
            Text = "FormPrestarLibro";
            Load += FormPrestarLibro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listLectores;
        private ListBox listLibros;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtCantidadPrestamos;
        private Label lblLectores;
        private Label lblCantLibrosPrestados;
        private Label lblEdadLector;
        private Label lblNombreLector;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblLibros;
        private TextBox txtEditorial;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private Button btnPrestar;
        private Button btnCancelar;
    }
}
namespace bibliotecaForm.Formularios
{
    partial class FormPrestamos
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
            listLectores.Location = new Point(12, 28);
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
            listLibros.Location = new Point(12, 176);
            listLibros.Name = "listLibros";
            listLibros.RightToLeft = RightToLeft.No;
            listLibros.Size = new Size(312, 94);
            listLibros.TabIndex = 1;
            listLibros.SelectedIndexChanged += listLibros_SelectedIndexChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(472, 68);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(100, 54);
            txtDni.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(341, 68);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(100, 54);
            txtNombre.TabIndex = 3;
            // 
            // txtCantidadPrestamos
            // 
            txtCantidadPrestamos.Location = new Point(600, 68);
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
            lblLectores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLectores.Location = new Point(12, 10);
            lblLectores.Name = "lblLectores";
            lblLectores.Size = new Size(120, 15);
            lblLectores.TabIndex = 5;
            lblLectores.Text = "SELECCIONE LECTOR";
            // 
            // lblCantLibrosPrestados
            // 
            lblCantLibrosPrestados.AutoSize = true;
            lblCantLibrosPrestados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCantLibrosPrestados.Location = new Point(600, 50);
            lblCantLibrosPrestados.Name = "lblCantLibrosPrestados";
            lblCantLibrosPrestados.Size = new Size(82, 15);
            lblCantLibrosPrestados.TabIndex = 6;
            lblCantLibrosPrestados.Text = "N° Prestamos";
            // 
            // lblEdadLector
            // 
            lblEdadLector.AutoSize = true;
            lblEdadLector.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEdadLector.Location = new Point(472, 50);
            lblEdadLector.Name = "lblEdadLector";
            lblEdadLector.Size = new Size(29, 15);
            lblEdadLector.TabIndex = 7;
            lblEdadLector.Text = "DNI";
            // 
            // lblNombreLector
            // 
            lblNombreLector.AutoSize = true;
            lblNombreLector.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreLector.Location = new Point(341, 50);
            lblNombreLector.Name = "lblNombreLector";
            lblNombreLector.Size = new Size(53, 15);
            lblNombreLector.TabIndex = 8;
            lblNombreLector.Text = "Nombre";
            lblNombreLector.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(341, 198);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 15;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(472, 198);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 14;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(600, 198);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 13;
            label3.Text = "Editorial";
            // 
            // lblLibros
            // 
            lblLibros.AutoSize = true;
            lblLibros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLibros.Location = new Point(12, 158);
            lblLibros.Name = "lblLibros";
            lblLibros.Size = new Size(112, 15);
            lblLibros.TabIndex = 12;
            lblLibros.Text = "SELECCIONE LIBRO";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(600, 216);
            txtEditorial.Multiline = true;
            txtEditorial.Name = "txtEditorial";
            txtEditorial.ReadOnly = true;
            txtEditorial.Size = new Size(100, 54);
            txtEditorial.TabIndex = 11;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(341, 216);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(100, 54);
            txtTitulo.TabIndex = 10;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(472, 216);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.ReadOnly = true;
            txtAutor.Size = new Size(100, 54);
            txtAutor.TabIndex = 9;
            // 
            // btnPrestar
            // 
            btnPrestar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnPrestar.Location = new Point(142, 318);
            btnPrestar.Name = "btnPrestar";
            btnPrestar.Size = new Size(170, 60);
            btnPrestar.TabIndex = 16;
            btnPrestar.Text = "PRESTAR";
            btnPrestar.UseVisualStyleBackColor = true;
            btnPrestar.Click += btnPrestar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnCancelar.Location = new Point(391, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(169, 60);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(802, 463);
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
            Name = "FormPrestamos";
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
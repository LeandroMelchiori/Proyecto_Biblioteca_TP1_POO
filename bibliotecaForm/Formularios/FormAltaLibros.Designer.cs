namespace bibliotecaForm.Formularios
{
    partial class FormAltaLibros
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
            txtTitulo = new TextBox();
            txtEditorial = new TextBox();
            txtAutor = new TextBox();
            btnAgregar = new Button();
            lblLibros = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 15F);
            txtTitulo.Location = new Point(12, 27);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(221, 57);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Titulo";
            txtTitulo.Enter += txtTitulo_Enter;
            txtTitulo.Leave += txtTitulo_Leave;
            // 
            // txtEditorial
            // 
            txtEditorial.Font = new Font("Segoe UI", 15F);
            txtEditorial.Location = new Point(12, 179);
            txtEditorial.Multiline = true;
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(221, 57);
            txtEditorial.TabIndex = 1;
            txtEditorial.Text = "Editorial";
            txtEditorial.Enter += txtEditorial_Enter;
            txtEditorial.Leave += txtEditorial_Leave;
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Segoe UI", 15F);
            txtAutor.Location = new Point(12, 106);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(221, 57);
            txtAutor.TabIndex = 2;
            txtAutor.Text = "Autor";
            txtAutor.TextChanged += txtAutor_TextChanged;
            txtAutor.Enter += txtAutor_Enter;
            txtAutor.Leave += txtAutor_Leave;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 254);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(221, 46);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblLibros
            // 
            lblLibros.AutoSize = true;
            lblLibros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibros.Location = new Point(12, 9);
            lblLibros.Name = "lblLibros";
            lblLibros.Size = new Size(97, 15);
            lblLibros.TabIndex = 10;
            lblLibros.Text = "ALTA DE LIBROS";
            // 
            // FormAltaLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(380, 350);
            Controls.Add(lblLibros);
            Controls.Add(btnAgregar);
            Controls.Add(txtAutor);
            Controls.Add(txtEditorial);
            Controls.Add(txtTitulo);
            Name = "FormAltaLibros";
            Text = "FormAgregarLibro";
            Load += FormAgregarLibro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtEditorial;
        private TextBox txtAutor;
        private Button btnAgregar;
        private Label lblLibros;
    }
}
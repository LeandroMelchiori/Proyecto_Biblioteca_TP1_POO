namespace bibliotecaForm.Formularios
{
    partial class FormAgregarLibro
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
            btnCancelar = new Button();
            btnAltaLector = new Button();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 15F);
            txtTitulo.Location = new Point(132, 114);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(309, 57);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Titulo";
            txtTitulo.Enter += txtTitulo_Enter;
            txtTitulo.Leave += txtTitulo_Leave;
            // 
            // txtEditorial
            // 
            txtEditorial.Font = new Font("Segoe UI", 15F);
            txtEditorial.Location = new Point(132, 277);
            txtEditorial.Multiline = true;
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(309, 57);
            txtEditorial.TabIndex = 1;
            txtEditorial.Text = "Editorial";
            txtEditorial.Enter += txtEditorial_Enter;
            txtEditorial.Leave += txtEditorial_Leave;
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Segoe UI", 15F);
            txtAutor.Location = new Point(132, 193);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(309, 57);
            txtAutor.TabIndex = 2;
            txtAutor.Text = "Autor";
            txtAutor.TextChanged += txtAutor_TextChanged;
            txtAutor.Enter += txtAutor_Enter;
            txtAutor.Leave += txtAutor_Leave;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 15F);
            btnAgregar.Location = new Point(515, 139);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 62);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15F);
            btnCancelar.Location = new Point(515, 238);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 62);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAltaLector
            // 
            btnAltaLector.Location = new Point(533, 340);
            btnAltaLector.Name = "btnAltaLector";
            btnAltaLector.Size = new Size(75, 46);
            btnAltaLector.TabIndex = 9;
            btnAltaLector.Text = "ALTA LECTOR";
            btnAltaLector.UseVisualStyleBackColor = true;
            btnAltaLector.Click += btnAltaLector_Click;
            // 
            // FormAgregarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAltaLector);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtAutor);
            Controls.Add(txtEditorial);
            Controls.Add(txtTitulo);
            Name = "FormAgregarLibro";
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
        private Button btnCancelar;
        private Button btnAltaLector;
    }
}
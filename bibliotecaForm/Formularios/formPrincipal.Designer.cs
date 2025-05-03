using bibliotecaForm.Clases;
using bibliotecaForm.Formularios;

namespace bibliotecaForm.Formularios
{
    partial class formPrincipal
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
            btnListarLectores = new Button();
            btnListarLibros = new Button();
            btnAltaLector = new Button();
            listBox1 = new ListBox();
            lblTipoLista = new Label();
            btnVerPrestamos = new Button();
            btnPrestarLibro = new Button();
            SuspendLayout();
            // 
            // btnListarLectores
            // 
            btnListarLectores.Location = new Point(619, 107);
            btnListarLectores.Name = "btnListarLectores";
            btnListarLectores.Size = new Size(75, 46);
            btnListarLectores.TabIndex = 0;
            btnListarLectores.Text = "LISTAR LECTORES";
            btnListarLectores.UseVisualStyleBackColor = true;
            btnListarLectores.Click += btnListarLectores_Click;
            // 
            // btnListarLibros
            // 
            btnListarLibros.Location = new Point(619, 173);
            btnListarLibros.Name = "btnListarLibros";
            btnListarLibros.Size = new Size(75, 46);
            btnListarLibros.TabIndex = 2;
            btnListarLibros.Text = "LISTAR LIBROS";
            btnListarLibros.UseVisualStyleBackColor = true;
            btnListarLibros.Click += btnListarLibros_Click;
            // 
            // btnAltaLector
            // 
            btnAltaLector.Location = new Point(419, 294);
            btnAltaLector.Name = "btnAltaLector";
            btnAltaLector.Size = new Size(75, 46);
            btnAltaLector.TabIndex = 8;
            btnAltaLector.Text = "ALTA LECTOR";
            btnAltaLector.UseVisualStyleBackColor = true;
            btnAltaLector.Click += btnAltaLector_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(118, 107);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(469, 154);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblTipoLista
            // 
            lblTipoLista.AutoSize = true;
            lblTipoLista.Location = new Point(121, 82);
            lblTipoLista.Name = "lblTipoLista";
            lblTipoLista.Size = new Size(45, 15);
            lblTipoLista.TabIndex = 10;
            lblTipoLista.Text = "Listado";
            // 
            // btnVerPrestamos
            // 
            btnVerPrestamos.Location = new Point(619, 235);
            btnVerPrestamos.Name = "btnVerPrestamos";
            btnVerPrestamos.Size = new Size(75, 56);
            btnVerPrestamos.TabIndex = 11;
            btnVerPrestamos.Text = "VER LIBROS PRESTADOS";
            btnVerPrestamos.UseVisualStyleBackColor = true;
            btnVerPrestamos.Click += btnVerPrestamos_Click;
            // 
            // btnPrestarLibro
            // 
            btnPrestarLibro.Location = new Point(315, 294);
            btnPrestarLibro.Name = "btnPrestarLibro";
            btnPrestarLibro.Size = new Size(75, 46);
            btnPrestarLibro.TabIndex = 6;
            btnPrestarLibro.Text = "PRESTAR LIBRO";
            btnPrestarLibro.UseVisualStyleBackColor = true;
            btnPrestarLibro.Click += btnPrestarLibro_Click;
            // 
            // formPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 407);
            Controls.Add(btnVerPrestamos);
            Controls.Add(lblTipoLista);
            Controls.Add(listBox1);
            Controls.Add(btnAltaLector);
            Controls.Add(btnPrestarLibro);
            Controls.Add(btnListarLibros);
            Controls.Add(btnListarLectores);
            Name = "formPrincipal";
            Text = "formPrincipal";
            Load += formPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListarLectores;
        private Button btnListarLibros;
        private Button btnAltaLector;
        private ListBox listBox1;
        private Label lblTipoLista;
        private Button btnVerPrestamos;
        private Button btnPrestarLibro;
    }
}
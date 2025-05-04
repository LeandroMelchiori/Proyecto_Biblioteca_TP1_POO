using bibliotecaForm.Clases;
using bibliotecaForm.Formularios;

namespace bibliotecaForm.Formularios
{
    partial class FormListados
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
            listBox1 = new ListBox();
            lblTipoLista = new Label();
            btnVerPrestamos = new Button();
            SuspendLayout();
            // 
            // btnListarLectores
            // 
            btnListarLectores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnListarLectores.Location = new Point(362, 107);
            btnListarLectores.Name = "btnListarLectores";
            btnListarLectores.Size = new Size(119, 56);
            btnListarLectores.TabIndex = 0;
            btnListarLectores.Text = "LISTAR LECTORES";
            btnListarLectores.UseVisualStyleBackColor = true;
            btnListarLectores.Click += btnListarLectores_Click;
            // 
            // btnListarLibros
            // 
            btnListarLibros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnListarLibros.Location = new Point(362, 169);
            btnListarLibros.Name = "btnListarLibros";
            btnListarLibros.Size = new Size(119, 56);
            btnListarLibros.TabIndex = 2;
            btnListarLibros.Text = "LISTAR LIBROS";
            btnListarLibros.UseVisualStyleBackColor = true;
            btnListarLibros.Click += btnListarLibros_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(319, 349);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblTipoLista
            // 
            lblTipoLista.AutoSize = true;
            lblTipoLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoLista.Location = new Point(12, 6);
            lblTipoLista.Name = "lblTipoLista";
            lblTipoLista.Size = new Size(46, 15);
            lblTipoLista.TabIndex = 10;
            lblTipoLista.Text = "Listado";
            // 
            // btnVerPrestamos
            // 
            btnVerPrestamos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerPrestamos.Location = new Point(362, 231);
            btnVerPrestamos.Name = "btnVerPrestamos";
            btnVerPrestamos.Size = new Size(119, 56);
            btnVerPrestamos.TabIndex = 11;
            btnVerPrestamos.Text = "VER LIBROS PRESTADOS";
            btnVerPrestamos.UseVisualStyleBackColor = true;
            btnVerPrestamos.Click += btnVerPrestamos_Click;
            // 
            // FormListados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(513, 407);
            Controls.Add(btnVerPrestamos);
            Controls.Add(lblTipoLista);
            Controls.Add(listBox1);
            Controls.Add(btnListarLibros);
            Controls.Add(btnListarLectores);
            Name = "FormListados";
            Text = "formPrincipal";
            Load += formPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListarLectores;
        private Button btnListarLibros;
        private ListBox listBox1;
        private Label lblTipoLista;
        private Button btnVerPrestamos;
    }
}
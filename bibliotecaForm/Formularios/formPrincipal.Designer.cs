namespace bibliotecaForm.Formularios
{
    partial class FormPrincipal
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
            panelLateral = new Panel();
            btnAltaLector = new Button();
            btnIngresarLibro = new Button();
            btnPrestamos = new Button();
            btnListados = new Button();
            panelLateral2 = new Panel();
            panelContenedor = new Panel();
            panelLateral.SuspendLayout();
            SuspendLayout();
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.DimGray;
            panelLateral.Controls.Add(btnAltaLector);
            panelLateral.Controls.Add(btnIngresarLibro);
            panelLateral.Controls.Add(btnPrestamos);
            panelLateral.Controls.Add(btnListados);
            panelLateral.Controls.Add(panelLateral2);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(200, 603);
            panelLateral.TabIndex = 0;
            panelLateral.Paint += panelLateral_Paint;
            // 
            // btnAltaLector
            // 
            btnAltaLector.BackColor = Color.FromArgb(224, 224, 224);
            btnAltaLector.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 144, 226);
            btnAltaLector.FlatStyle = FlatStyle.Flat;
            btnAltaLector.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAltaLector.ForeColor = Color.FromArgb(28, 28, 28);
            btnAltaLector.Location = new Point(0, 481);
            btnAltaLector.Name = "btnAltaLector";
            btnAltaLector.Size = new Size(200, 75);
            btnAltaLector.TabIndex = 10;
            btnAltaLector.Text = "ALTA LECTOR";
            btnAltaLector.UseVisualStyleBackColor = false;
            btnAltaLector.Click += btnAltaLector_Click;
            // 
            // btnIngresarLibro
            // 
            btnIngresarLibro.AutoSize = true;
            btnIngresarLibro.BackColor = Color.FromArgb(224, 224, 224);
            btnIngresarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 144, 226);
            btnIngresarLibro.FlatStyle = FlatStyle.Flat;
            btnIngresarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIngresarLibro.ForeColor = Color.FromArgb(28, 28, 28);
            btnIngresarLibro.Location = new Point(0, 374);
            btnIngresarLibro.Name = "btnIngresarLibro";
            btnIngresarLibro.Size = new Size(200, 75);
            btnIngresarLibro.TabIndex = 3;
            btnIngresarLibro.Text = "INGRESAR LIBRO";
            btnIngresarLibro.UseVisualStyleBackColor = false;
            btnIngresarLibro.Click += btnAltaLibro_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.AutoSize = true;
            btnPrestamos.BackColor = Color.FromArgb(224, 224, 224);
            btnPrestamos.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 144, 226);
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrestamos.ForeColor = Color.FromArgb(28, 28, 28);
            btnPrestamos.Location = new Point(0, 263);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(200, 75);
            btnPrestamos.TabIndex = 2;
            btnPrestamos.Text = "PRESTAMOS";
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnListados
            // 
            btnListados.AutoSize = true;
            btnListados.BackColor = Color.FromArgb(224, 224, 224);
            btnListados.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 144, 226);
            btnListados.FlatStyle = FlatStyle.Flat;
            btnListados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnListados.ForeColor = Color.FromArgb(28, 28, 28);
            btnListados.Location = new Point(-3, 157);
            btnListados.Name = "btnListados";
            btnListados.Size = new Size(203, 75);
            btnListados.TabIndex = 1;
            btnListados.Text = "LISTADOS";
            btnListados.UseVisualStyleBackColor = false;
            btnListados.Click += btnListados_Click;
            // 
            // panelLateral2
            // 
            panelLateral2.BackColor = Color.Black;
            panelLateral2.Dock = DockStyle.Top;
            panelLateral2.Location = new Point(0, 0);
            panelLateral2.Name = "panelLateral2";
            panelLateral2.Size = new Size(200, 100);
            panelLateral2.TabIndex = 1;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(245, 246, 250);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(200, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1126, 603);
            panelContenedor.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1326, 603);
            Controls.Add(panelContenedor);
            Controls.Add(panelLateral);
            Name = "FormPrincipal";
            Text = "form1";
            Load += form1_Load_1;
            panelLateral.ResumeLayout(false);
            panelLateral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLateral;
        private Button btnListados;
        private Button btnPrestamos;
        private Button btnIngresarLibro;
        private Panel panelContenedor;
        private Button btnAltaLector;
        private Panel panelLateral2;
    }
}
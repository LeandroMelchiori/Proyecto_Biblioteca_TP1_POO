using bibliotecaForm.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotecaForm.Formularios
{
    public partial class FormAgregarLibro : Form
    {
        private Biblioteca biblioteca;
        public FormAgregarLibro(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string autor = txtAutor.Text.Trim();
            string editorial = txtEditorial.Text.Trim();

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor) || string.IsNullOrEmpty(editorial))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (txtTitulo.Text == "Titulo")
            {
                MessageBox.Show("El campo titulo no puede estar vacio");
                return;
            }

            if (txtAutor.Text == "Autor")
            {
                MessageBox.Show("El campo autor no puede estar vacio");
                return;
            }

            if (txtEditorial.Text == "Editorial")
            {
                MessageBox.Show("El campo editorial no puede estar vacio");
                return;
            }

            bool agregado = biblioteca.AgregarLibro(titulo, autor, editorial);

            if (agregado)
                MessageBox.Show("Libro agregado correctamente.");
            else
                MessageBox.Show("El libro ya existe en la biblioteca.");

            this.Close();
        }

        private void FormAgregarLibro_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnAgregar;
        }

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "Titulo")
            {
                txtTitulo.Text = "";
            }
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                txtTitulo.Text = "Titulo";
            }
        }

        private void txtAutor_Enter(object sender, EventArgs e)
        {
            if (txtAutor.Text == "Autor")
            {
                txtAutor.Text = "";
            }
        }

        private void txtAutor_Leave(object sender, EventArgs e)
        {
            if (txtAutor.Text == "")
            {
                txtAutor.Text = "Autor";
            }
        }

        private void txtEditorial_Enter(object sender, EventArgs e)
        {
            if (txtEditorial.Text == "Editorial")
            {
                txtEditorial.Text = "";
            }
        }

        private void txtEditorial_Leave(object sender, EventArgs e)
        {
            if (txtEditorial.Text == "")
            {
                txtEditorial.Text = "Editorial";
            }
        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

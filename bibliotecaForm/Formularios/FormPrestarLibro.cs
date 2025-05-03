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
    public partial class FormPrestarLibro : Form
    {
        private Biblioteca biblioteca;
        public FormPrestarLibro(Biblioteca biblioteca)
        {
            InitializeComponent();
            // cargamos la biblioteca
            this.biblioteca = biblioteca;

            // Carga las listas al iniciar formulario
            listLectores.Items.AddRange(biblioteca.ObtenerLectores().ToArray());
            listLibros.Items.AddRange(biblioteca.ObtenerLibros().ToArray());
        }

        private void FormPrestarLibro_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listLectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Llena los textbox con los datos del lector seleccionado
            if (listLectores.SelectedItem is Lector lector)
            {
                txtNombre.Text = lector.Nombre;
                txtDni.Text = lector.Dni;
                txtCantidadPrestamos.Text = lector.CantidadPrestamos().ToString();
            }
        }

        private void txtCantidadPrestamos_TextChanged(object sender, EventArgs e)
        {

        }

        private void listLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Llena los textbox con los datos del libro seleccionado
            if (listLibros.SelectedItem is Libro libro)
            {
                txtTitulo.Text = libro.Titulo;
                txtAutor.Text = libro.Autor;
                txtEditorial.Text = libro.Editorial;
            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string dni = txtDni.Text;

            string resultado = biblioteca.PrestarLibro(titulo, dni);
            MessageBox.Show(resultado, "Resultado del préstamo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualizar las Listas y limpiar las textbox
            listLibros.Items.Clear();
            listLibros.Items.AddRange(biblioteca.ObtenerLibros().ToArray());
            listLectores.Items.Clear();
            listLectores.Items.AddRange(biblioteca.ObtenerLectores().ToArray());

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Clear();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

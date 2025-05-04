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
    public partial class FormPrincipal : Form
    {
        private Biblioteca biblioteca = new Biblioteca();


        public FormPrincipal()
        {
            InitializeComponent();
            // Libros precargados
            biblioteca.AgregarLibro("El Principito", "Saint-Exupéry", "Sudamericana");
            biblioteca.AgregarLibro("Cien años de soledad", "García Márquez", "Sudamericana");
            biblioteca.AgregarLibro("Rayuela", "Cortázar", "Cátedra");
            biblioteca.AgregarLibro("IT", "Stephen King", "Planeta");
            biblioteca.AgregarLibro("1984", "George Orwell", "Debolsillo");
            biblioteca.AgregarLibro("Fahrenheit 451", "Ray Bradbury", "Minotauro");
            biblioteca.AgregarLibro("La sombra del viento", "Carlos Ruiz Zafón", "Planeta");

            // Lectores precargados
            biblioteca.AltaLector("Ana", "123");
            biblioteca.AltaLector("Bruno", "456");
            biblioteca.AltaLector("Rocio", "626");
            biblioteca.AltaLector("Hernan", "404");
            biblioteca.AltaLector("Mario", "420");
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private Form currentForm = null;
        private void openChildForm(Form childForm)
        {
            // Siempre limpia antes (aunque sea el primer click)
            panelContenedor.Controls.Clear();
            panelContenedor.BackgroundImage = null;

            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.AutoSize = true;
            childForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Agregar el formulario pero SIN fill
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;

            // Centrar manualmente
            childForm.Location = new Point(
                (panelContenedor.Width - childForm.Width) / 2,
                (panelContenedor.Height - childForm.Height) / 2
            );

            childForm.BringToFront();
            childForm.Show();

            // OPCIONAL: si el panel se redimensiona, seguir centrando
            panelContenedor.Resize += (s, e) =>
            {
                if (childForm != null)
                {
                    childForm.Location = new Point(
                        (panelContenedor.Width - childForm.Width) / 2,
                        (panelContenedor.Height - childForm.Height) / 2
                    );
                }
            };
        }

        private void btnListados_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListados(biblioteca));
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPrestamos(biblioteca));

        }

        private void btnAltaLibro_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAltaLibros(biblioteca));
        }

        private void btnAltaLector_Click(object sender, EventArgs e)
        {
            // input para nombre
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del lector:", "Alta de Lector", "");
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Nombre no puede ser nulo");
                return;
            }

            // input para dni
            string dni = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el DNI del lector:", "Alta de Lector", "");
            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("DNI no puede ser nulo");
                return;
            }


            // alta lector
            biblioteca.AltaLector(nombre, dni);
            MessageBox.Show("Lector registrado correctamente.", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

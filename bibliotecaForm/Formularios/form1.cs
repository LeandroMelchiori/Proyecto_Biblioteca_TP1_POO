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
    public partial class form1 : Form
    {
        private Biblioteca biblioteca = new Biblioteca();
        

        public form1()
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
            panelContenedor.BackColor = Color.White;

            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // Maneja el evento FormClosed del formulario hijo
            childForm.FormClosed += (s, args) =>
            {

                // Cuando el formulario hijo se cierre, restaurar la imagen de fondo



                // panelContenedor.BackColor = Color.Black; // O el color que desees
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new formPrincipal(biblioteca));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPrestarLibro(biblioteca));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAgregarLibro(biblioteca));
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}

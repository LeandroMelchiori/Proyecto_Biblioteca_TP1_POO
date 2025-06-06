﻿using bibliotecaForm.Clases;
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
    public partial class FormListados : Form
    {
        private Biblioteca biblioteca = new Biblioteca();
        public FormListados(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void btnListarLibros_Click(object sender, EventArgs e)
        {
            // 
            listBox1.Items.Clear();
            lblTipoLista.Text = "Lista de libros";
            foreach (var libro in biblioteca.ObtenerLibros())
            {
                listBox1.Items.Add(libro.ToString());
            }
        }

        private void btnListarLectores_Click(object sender, EventArgs e)
        {
            // muestra lista de lectores en el textbox
            listBox1.Items.Clear();
            lblTipoLista.Text = "Lista de lectores";
            foreach (var lector in biblioteca.ObtenerLectores())
            {
                listBox1.Items.Add(lector.ToString());
            }
        }

        private void btnPrestarLibro_Click(object sender, EventArgs e)
        {
            // Abre el formulario de prestamos
            FormPrestamos ventana = new FormPrestamos(biblioteca);
            ventana.ShowDialog(); // Abre formulario en modo Modal
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
            if (string.IsNullOrWhiteSpace(dni)) {
                MessageBox.Show("DNI no puede ser nulo");
                return;
            }
            

            // alta lector
            biblioteca.AltaLector(nombre, dni);
            MessageBox.Show("Lector registrado correctamente.", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualizacion del textbox
            lblTipoLista.Text = "Lista de lectores";
            listBox1.Items.Clear();
            listBox1.Items.AddRange(biblioteca.ObtenerLectores().ToArray());
            listBox1.Focus();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            FormAltaLibros ventana = new FormAltaLibros(biblioteca);
            ventana.ShowDialog(); // Abre formulario en modo Modal
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVerPrestamos_Click(object sender, EventArgs e)
        {
            // Muestra la lista de prestams en el listbox
            listBox1.Items.Clear();
            lblTipoLista.Text = "Lista de prestamos";
            foreach (var lector in biblioteca.ObtenerLectores())
            {
                // if no posee prestamos
                if (lector.CantidadPrestamos() == 0)
                {
                    listBox1.Items.Add($"{lector.Nombre} (DNI: {lector.Dni}): No posee ningún préstamo.");
                    listBox1.Items.Add(""); // Espacio entre lectores
                }

                // else posee prestamos
                else
                {
                    listBox1.Items.Add($"{lector.Nombre} (DNI: {lector.Dni}) tiene los siguientes libros:");
                    foreach (var libro in lector.ObtenerLibrosPrestados())
                    {
                        listBox1.Items.Add($"   - {libro.Titulo}");
                    }
                    listBox1.Items.Add(""); // Espacio entre lectores
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaForm.Clases
{
    public class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            libros = new List<Libro>();
            lectores = new List<Lector>();
        }

        private Lector BuscarLector(string dni)
        {
            foreach (var lector in lectores)
            {
                if (lector.Dni.Equals(dni))
                    return lector;
            }
            return null;
        }

        private Libro BuscarLibro(string titulo)
        {
            foreach (var libro in libros)
            {
                if (libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return libro;
                }
            }
            return null;
        }

        public void AltaLector(string nombre, string dni)
        {
            Lector lectorExistente = BuscarLector(dni);
            if (lectorExistente == null)
            {
                lectores.Add(new Lector(nombre, dni));
                Console.WriteLine($"Lector {nombre} dado de alta correctamente");
            }
            else
            {
                Console.WriteLine("El lector ya estaba registrado.");
            }
        }

        public bool AgregarLibro(string titulo, string autor, string editorial)
        {
            if (BuscarLibro(titulo) == null)
            {
                libros.Add(new Libro(titulo, autor, editorial));
                return true;
            }
            return false;
        }

        public string PrestarLibro(string titulo, string dni)
        {
            Libro libro = BuscarLibro(titulo);
            if (libro == null)
                return "LIBRO INEXISTENTE";

            Lector lector = BuscarLector(dni);
            if (lector == null)
                return "LECTOR INEXISTENTE";

            if (!lector.PuedePedir())
                return "TOPE DE PRESTAMO ALCANZADO";

            lector.AgregarPrestamo(libro);
            libros.Remove(libro);

            return "PRESTAMO EXITOSO";
        }

        public List<Libro> ObtenerLibros()
        {
            return new List<Libro>(libros); // Devuelve una copia para evitar modificaciones externas
        }

        public List<Lector> ObtenerLectores()
        {
            return new List<Lector>(lectores);
        }

    }

}

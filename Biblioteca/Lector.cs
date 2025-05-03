using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyectoBiblioteca
{
    internal class Lector
    {
        public string Nombre { get; set; }
        public string Dni { get; set; }
        private List<Libro> ejemplaresPrestados;

        public Lector(string nombre, string dni)
        {
            Nombre = nombre;
            Dni = dni;
            ejemplaresPrestados = new List<Libro>();
        }

        public int CantidadPrestamos()
        {
            return ejemplaresPrestados.Count;
        }

        public bool PuedePedir()
        {
            return ejemplaresPrestados.Count < 3;
        }

        public void AgregarPrestamo(Libro libro)
        {
            if (PuedePedir())
            {
                ejemplaresPrestados.Add(libro);
            }
        }

        public void ListarPrestamos()
        {
            Console.WriteLine($"Préstamos del lector {Nombre}:");
            foreach (var libro in ejemplaresPrestados)
            {
                Console.WriteLine(libro);
            }
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre}, DNI: {Dni}, Libros prestados: {ejemplaresPrestados.Count}";
        }
    }
}

using System;

namespace proyectoBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // Carga de libros
            biblioteca.AgregarLibro("El Principito", "Antoine de Saint-Exupéry", "Sudamericana");
            biblioteca.AgregarLibro("Cien años de soledad", "Gabriel García Márquez", "Sudamericana");
            biblioteca.AgregarLibro("Rayuela", "Julio Cortázar", "Ediciones Cátedra");
            biblioteca.AgregarLibro("IT", "Stephen King", "Ediciones Signet books");

            // Mostrar libros disponibles
            Console.WriteLine("\n--- LIBROS EN BIBLIOTECA ---");
            biblioteca.ListarLibros();

            // Alta de lectores
            Console.WriteLine("\n--- ALTA DE LECTORES ---");
            biblioteca.AltaLector("Ana", "123");
            biblioteca.AltaLector("Bruno", "456");

            // Prueba lector ya registrado
            Console.WriteLine("\n--- LECTOR YA REGISTRADO ---");
            biblioteca.AltaLector("Ana", "123");
            biblioteca.AltaLector("Bruno", "456");

            // Mostrar lectores registrados
            Console.WriteLine("\n--- LECTORES REGISTRADOS ---");
            biblioteca.ListarLectores();

            // Préstamos
            Console.WriteLine("\n--- PRÉSTAMOS ---");
            Console.WriteLine(biblioteca.PrestarLibro("Rayuela", "123")); // Éxito
            Console.WriteLine(biblioteca.PrestarLibro("Rayuela", "456")); // Libro inexistente - Ya prestado
            Console.WriteLine(biblioteca.PrestarLibro("Cien años de soledad", "999")); // Lector inexistente
            Console.WriteLine(biblioteca.PrestarLibro("Libro Ficticio", "123")); // Libro inexistente

            // Préstamos hasta llegar al tope
            Console.WriteLine("\n--- PRÉSTAMOS HASTA LLEGAR A TOPE ---");
            Console.WriteLine(biblioteca.PrestarLibro("El Principito", "123"));
            Console.WriteLine(biblioteca.PrestarLibro("Cien años de soledad", "123"));
            Console.WriteLine(biblioteca.PrestarLibro("IT", "123")); // Tope alcanzado

            // Mostrar lectores actualizados
            Console.WriteLine("\n--- ESTADO FINAL DE LECTORES ---");
            biblioteca.ListarLectores();
        }
    }
}

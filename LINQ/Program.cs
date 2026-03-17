using LINQ.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    /// <summary>
    /// RONALDO     16/06/2024
    /// ESTE PROGRAMA SIMULA UN SISTEMA DE BIBLIOTECA CON LIBROS Y PRÉSTAMOS, PERMITIENDO CONSULTAR Y FILTRAR INFORMACIÓN USANDO LINQ.
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = new List<Libro>
        {
            new Libro(1, "Cien años de soledad", "Gabriel García Márquez", 1967, false),
            new Libro(2, "1984", "George Orwell", 1949, true),
            new Libro(3, "El Principito", "Antoine de Saint-Exupéry", 1943, false),
            new Libro(4, "Don Quijote", "Miguel de Cervantes", 1605, true),
            new Libro(5, "Rayuela", "Julio Cortázar", 1963, false),
            new Libro(6, "Fundación", "Isaac Asimov", 1951, true)
        };

            List<Prestamo> prestamos = new List<Prestamo>
        {
            new Prestamo(101, 1, "Juan Pérez", DateTime.Now.AddDays(-10)),
            new Prestamo(102, 3, "Ana López", DateTime.Now.AddDays(-5)),
            new Prestamo(103, 5, "Carlos Ruiz", DateTime.Now.AddDays(-2)),
           
            new Prestamo(104, 2, "María García", DateTime.Now.AddDays(-20)) { FechaDevolucion = DateTime.Now.AddDays(-15) },
            new Prestamo(105, 4, "Pedro Marmol", DateTime.Now.AddDays(-30)) { FechaDevolucion = DateTime.Now.AddDays(-25) }
        };

            int opcion;
            do
            {
                Console.WriteLine("\n=== SISTEMA DE BIBLIOTECA ===");
                Console.WriteLine("1. Ver todos los libros");
                Console.WriteLine("2. Ver libros disponibles");
                Console.WriteLine("3. Ver libros prestados");
                Console.WriteLine("4. Ver todos los préstamos");
                Console.WriteLine("5. Ver préstamos activos");
                Console.WriteLine("6. Buscar libros por título");
                Console.WriteLine("7. Buscar libros por autor");
                Console.WriteLine("8. Buscar préstamos por usuario");
                Console.WriteLine("9. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

                switch (opcion)
                {
                    case 1:
                        libros.ForEach(l => l.MostrarInfo());
                        break;
                    case 2:
                        var disponibles = libros.Where(l => l.Disponible);
                        foreach (var l in disponibles) l.MostrarInfo();
                        break;
                    case 3:
                        var prestados = libros.Where(l => !l.Disponible);
                        foreach (var l in prestados) l.MostrarInfo();
                        break;
                    case 4:
                        prestamos.ForEach(p => p.MostrarInfo());
                        break;
                    case 5:
                        var activos = prestamos.Where(p => p.FechaDevolucion == null);
                        foreach (var p in activos) p.MostrarInfo();
                        break;
                    case 6:
                        Console.Write("Ingrese título a buscar: ");
                        string busquedaT = Console.ReadLine().ToLower();
                        var xTitulo = libros.Where(l => l.Titulo.ToLower().Contains(busquedaT));
                        foreach (var l in xTitulo) l.MostrarInfo();
                        break;
                    case 7:
                        Console.Write("Ingrese autor a buscar: ");
                        string busquedaA = Console.ReadLine().ToLower();
                        var xAutor = libros.Where(l => l.Autor.ToLower().Contains(busquedaA));
                        foreach (var l in xAutor) l.MostrarInfo();
                        break;
                    case 8:
                        Console.Write("Nombre del usuario: ");
                        string user = Console.ReadLine().ToLower();
                        var xUser = prestamos.Where(p => p.NombreUsuario.ToLower().Contains(user));
                        foreach (var p in xUser) p.MostrarInfo();
                        break;
                }
            } while (opcion != 9);
        }
    }
}
    


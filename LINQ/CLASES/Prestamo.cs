using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.CLASES
{
    public class Prestamo
    {
    public int Id { get; set; }
    public int IdLibro { get; set; }
    public string NombreUsuario { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime? FechaDevolucion { get; set; }

    public Prestamo(int id, int idLibro, string usuario, DateTime fechaP)
    {
        Id = id;
        IdLibro = idLibro;
        NombreUsuario = usuario;
        FechaPrestamo = fechaP;
        FechaDevolucion = null;
    }

    public void MostrarInfo() => 
        Console.WriteLine($"ID Préstamo: {Id} | Libro ID: {IdLibro} | Usuario: {NombreUsuario} | Fecha: {FechaPrestamo.ToShortDateString()} | Estado: {(FechaDevolucion == null ? "ACTIVO" : "Devuelto")}");
    }
}

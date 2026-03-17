using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.CLASES
{
    /// <summary>
    /// RONALDO    16/06/2024
    /// ESTA CLASE REPRESENTA UN PRÉSTAMO EN EL SISTEMA DE BIBLIOTECA, CONTENIENDO PROPIEDADES COMO ID, ID DEL LIBRO PRESTADO, NOMBRE DEL USUARIO, FECHA DE PRÉSTAMO Y FECHA DE DEVOLUCIÓN. INCLUYE UN MÉTODO PARA MOSTRAR LA INFORMACIÓN DEL PRÉSTAMO DE MANERA FORMATEADA, INDICANDO SI EL PRÉSTAMO ESTÁ ACTIVO O HA SIDO DEVUELTO.
    /// </summary>
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

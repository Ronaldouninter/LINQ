using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.CLASES
{
    /// <summary>
    /// RONALDO     16/06/2024
    /// ESTA CLASE REPRESENTA UN LIBRO EN EL SISTEMA DE BIBLIOTECA, CONTENIENDO PROPIEDADES COMO ID, TÍTULO, AUTOR, AÑO DE PUBLICACIÓN Y DISPONIBILIDAD. INCLUYE UN MÉTODO PARA MOSTRAR LA INFORMACIÓN DEL LIBRO DE MANERA FORMATEADA.
    /// </summary>
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }
        public bool Disponible { get; set; }

        public Libro(int id, string titulo, string autor, int anio, bool disponible)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anio;
            Disponible = disponible;
        }

        public void MostrarInfo() =>
            Console.WriteLine($"[{Id}] {Titulo} - {Autor} ({AnioPublicacion}) | {(Disponible ? "Disponible" : "Prestado")}");
    }
}

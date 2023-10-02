using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace MergePractice.Data.Entities
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        public string? Nombre_Producto { get; set; }

        public int Cantidad { get; set; }

        public string? Tipo_Producto { get; set; }

        public string? Marca { get; set; }

        public decimal Precio_Unitario { get; set; }
    }
}

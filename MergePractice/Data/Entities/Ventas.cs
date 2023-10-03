namespace MergePractice.Data.Entities
{
    public class Ventas
    {
        public int Id { get; set; }

        public int UsuarioId {  get; set; }

        public string? TipoComprobante { get; set; }

        public string? SerieComprobante { get; set; }

        public string? NumeroComprobante { get; set; }

        public DateTime Fecha {  get; set; }

        public decimal Impuesto { get; set; }

        public decimal Total { get; set; }

        public string? Estado { get; set; }
    }
}

using MergePractice.Context;
using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;

namespace MergePractice.Data.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly PoSContext context;

        public ProductoRepository(PoSContext context)
        {
            this.context = context;
        }
        public void Agregar(Producto producto)
        {
            this.context.Producto.Add(producto);
            this.context.SaveChanges();
        }

        public List<Producto> List()
        {
            return this.context.Producto.ToList();
        }

        public void Modificar(Producto producto)
        {
            this.context.Producto.Update(producto);
            this.context.SaveChanges();
        }

        public Producto ObtenerId(int id)
        {
            return this.context.Producto.Find(id);
        }

        public void Remover(int ProductoId)
        {
            var producto = this.context.Producto.First(cd => cd.IdProducto == ProductoId);
            this.context.Producto.Remove(producto);
            this.context.SaveChanges();
        }
    }
}

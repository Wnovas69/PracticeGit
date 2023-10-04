using MergePractice.Context;
using MergePractice.Data.Base;
using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;

namespace MergePractice.Data.Repository
{
    public class ProductoRepository : BaseRepository<Producto>, IProductoRepository
    {
        private readonly PoSContext context;

        public ProductoRepository(PoSContext context) : base(context) 
        {
            this.context = context;
        }

        public override void Agregar(Producto entity)
        {
            base.Agregar(entity);
            this.context.SaveChanges();
        }



        public override void Modificar(Producto entity)
        {
            base.Modificar(entity);
            this.context.SaveChanges();
        }

        public override void Remover(int Id)
        {
            base.Remover(Id);
            this.context.SaveChanges();
        }
    }
}

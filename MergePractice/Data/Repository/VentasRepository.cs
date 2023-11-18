using MergePractice.Context;
using MergePractice.Data.Base;
using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;

namespace MergePractice.Data.Repository
{
    public class VentasRepository : BaseRepository<Ventas>, IVentasRepository
    {
        private readonly PoSContext context;

        public VentasRepository(PoSContext context) : base(context) 
        {
            this.context = context;
        }

        public override void Agregar(Ventas entity)
        {
            base.Agregar(entity);
            this.context.SaveChanges();
        }

        public override void Modificar(Ventas entity)
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

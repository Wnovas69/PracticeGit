using MergePractice.Context;
using MergePractice.Data.Base;
using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MergePractice.Data.Repository
{
    public class SuplidorRepository : BaseRepository<Suplidor>, ISuplidorRepository
    {
        private readonly PoSContext _context;

        public SuplidorRepository(PoSContext context) : base(context)
        {
            _context = context;
        }

        public override List<Suplidor> List()
        {
            return base.List();
        }

        public override void Agregar(Suplidor entity)
        {
            base.Agregar(entity);
        }

        public override void Modificar(Suplidor entity)
        {
            base.Modificar(entity);
        }

        public override void Remover(int Id)
        {
            base.Remover(Id);
        }

        public override Suplidor ObtenerId(int id)
        {
            return base.ObtenerId(id);
        }
    }
}

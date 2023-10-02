using MergePractice.Context;
using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;

namespace MergePractice.Data.Repository
{
    public class SuplidorRepository : ISuplidorRepository
    {
        private readonly PoSContext _context;

        public SuplidorRepository(PoSContext context)
        {
            _context = context;
        }

        public void Agregar(Suplidor suplidor)
        {
            _context.Suplidor.Add(suplidor);
            _context.SaveChanges();
        }

        public List<Suplidor> List()
        {
            return _context.Suplidor.ToList();
        }

        public void Modificar(Suplidor suplidor)
        {
            _context.Suplidor.Update(suplidor);
            _context.SaveChanges();
        }

        public Suplidor ObtenerId(int id)
        {
            var suplidor = _context.Suplidor.Find(id);
            return suplidor;
        }

        public void Remover(int usuarioId)
        {
            var suplidor = this.ObtenerId(usuarioId);
            _context.Suplidor.Remove(suplidor);
            _context.SaveChanges();
        }
    }
}

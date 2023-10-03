using MergePractice.Context;
using MergePractice.Data.Base;
using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;

namespace MergePractice.Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly PoSContext context;

        public UsuarioRepository(PoSContext context) : base(context)
        {
            this.context = context;
        }

        public override List<Usuario> List()
        {
            return base.List();
        }
        public override void Agregar(Usuario entity)
        {
            base.Agregar(entity);
        }
        public override void Modificar(Usuario entity)
        {
            base.Modificar(entity);
        }
        public override Usuario ObtenerId(int id)
        {
            return base.ObtenerId(id);
        }
        public override void Remover(int Id)
        {
            base.Remover(Id);
        }
    }
}

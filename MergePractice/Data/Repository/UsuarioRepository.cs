using MergePractice.Context;
using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;

namespace MergePractice.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PoSContext context;

        public UsuarioRepository(PoSContext context) 
        {
            this.context = context;
        }
        public void Agregar(Usuario usuario)
        {
            this.context.Usuario.Add(usuario);
            this.context.SaveChanges();
        }

        public List<Usuario> List()
        {
            return this.context.Usuario.ToList();
        }

        public void Modificar(Usuario usuario)
        {
            this.context.Usuario.Update(usuario);
            this.context.SaveChanges();
        }

        public Usuario ObtenerId(int id)
        {
            return this.context.Usuario.Find(id);
        }

        public void Remover(int UsuarioId)
        {
            var usuario = this.context.Usuario.First(cd => cd.Id == UsuarioId);
            this.context.Usuario.Remove(usuario);
            this.context.SaveChanges();
        }
    }
}

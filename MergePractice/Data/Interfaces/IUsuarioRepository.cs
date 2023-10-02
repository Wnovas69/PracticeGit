using MergePractice.Data.Entities;

namespace MergePractice.Data.Interfaces
{
    public interface IUsuarioRepository
    {

        void Agregar(Usuario usuario);

        void Modificar (Usuario usuario);

        List<Usuario> List();

        Usuario ObtenerId(int id);

        void Remover(int UsuarioId);
    }
}

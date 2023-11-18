using MergePractice.Data.Entities;

namespace MergePractice.Data.Base
{
<<<<<<< HEAD
    public interface IBaseRepository<TEntity > where TEntity : class
=======
    public interface IBaseRepository<TEntity> where TEntity : class
>>>>>>> origin/main
    {
        void Agregar(TEntity entity);

        void Modificar(TEntity entity);

        List<TEntity> List();

        TEntity ObtenerId(int id);

<<<<<<< HEAD
        void Remover(int Id);

=======
        void Remover(int usuarioId);
>>>>>>> origin/main
    }
}

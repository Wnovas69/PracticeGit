using MergePractice.Data.Entities;

namespace MergePractice.Data.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Agregar(TEntity entity);

        void Modificar(TEntity entity);

        List<TEntity> List();

        TEntity ObtenerId(int id);

        void Remover(int usuarioId);
    }
}

using MergePractice.Data.Entities;

namespace MergePractice.Data.Interfaces
{
    public interface ISuplidorRepository
    {
        void Agregar(Suplidor suplidor);

        void Modificar(Suplidor suplidor);

        List<Suplidor> List();

        Suplidor ObtenerId(int id);

        void Remover(int usuarioId);
    }
}

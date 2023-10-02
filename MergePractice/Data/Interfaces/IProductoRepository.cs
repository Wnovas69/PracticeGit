using MergePractice.Data.Entities;

namespace MergePractice.Data.Interfaces
{
    public interface IProductoRepository
    {

        void Agregar(Producto producto);

        void Modificar(Producto producto);

        List<Producto> List();

        Producto ObtenerId(int id);

        void Remover(int ProductoId);
    }
}

using MergePractice.Data.Entities;

namespace MergePractice.Data.Interfaces
{
    public interface IVentasRepository
    {

        void Agregar(Ventas ventas);

        void Modificar(Ventas ventas);

        List<Ventas> List();

        Ventas ObtenerPorId(int id);

        void Remover(int VentasId);
    }
}

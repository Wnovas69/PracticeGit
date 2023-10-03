using MergePractice.Context;
using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;

namespace MergePractice.Data.Repository
{
    public class VentasRepository : IVentasRepository
    {
        private readonly PoSContext context;

        public VentasRepository(PoSContext context)
        {
            this.context = context;
        }
        public void Agregar(Ventas ventas)
        {
           this.context.Ventas.Add(ventas);
           this.context.SaveChanges();
        }

        public List<Ventas> List()
        {
            return this.context.Ventas.ToList();    
        }

        public void Modificar(Ventas ventas)
        {
            this.context.Update(ventas);
            this.context.SaveChanges();
        }

        public Ventas ObtenerPorId(int id)
        {
            return this.context.Ventas.Find(id);
        }

        public void Remover(int VentasId)
        {
            var ventas = this.context.Ventas.First(cd  => cd.Id == VentasId);
            this.context.Remove(ventas);
            this.context.SaveChanges();
        }
    }
}

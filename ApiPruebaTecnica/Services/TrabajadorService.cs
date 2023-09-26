using ApiPruebaTecnica.Contexto;
using ApiPruebaTecnica.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ApiPruebaTecnica.Services
{
    public class TrabajadorService : ITrabajadorService
    {
        private readonly ApiDbContext _context;

        public TrabajadorService(ApiDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Trabajador>> ObtenerListadoTrabajadoresAsync()
        {
            return await _context.Trabajadores.ToListAsync();
        }

        public async Task<List<Trabajador>?> GuardarListadoTrabajadoresAsync(List<Trabajador> listadoTrabajadores)
        {
            try
            {
                foreach (var item in listadoTrabajadores)
                {
                    item.Nombre = item.Nombre.ToUpper();
                    item.Apellido = item.Apellido.ToUpper();
                }
                await _context.AddRangeAsync(listadoTrabajadores);
                await _context.SaveChangesAsync();

                return listadoTrabajadores;
            }
            catch(Exception)
            {
                return null;
                throw;
            }
        }
    }
}

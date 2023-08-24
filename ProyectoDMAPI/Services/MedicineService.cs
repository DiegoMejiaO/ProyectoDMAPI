using ProyectoDMAPI.Data;
using ProyectoDMAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProyectoDMAPI.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly ProyectoDMAPIDbContext _context;
        public MedicineService(ProyectoDMAPIDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<long>> PostCrearMedicineAsync(Medicine medicine)
        {
            if (_context.Medicines == null)
            {
                return null;
            }

            _context.Medicines.Add(medicine);
            var _tipoMedicamento = await _context.SaveChangesAsync();

            return _tipoMedicamento;
        }

        public async Task<ActionResult<IEnumerable<Medicine>>> PostObtenerMedicineAsync()
        {
            if (_context.Medicines == null)
            {
                return null;
            }

            var drogas = await _context.Medicines.ToListAsync();

            return drogas;
        }
    }
}

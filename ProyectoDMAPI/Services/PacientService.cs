using ProyectoDMAPI.Data;
using ProyectoDMAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProyectoDMAPI.Services
{
    public class PacientService : IPacientService
    {
        private readonly ProyectoDMAPIDbContext _context;
        public PacientService(ProyectoDMAPIDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<long>> PostCrearPacientAsync(Pacient pacient)
        {
            if (_context.Pacients == null)
            {
                return null;
            }

            _context.Pacients.Add(pacient);
            var _tipoMedicamento = await _context.SaveChangesAsync();

            return _tipoMedicamento;
        }

        public async Task<ActionResult<IEnumerable<Pacient>>> PostObtenerPacientAsync()
        {
            if (_context.Pacients == null)
            {
                return null;
            }

            var pacientes = await _context.Pacients.ToListAsync();

            return pacientes;
        }
    }
}

using ProyectoDMAPI.Data;
using ProyectoDMAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProyectoDMAPI.Services
{
    public class InfPacientService : IInfPacientService
    {
        private readonly ProyectoDMAPIDbContext _context;

        public InfPacientService(ProyectoDMAPIDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<long>> PostCrearInfPacientAsync(Pacient pacient)
        {
            if (_context.Pacients == null)
            {
                return null;
            }

            _context.Pacients.Add(pacient);
            var _schedule = await _context.SaveChangesAsync();

            return _schedule;
        }

        public async Task<ActionResult<IEnumerable<Pacient>>> PostObtenerInfPacientAsync()
        {
            if (_context.Pacients == null)
            {
                return null;
            }

            var schedules = await _context.Pacients.Select(x => x).ToListAsync();

            return schedules;
        }
    }
}

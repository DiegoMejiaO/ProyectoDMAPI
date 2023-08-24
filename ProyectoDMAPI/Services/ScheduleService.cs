using ProyectoDMAPI.Data;
using ProyectoDMAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoDMAPI.Data.Dto;
using Microsoft.Data.SqlClient;
using System.Linq;
using Microsoft.Identity.Client.Extensions.Msal;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProyectoDMAPI.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly ProyectoDMAPIDbContext _context;

        public ScheduleService(ProyectoDMAPIDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<long>> PostCrearScheduleAsync(Medicine medicine)
        {
            if (_context.Medicines == null)
            {
                return null;
            }

            _context.Medicines.Add(medicine);
            var _schedule = await _context.SaveChangesAsync();

            return _schedule;
        }

        public async Task<ActionResult<IEnumerable<Medicine>>> PostObtenerScheduleAsync()
        {
            if (_context.Medicines == null)
            {
                return null;
            }

            var schedules = await _context.Medicines.Select(x => x).ToListAsync();

            //List<Medicine> ListaSchedule = schedules.Select(u => new Medicine()
            //{
            //    Date = u.Date,
            //    Name = u.Name,
            //    Quantity = u.Quantity,
            //    Day = u.Day,
            //    Hour = u.Hour,
            //    Frecuency = u.Frecuency
            //}).ToList();

            return schedules;
        }
    }
}

using ProyectoDMAPI.Data.Models;
using ProyectoDMAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using Microsoft.EntityFrameworkCore;
using ProyectoDMAPI.Data;

namespace ProyectoDMAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class MedicineController : ControllerBase
    {
        private readonly IMedicineService _medicineService;
        private readonly ProyectoDMAPIDbContext _context;

        public MedicineController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        public MedicineController(ProyectoDMAPIDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medicine>>> GetMedicine()
        {
            if (_context.Medicines == null)
            {
                return NotFound();
            }
            return await _context.Medicines.ToListAsync();
        }

        [HttpPost]
        [Route("PostObtenerMedicine")]
        public async Task<ActionResult<IEnumerable<Medicine>>> PostObtenerMedicine()
        {
            var tipoMedicina = await _medicineService.PostObtenerMedicineAsync();

            if (tipoMedicina == null)
            {
                return NotFound();
            }

            return Ok(tipoMedicina);
        }

        [HttpPost]
        [Route("PostCrearMedicine")]
        public async Task<ActionResult> PostCrearMedicine(Medicine medicine)
        {
            if (medicine == null)
            {
                return Problem("Entity set 'Inconsistencias Api' is null.");
            }

            var _medicamento = await _medicineService.PostCrearMedicineAsync(medicine);

            if (_medicamento == null)
            {
                return NotFound();
            }

            return Ok(_medicamento);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicine(long id, Medicine medicine)
        {
            if (id != medicine.Id)
            {
                return BadRequest();
            }

            _context.Entry(medicine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicineExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicine(long id)
        {
            if (_context.Medicines == null)
            {
                return NotFound();
            }
            var medicamento = await _context.Medicines.FindAsync(id);
            if (medicamento == null)
            {
                return NotFound();
            }

            _context.Medicines.Remove(medicamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedicineExists(long id)
        {
            return (_context.Medicines?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

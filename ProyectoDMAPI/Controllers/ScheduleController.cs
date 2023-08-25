using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoDMAPI.Data.Models;
using ProyectoDMAPI.Services;

namespace ProyectoDMAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IMedicineService _medicineService;
        public ScheduleController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        [HttpPost]
        [Route("PostObtenerSchedule")]
        public async Task<ActionResult<IEnumerable<Medicine>>> PostObtenerSchedule()
        {

            var calendario = await _medicineService.PostObtenerMedicineAsync();

            if (calendario == null)
            {
                return NotFound();
            }
            return calendario;
        }

        [HttpPost]
        [Route("PostCrearSchedule")]
        public async Task<ActionResult> PostCrearSchedule(Medicine medicine)
        {

            if (medicine == null)
            {
                return Problem("Entity set 'ApiScheduleDBContext'  is null.");
            }

            var _schedule = await _medicineService.PostCrearMedicineAsync(medicine);

            if (_schedule == null)
            {
                return Problem("Error creando la nueva Schedule");
            }
            return Ok();
        }

    }
}

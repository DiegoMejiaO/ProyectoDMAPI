using ProyectoDMAPI.Data.Models;
using ProyectoDMAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ProyectoDMAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class MedicineController : ControllerBase
    {
        private readonly IMedicineService _medicineService;

        public MedicineController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
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
    }
}

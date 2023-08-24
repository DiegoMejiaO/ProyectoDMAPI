using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoDMAPI.Data.Models;
using ProyectoDMAPI.Services;

namespace ProyectoDMAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PacientController : ControllerBase
    {
        private readonly IPacientService _pacientService;

        public PacientController(IPacientService pacientService)
        {
            _pacientService = pacientService;
        }

        [HttpPost]
        [Route("PostObtenerPacient")]
        public async Task<ActionResult<IEnumerable<Pacient>>> PostObtenerPacient()
        {
            var tipoPaciente = await _pacientService.PostObtenerPacientAsync();

            if (tipoPaciente == null)
            {
                return NotFound();
            }

            return Ok(tipoPaciente);
        }

        [HttpPost]
        [Route("PostCrearPacient")]
        public async Task<ActionResult> PostCrearPacient(Pacient pacient)
        {
            if (pacient == null)
            {
                return Problem("Entity set 'Inconsistencias Api Pacient' is null.");
            }

            var _paciente = await _pacientService.PostCrearPacientAsync(pacient);

            if (_paciente == null)
            {
                return NotFound();
            }

            return Ok(_paciente);
        }
    }
}

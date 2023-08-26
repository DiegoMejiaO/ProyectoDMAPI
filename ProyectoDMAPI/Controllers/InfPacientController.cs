using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoDMAPI.Data.Models;
using ProyectoDMAPI.Services;

namespace ProyectoDMAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InfPacientController : Controller
    {
        private readonly IPacientService _pacientService;
        public InfPacientController(IPacientService pacientService)
        {
            _pacientService = pacientService;
        }

        [HttpPost]
        [Route("PostObtenerInfPacient")]
        public async Task<ActionResult<IEnumerable<Pacient>>> PostObtenerInfPacient()
        {

            var Info = await _pacientService.PostObtenerPacientAsync();

            if (Info == null)
            {
                return NotFound();
            }
            return Info;
        }

        [HttpPost]
        [Route("PostCrearInfPacient")]
        public async Task<ActionResult> PostCrearInfpacient(Pacient pacient)
        {

            if (pacient == null)
            {
                return Problem("Entity set 'ApiInfPacientDBContext'  is null.");
            }

            var _info = await _pacientService.PostCrearPacientAsync(pacient);

            if (_info == null)
            {
                return Problem("Error creando la nueva InfoPacient");
            }
            return Ok();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using ProyectoDMAPI.Data.Models;

namespace ProyectoDMAPI.Services
{
    public interface IInfPacientService
    {
        Task<ActionResult<IEnumerable<Pacient>>> PostObtenerInfPacientAsync();
        Task<ActionResult<Int64>> PostCrearInfPacientAsync(Pacient pacient);
    }
}

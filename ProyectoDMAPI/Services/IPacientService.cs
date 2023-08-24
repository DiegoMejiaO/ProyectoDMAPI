using Microsoft.AspNetCore.Mvc;
using ProyectoDMAPI.Data.Models;

namespace ProyectoDMAPI.Services
{
    public interface IPacientService
    {
        Task<ActionResult<IEnumerable<Pacient>>> PostObtenerPacientAsync();
        Task<ActionResult<Int64>> PostCrearPacientAsync(Pacient pacient);
    }
}

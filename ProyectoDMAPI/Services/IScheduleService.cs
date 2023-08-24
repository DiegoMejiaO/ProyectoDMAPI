using ProyectoDMAPI.Data.Dto;
using ProyectoDMAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client.Extensions.Msal;

namespace ProyectoDMAPI.Services
{
    public interface IScheduleService
    {
        Task<ActionResult<IEnumerable<Medicine>>> PostObtenerScheduleAsync();
        Task<ActionResult<Int64>> PostCrearScheduleAsync(Medicine medicine);
    }
}

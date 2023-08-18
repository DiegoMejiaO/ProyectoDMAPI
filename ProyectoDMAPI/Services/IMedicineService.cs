using Microsoft.AspNetCore.Mvc;
using ProyectoDMAPI.Data.Models;

namespace ProyectoDMAPI.Services
{
    public interface IMedicineService
    {
        Task<ActionResult<IEnumerable<Medicine>>> PostObtenerMedicineAsync();
        Task<ActionResult<Int64>> PostCrearMedicineAsync(Medicine medicine);
    }
}

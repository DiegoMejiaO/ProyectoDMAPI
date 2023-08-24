using ProyectoDMAPI.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDMAPI.Data.Dto
{
    public class ScheduleDto
    {
        public long IdSchedule { get; set; }       
        public DateTime ScheduleDate { get; set; }        
        public string ScheduleName { get; set; }       
        public int ScheduleQuantity { get; set; }        
        public string ScheduleDay { get; set; }        
        public string ScheduleHour { get; set; }        
        public int ScheduleFrecuency { get; set; }       
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoDMAPI.Data.Models
{
    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required]
        public long IdSchedule { get; set; }
        [Required]
        public DateTime ScheduleDate { get; set; }
        [Required]
        public string ScheduleName { get; set; }
        [Required]
        public int ScheduleQuantity { get; set; }
        [Required]
        public string ScheduleDay { get; set; }
        [Required]
        public string ScheduleHour { get; set; }
        [Required]
        public int ScheduleFrecuency { get; set; }        
    }
}

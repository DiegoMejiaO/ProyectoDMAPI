using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoDMAPI.Data.Models
{
    public class Pacient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string PacientIdentification { get; set; }
        public string PacientName { get; set; }
        public int PacientdAge { get; set; }
        public string PacientSex { get; set; }
        public float PacientHeight { get; set; }
        public int PacientWeight { get; set; }
    }
}

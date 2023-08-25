using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoDMAPI.Data.Models
{
    public class InfPacient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required]
        public long Id { get; set; }
        [Required]
        public string InfPacientIdentification { get; set; }
        [Required]
        public string InfPacientName { get; set; }
        [Required]
        public int InfPacientdAge { get; set; }
        [Required]
        public string InfPacientSex { get; set; }
        [Required]
        public float InfPacientHeight { get; set; }
        [Required]
        public int InfPacientWeight { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoDMAPI.Data.Models
{
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Day { get; set; } = string.Empty;
        public string Hour { get; set; } = string.Empty;
    }
}

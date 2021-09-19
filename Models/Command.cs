using System.ComponentModel.DataAnnotations;

namespace CVPorject1.Models
{
    public class Command
    {
        [Key]
        public int CommandId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string CommandName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string CommandDescription { get; set; }

        public Platform Platform { get; set; }
        public int PlatformId { get; set; }
    }
}
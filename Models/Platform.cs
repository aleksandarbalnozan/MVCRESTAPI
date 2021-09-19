using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CVPorject1.Models
{
    public class Platform
    {
        [Key]
        public int PlatformId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }

        public ICollection<Command> Commands { get; set; }
    }
}
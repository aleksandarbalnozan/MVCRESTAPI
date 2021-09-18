using System.Collections.Generic;

namespace CVPorject1.Models
{
    public class Platform
    {
        public int PlatformId { get; set; }
        public string Name { get; set; }

        public ICollection<Command> Commands { get; set; }
    }
}
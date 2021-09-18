namespace CVPorject1.Models
{
    public class Command
    {
        public int CommandId    { get; set; }
        public string HowTO { get; set; }
        public string Line { get; set; }

        public Platform Platform { get; set; }
        public int PlatformId { get; set; } 
    }
}
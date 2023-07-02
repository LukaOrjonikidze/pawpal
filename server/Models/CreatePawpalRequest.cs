namespace server.Models
{
    public class CreatePawpalRequest
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string Gender { get; set; }
    }
}

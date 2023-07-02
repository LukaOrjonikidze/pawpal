namespace server.Models
{
    public class AddPawbondPostRequest
    {
        public int AuthorId { get; set; }
        public string WantedPartnerBreed { get; set; }
        public int WantedPartnerAge { get; set; }
        public string WanterPartnerDescription { get; set; }
    }
}

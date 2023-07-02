namespace server.Models
{
    public class PawbondPost
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public Pawpal Author { get; set; }
        public string WantedPartnerBreed { get; set; }
        public int WantedPartnerAge { get; set; }
        public string WanterPartnerDescription { get; set; }
    }
}

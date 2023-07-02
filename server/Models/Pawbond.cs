using server.Enums;

namespace server.Models
{
    public class Pawbond
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int PartnerId { get; set; }
        public StatusType Status { get; set; }

        public Pawpal Author { get; set; }
        public Pawpal Partner { get; set; }

    }
}

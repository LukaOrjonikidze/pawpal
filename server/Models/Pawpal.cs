﻿namespace server.Models
{
    public class Pawpal
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string Gender { get; set; }

        public ICollection<Pawbond> Pawbonds { get; set; }
        public ICollection<PawbondPost> PawbondPosts { get; set; }
    }
}

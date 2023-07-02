using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Interfaces;
using server.Models;

namespace server.Implementations
{
    public class PawbondPostsService : IPawbondPostsService
    {
        private readonly PawpalDbContext _dbContext;
        public PawbondPostsService(PawpalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PawbondPost> AddPawbondPost(AddPawbondPostRequest addPawbondPostRequest)
        {
            Pawpal author = await _dbContext.Pawpals.FindAsync(addPawbondPostRequest.AuthorId);
            PawbondPost pawbondPost = new PawbondPost()
            {
                AuthorId = addPawbondPostRequest.AuthorId,
                Author = author,
                WantedPartnerBreed = addPawbondPostRequest.WantedPartnerBreed,
                WantedPartnerAge = addPawbondPostRequest.WantedPartnerAge,
                WanterPartnerDescription = addPawbondPostRequest.WanterPartnerDescription
            };
            await _dbContext.PawbondPosts.AddAsync(pawbondPost);
            await _dbContext.SaveChangesAsync();
            return pawbondPost;
        }

        public async Task<PawbondPost?> DeletePawbondPost(int id)
        {
            PawbondPost? pawbondPost = await _dbContext.PawbondPosts.FindAsync(id);
            if (pawbondPost == null)
            {
                return null;
            }
            _dbContext.Remove(pawbondPost);
            await _dbContext.SaveChangesAsync();
            return pawbondPost;

        }

        public async Task<List<PawbondPost>> GetPawbondPosts()
        {
            List<PawbondPost> pawbondPosts = await _dbContext.PawbondPosts.ToListAsync();
            return pawbondPosts;
        }
    }
}

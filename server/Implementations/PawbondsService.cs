using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Enums;
using server.Interfaces;
using server.Models;

namespace server.Implementations
{
    public class PawbondsService : IPawbondsService
    {
        private readonly PawpalDbContext _dbContext;
        public PawbondsService(PawpalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Pawbond> CreatePawbond(int pawbondPostId, int pawpalId)
        {
            PawbondPost? pawbondPost = await _dbContext.PawbondPosts.FindAsync(pawbondPostId);
            Pawpal? partner = await _dbContext.Pawpals.FindAsync(pawpalId);
            Pawbond pawbond = new Pawbond()
            {
                AuthorId = pawbondPost.AuthorId,
                Author = pawbondPost.Author,
                PartnerId = partner.Id,
                Partner = partner,
                Status = StatusType.InProgress,
            };
            await _dbContext.Pawbonds.AddAsync(pawbond);
            await _dbContext.SaveChangesAsync();
            return pawbond;
        }

        public async Task<UsersPawbonds> GetPawbonds(int pawpalId)
        {
            List<Pawbond> sentPawbonds = await _dbContext.Pawbonds.Where(i => i.PartnerId == pawpalId).Include(p => p.Author).Include(p => p.Partner).ToListAsync();
            List<Pawbond> receivedPawbonds = await _dbContext.Pawbonds.Where(i => i.AuthorId == pawpalId).Include(p => p.Author).Include(p => p.Partner).ToListAsync();
            UsersPawbonds usersPawbonds = new UsersPawbonds()
            {
                Sent = sentPawbonds,
                Received = receivedPawbonds
            };
            return usersPawbonds;
        }

        public async Task<Pawbond?> UpdatePawbond(int pawbondId, StatusType status)
        {
            Pawbond? pawbond = await _dbContext.Pawbonds.FindAsync(pawbondId);
            if (pawbond == null)
            {
                return null;
            }
            pawbond.Status = status;
            await _dbContext.SaveChangesAsync();
            return pawbond;
        }
    }
}

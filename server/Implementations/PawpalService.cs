using server.Data;
using server.Interfaces;
using server.Models;

namespace server.Implementations
{
    public class PawpalService : IPawpalService
    {
        private readonly PawpalDbContext _dbContext;
        public PawpalService(PawpalDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Pawpal> CreatePawpal(CreatePawpalRequest createPawpalRequest)
        {
            Pawpal pawpal = new Pawpal()
            {
                Name = createPawpalRequest.Name,
                Breed = createPawpalRequest.Breed,
                Age = createPawpalRequest.Age,
                Photo = createPawpalRequest.Photo,
                Description = createPawpalRequest.Description,
                Owner = createPawpalRequest.Owner,
                Gender = createPawpalRequest.Gender
            };
            await _dbContext.Pawpals.AddAsync(pawpal);
            await _dbContext.SaveChangesAsync();
            return pawpal;
        }
    }
}

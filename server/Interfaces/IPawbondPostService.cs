using server.Models;

namespace server.Interfaces
{
    public interface IPawbondPostService
    {
        Task<PawbondPost> AddPawbondPost(AddPawbondPostRequest addPawbondPostRequest);
        Task<List<PawbondPost>> GetPawbondPosts();
        Task<PawbondPost?> DeletePawbondPost(int id);
    }
}

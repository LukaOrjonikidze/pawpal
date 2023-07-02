using server.Models;

namespace server.Interfaces
{
    public interface IPawbondPostsService
    {
        Task<PawbondPost> AddPawbondPost(AddPawbondPostRequest addPawbondPostRequest);
        Task<List<PawbondPost>> GetPawbondPosts();
        Task<PawbondPost?> DeletePawbondPost(int id);
    }
}

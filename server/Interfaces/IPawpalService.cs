using server.Models;

namespace server.Interfaces
{
    public interface IPawpalService
    {
        Task<Pawpal> CreatePawpal(CreatePawpalRequest createPawpalRequest);
    }
}

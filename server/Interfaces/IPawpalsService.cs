using server.Models;

namespace server.Interfaces
{
    public interface IPawpalsService
    {
        Task<Pawpal> CreatePawpal(CreatePawpalRequest createPawpalRequest);
    }
}

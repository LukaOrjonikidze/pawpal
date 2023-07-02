using server.Enums;
using server.Models;

namespace server.Interfaces
{
    public interface IPawbondsService
    {
        Task<UsersPawbonds> GetPawbonds(int pawpalId);
        Task<Pawbond> CreatePawbond(int pawbondPostId, int pawpalId);
        Task<Pawbond?> UpdatePawbond(int pawbondId, StatusType status);
    }
}

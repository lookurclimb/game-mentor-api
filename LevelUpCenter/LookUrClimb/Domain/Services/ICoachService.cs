using LevelUpCenter.LookUrClimb.Domain.Models;
using LevelUpCenter.LookUrClimb.Domain.Services.Communication;
using LevelUpCenter.Security.Domain.Models;

namespace LevelUpCenter.LookUrClimb.Domain.Services;

public interface ICoachService
{
    Task<IEnumerable<Coach>> ListAsync();
    Task<Coach> GetOneAsync(int id);
    Task<CoachResponse> SaveAsync(User user);
}

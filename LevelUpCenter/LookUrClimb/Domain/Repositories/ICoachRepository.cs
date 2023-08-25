using LevelUpCenter.LookUrClimb.Domain.Models;

namespace LevelUpCenter.LookUrClimb.Domain.Repositories;

public interface ICoachRepository
{
    Task<IEnumerable<Coach?>> ListAsync();
    Task<Coach?> FindByIdAsync(int id);
    Task AddAsync(Coach coach);
    void Update(Coach coach);
    void Remove(Coach coach);
}
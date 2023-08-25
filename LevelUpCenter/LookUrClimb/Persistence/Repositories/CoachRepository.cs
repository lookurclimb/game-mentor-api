using LevelUpCenter.LookUrClimb.Domain.Models;
using LevelUpCenter.LookUrClimb.Domain.Repositories;
using LevelUpCenter.Shared.Persistence.Contexts;
using LevelUpCenter.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LevelUpCenter.LookUrClimb.Persistence.Repositories;

public class CoachRepository : BaseRepository, ICoachRepository
{
    public CoachRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Coach?>> ListAsync()
    {
        return await _context.Coaches.ToListAsync();
    }

    public async Task<Coach?> FindByIdAsync(int id)
    {
        return await _context.Coaches
            .FirstOrDefaultAsync(p => p!.Id == id);
    }

    public async Task AddAsync(Coach coach)
    {
        await _context.Coaches.AddAsync(coach);
    }

    public void Update(Coach coach)
    {
        //throw new NotImplementedException();
    }

    public void Remove(Coach coach)
    {
        //throw new NotImplementedException();
    }
}
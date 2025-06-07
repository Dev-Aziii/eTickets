using eTickets.Data;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Services
{
    public class ActorsService(AppDbContext context) : IActorsService
    {
        private readonly AppDbContext _context = context;

        public async Task AddAsync(Actor actor)
        { 
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(a => a.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()  
        {
            var result = await _context.Actors.ToListAsync();
            return result; 
        }

        public async Task<IEnumerable<Actor>> GetAllPaginatedAsync(int pageNumber, int pageSize)
        {
            return await _context.Actors
                                 .OrderBy(a => a.FullName)
                                 .Skip((pageNumber - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToListAsync();
        }

        public async Task<int> GetTotalCountAsync()
        {
            return await _context.Actors.CountAsync();
        }


        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(a => a.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}

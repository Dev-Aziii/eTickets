using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService(AppDbContext context) : IActorsService
    {
        private readonly AppDbContext _context = context;

        public void Add(Actor actor)
        { 
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var allActors = await _context.Actors.ToListAsync();
            return allActors;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}

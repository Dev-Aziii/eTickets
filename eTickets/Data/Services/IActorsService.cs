using eTickets.Models;
public interface IActorsService
{
    Task<IEnumerable<Actor>> GetAllAsync();
    Task<IEnumerable<Actor>> GetAllPaginatedAsync(int pageNumber, int pageSize);
    Task<int> GetTotalCountAsync();
    Task<Actor> GetByIdAsync(int id);
    Task AddAsync(Actor actor);
    Task<Actor> UpdateAsync(int id, Actor newActor);
    Task DeleteAsync(int id);
}

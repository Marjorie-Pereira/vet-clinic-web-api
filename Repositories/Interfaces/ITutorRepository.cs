public interface ITutorRepository
{
    Task<IEnumerable<Tutor>> GetAllAsync();
    Task<Tutor?> GetByIdAsync(int id);
    Task<Tutor> AddAsync(Tutor tutor);
    Task UpdateAsync(Tutor tutor);
    Task DeleteAsync(int id);
}
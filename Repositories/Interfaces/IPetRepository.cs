public interface IPetRepository
{
    Task<IEnumerable<Pet>> GetAllAsync();
    Task<Pet?> GetByIdAsync(int id);
    Task<Pet> AddAsync(Pet pet);

    Task UpdateAync(Pet pet);

    Task DeleteAsync(int id);
}
public interface IPetService
{
    Task<IEnumerable<Pet>> GetAll();
    Task<Pet?> GetById(int id);
    Task<Pet> Add(Pet pet);
}
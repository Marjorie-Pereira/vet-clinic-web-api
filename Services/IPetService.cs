public interface IPetService
{
    Task<IEnumerable<Pet>> GetAll();
    Pet? GetById(int id);
    Pet Add(Pet pet);
}
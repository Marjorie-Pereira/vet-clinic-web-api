public class PetService(IPetRepository petRepository) : IPetService
{
    private readonly IPetRepository _petRepository = petRepository;

    public async Task<IEnumerable<Pet>> GetAll()
    {
        return await _petRepository.GetAllAsync();
    }

    public async Task<Pet?> GetById(int id)
    {
        return await _petRepository.GetByIdAsync(id);
    }

    public async Task<Pet> Add(Pet pet)
    {
        return await _petRepository.AddAsync(pet);
    }	
}
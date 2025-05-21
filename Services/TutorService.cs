public class TutorService(ITutorRepository tutorRepository) : ITutorService
{
    private readonly ITutorRepository _tutorRepository = tutorRepository;

    public async Task<IEnumerable<Tutor>> GetAll()
    {
        return await _tutorRepository.GetAll();
    }

    public async Task<Tutor?> GetById(int id)
    {
        return await _tutorRepository.GetById(id);
    }

    public async Task<Tutor> Add(Tutor tutor)
    {
        return await _tutorRepository.Add(tutor);
    }	
}
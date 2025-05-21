public interface ITutorRepository
{
    Task<IEnumerable<Tutor>> GetAll();
    Task<Tutor?> GetById(int id);
    Task<Tutor> Add(Tutor tutor);
}
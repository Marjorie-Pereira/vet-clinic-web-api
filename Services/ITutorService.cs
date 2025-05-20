public interface ITutorService
{
    Task<IEnumerable<Tutor>> GetAll();
    Tutor? GetById(int id);
    Tutor Add(Tutor tutor);
}
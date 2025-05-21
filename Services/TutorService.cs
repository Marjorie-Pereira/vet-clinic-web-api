public class TutorService : ITutorService
{
    private readonly List<Tutor> _tutores = [];
    public async Task<IEnumerable<Tutor>> GetAll() => _tutores;

    public Tutor? GetById(int id) =>
        _tutores.FirstOrDefault(tutor => tutor.Id == id);

    public Tutor Add(Tutor tutor)
    {
        tutor.Id = _tutores.Count + 1;
        _tutores.Add(tutor);

        return tutor;
    }
}
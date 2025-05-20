using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TutorController(ITutorService tutorService) : ControllerBase
{
    private readonly ITutorService _tutorService = tutorService;

    [HttpGet]
    public ActionResult<IEnumerable<Tutor>> Get() =>
        Ok(_tutorService.GetAll());

    [HttpGet("{id}")]
    public ActionResult<Tutor> GetById(int id)
    {
        var tutor = _tutorService.GetById(id);
        return tutor is null ? NotFound() : Ok(tutor);

    }

    [HttpPost]
    public ActionResult<Tutor> Post(Tutor tutor)
    {
        var novoTutor = _tutorService.Add(tutor);
        return CreatedAtAction(nameof(GetById), new { id = novoTutor.Id }, novoTutor);
    }
}
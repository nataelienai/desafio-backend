using DesafioBackend.Filters;
using DesafioBackend.Models;
using DesafioBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DesafioBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly PersonRepository _personRepository;

    public PersonController(PersonRepository personRepository) {
        _personRepository = personRepository;
    }

    [HttpPost]
    [ExecutionDurationActionFilter]
    [GenericExceptionFilter]
    public async Task<IActionResult> Create(Person person)
    {
        var createdPerson = await _personRepository.Create(person);
        return StatusCode(201, createdPerson);
    }
}

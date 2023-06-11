using DesafioBackend.Models;
using Microsoft.Azure.Cosmos;

namespace DesafioBackend.Repositories;

public class PersonRepository
{
    private readonly Container _container;

    public PersonRepository(Container container)
    {
        _container = container;
    }

    public async Task<Person> Create(Person person)
    {
        person.Id = Guid.NewGuid();
        var personResponse = await _container.CreateItemAsync<Person>(person);
        return personResponse.Resource;
    }
}

using Newtonsoft.Json;

namespace DesafioBackend.Models;

public class Person
{
    [JsonProperty(PropertyName = "id")]
    public Guid Id { get; set; }

    [JsonProperty(PropertyName = "firstName")]
    public string? FirstName { get; set; }

    [JsonProperty(PropertyName = "lastName")]
    public string? LastName { get; set; }

    [JsonProperty(PropertyName = "age")]
    public int Age { get; set; }
}

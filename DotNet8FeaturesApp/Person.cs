namespace DotNet8FeaturesApp;

public record Person(string FirstName, string LastName)
{
     public Person WithNewLastName(string newLastName) =>
        this with { LastName = newLastName };
}
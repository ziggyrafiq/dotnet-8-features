namespace DotNet8FeaturesApp;

public static class NullabilityExample
{
    public static void PrintLength(string? text)
    {
        Console.WriteLine(text is not null ? text.Length.ToString() : "Text is null ok");
    }

}
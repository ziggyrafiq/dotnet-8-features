namespace DotNet8FeaturesApp;
public class LargeObject
{
    private byte[] _data = new byte[10_000_000];
    public void UseLargeObject()
    {
        Console.WriteLine($"LargeObject with {_data.Length} bytes created.");
    }
}

public record LargeObjectStatus(bool IsInUse, int Size);

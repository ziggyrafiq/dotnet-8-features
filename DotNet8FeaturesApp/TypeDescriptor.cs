namespace DotNet8FeaturesApp;

public static class TypeDescriptor
{
    public static string Describe(object obj) =>
        obj switch
        {
            int i when i > 0 => "Positive integer",
            int i when i < 0 => "Negative integer",
            string s => $"String of length {s.Length}",
            double d when d > 0 => "Positive double",
            DateTime dt => $"DateTime value: {dt:yyyy-MM-dd}",
            _ => "Unknown type"
        };
}

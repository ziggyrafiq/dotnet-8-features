using DotNet8FeaturesApp;
using System.Device.Gpio;
using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("Hello and welcome to Article Code Examples for .NET 8 Features with C# 12 by Ziggy Rafiq");

int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(MathOperations.Sum(numbers));
MathOperations.DisplaySum(numbers);


var largeObject = new LargeObject();
largeObject.UseLargeObject();

var status = new LargeObjectStatus(IsInUse: true, Size: 10_000_000);
Console.WriteLine(status switch
{
    { IsInUse: true, Size: > 0 } => $"Large object is in use with size {status.Size} bytes.",
    _ => "Large object status is unknown."
});

Console.WriteLine("This Application has started quickly!");


Console.WriteLine(TypeDescriptor.Describe(42));
Console.WriteLine(TypeDescriptor.Describe("Hello Reader"));
Console.WriteLine(TypeDescriptor.Describe(3.14)); 
Console.WriteLine(TypeDescriptor.Describe(DateTime.Now));
Console.WriteLine(TypeDescriptor.Describe(null));

var person = new Person("Mike", "Joe");
var updatedPerson = person.WithNewLastName("Walker");
Console.WriteLine(updatedPerson);

NullabilityExample.PrintLength("Hi");
NullabilityExample.PrintLength(null);

var json = "{\"Name\":\"Lisa\",\"Age\":28}";
var human = JsonSerializer.Deserialize<Human>(json);

Console.WriteLine($"Name: {human?.Name}, Age: {human?.Age}");

using var gpioController = new GpioController();
gpioController.OpenPin(18, PinMode.Output);
gpioController.Write(18, PinValue.High);
Console.WriteLine("Pin 18 set to High");

using var client = new HttpClient();
var response = await client.GetStringAsync("https://ziggyrafiq.com");
Console.WriteLine(response.Substring(0, 100));

if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
{
    // Check if running on Apple Silicon (ARM64) or Intel (x64)
    if (RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
    {
        Console.WriteLine("Running natively on Apple Silicon!");
    }
    else
    {
        Console.WriteLine("Running on macOS (Intel chip)!");
    }
}
// Check if the application is running on Windows
else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    Console.WriteLine("Running on Windows!");
}
else
{
    Console.WriteLine("Running on an unsupported OS!");
}
        

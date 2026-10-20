using Newtonsoft.Json;

var trainee = new
{
    Name = "Hassan",
    Course = "GitHub Actions",
    Topic = "NuGet Cache"
};

string json = JsonConvert.SerializeObject(trainee, Formatting.Indented);
Console.WriteLine("Training project is running!");
Console.WriteLine(json);

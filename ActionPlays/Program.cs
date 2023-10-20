// See https://aka.ms/new-console-template for more information
using ActionPlays.Model;

Console.WriteLine("Hello, World of Conferences!");
Conference c = new Conference(
	   new DateOnly(2023, 11, 8),
	new DateOnly(2023, 11, 11),
	"DevConf");
Console.WriteLine($"Dennie's next conference is:  {c.Name}, from {c.From} to {c.To}");
Console.WriteLine("Press any key to exit");
Console.ReadKey();


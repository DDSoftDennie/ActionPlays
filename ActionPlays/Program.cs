LocalConferenceFactory factory = new LocalConferenceFactory();

Console.WriteLine("Hello, World of Conferences!");
Conference c = factory.CreateConference(
       new DateOnly(2023, 11, 8),
        new DateOnly(2023, 11, 11),
       "DevConf");

Console.WriteLine($"Dennie's next conference is: {c.ToString()}");
Console.WriteLine("Press any key to exit");
Console.ReadKey();


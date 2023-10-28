namespace ActionPlays.Tests.Factories
{
    public class LocalConferenceFactoryTests
    {
        [Fact]
        public void CreateConferenceTest()
        {
            // Arrange
            LocalConferenceFactory factory = new LocalConferenceFactory();
            DateOnly from = new DateOnly(2023, 11, 8);
            DateOnly to = new DateOnly(2023, 11, 11);
            string name = "DevConf";

            // Act
            Conference c = factory.CreateConference(from, to, name);

            // Assert
            Assert.Equal(from, c.From);
            Assert.Equal(to, c.To);
            Assert.Equal(name, c.Name);
        }
    }
}

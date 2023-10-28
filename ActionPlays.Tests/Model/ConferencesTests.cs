namespace ActionPlays.Tests.Model
{
    public class ConferencesTests
    {
        [Fact]
        public void CreateConference()
        {
            var conference = new Conference(new DateOnly(2023, 10, 1), new DateOnly(2023, 10, 3), "Test Conference");
            Assert.Equal("Test Conference", conference.Name);
            Assert.Equal(new DateOnly(2023, 10, 1), conference.From);
            Assert.Equal(new DateOnly(2023, 10, 3), conference.To);
        }
        [Fact]
        public void CreateConferenceWithInvalidDates()
        {
            Assert.Throws<ArgumentException>(() => new Conference(new DateOnly(2023, 10, 3), new DateOnly(2023, 10, 1), "Test Conference"));
        }
        [Fact]
        public void ConferenceToStringWorksAsExpected()
        {
            var conference = new Conference(new DateOnly(2023, 10, 1), new DateOnly(2023, 10, 3), "Test Conference");
            Assert.Equal("Conference: Test Conference, from 1/10/2023 to 3/10/2023", conference.ToString());
        }
    }
}

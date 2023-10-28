using ActionPlays.Model;


namespace ActionPlays.Factories.Interfaces
{
    public interface IConferenceFactory
    {
        Conference CreateConference(DateOnly from, DateOnly to, string name);
    }
}

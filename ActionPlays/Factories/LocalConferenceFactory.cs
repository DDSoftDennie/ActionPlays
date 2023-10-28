using ActionPlays.Factories.Interfaces;
using ActionPlays.Model;


namespace ActionPlays.Factories
{
    public class LocalConferenceFactory: IConferenceFactory
    {
        public Conference CreateConference(DateOnly from, DateOnly to, string name)
        {
            return new Conference(from, to, name);
        }
    }
}

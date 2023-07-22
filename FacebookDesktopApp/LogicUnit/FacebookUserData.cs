using FacebookWrapper.ObjectModel;

namespace LogicUnit
{
    public class FacebookUserData
    {
        public FacebookObjectCollection<Album> UserAlbums { get; }
        public FacebookObjectCollection<Group> UserGroups { get; }
        public FacebookObjectCollection<Event> UserEvents { get; }

        public FacebookUserData(User i_User = null)
        {
            UserAlbums = i_User?.Albums;
            UserGroups = i_User?.Groups;
            UserEvents = i_User?.Events;
        }
    }
}

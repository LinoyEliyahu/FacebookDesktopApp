using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace LogicUnit
{
    public class FacebookLoginFacade
    {
        private LoginResult m_LoginResult;
        private AppSettings m_AppSettings;

        public bool IsUserLoggedIn { get; private set; }
        public bool RememberUserAppSettings
        {
            get => m_AppSettings.RememberUser;
            set => m_AppSettings.RememberUser = value;
        }

        private User loginUser()
        {
            m_LoginResult = FacebookService.Login(
                    "835906181023463",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos",
                    "groups_access_member_info");
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                IsUserLoggedIn = true;
            }

            return m_LoginResult.LoggedInUser;
        }

        public User ConnectToFacebook()
        {
            if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.AccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.AccessToken);
                IsUserLoggedIn = true;
            }

            return m_LoginResult?.LoggedInUser;
        }

        public void SaveUser()
        {
            if (m_AppSettings.RememberUser)
            {
                m_AppSettings.SaveDataToFile(m_LoginResult.AccessToken);
                m_AppSettings.AccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.DeleteFile();
                m_AppSettings.AccessToken = null;
            }
        }

        public void LoadDataFromFile()
        {
            m_AppSettings = AppSettings.LoadDataFromFile();
        }

        public void Logout()
        {
            IsUserLoggedIn = false;
            FacebookService.Logout();
        }

        public User GetLoggedInUser()
        {
            return loginUser();
        }
    }
}
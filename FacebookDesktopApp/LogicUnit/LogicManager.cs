using System;
using System.Collections.Generic;
using Facebook;
using FacebookWrapper.ObjectModel;
using LogicUnit.Strategy;

namespace LogicUnit
{
    public sealed class LogicManager
    {
        private static readonly object sr_LogicManagerLock = new object();
        private static LogicManager s_LogicManager;
        private readonly FacebookLoginFacade r_FacebookLoginFacade = new FacebookLoginFacade();

        public event Action<FacebookObjectCollection<Post>> NewPostAdded;
        public StrategySorter LikePagesSorter { get; set; } = new StrategySorter();
        public User LoggedInUser { get; set; }

        public bool IsUserLoggedIn => r_FacebookLoginFacade.IsUserLoggedIn;
        public bool RememberUser
        {
            get => r_FacebookLoginFacade.RememberUserAppSettings;
            set => r_FacebookLoginFacade.RememberUserAppSettings = value;
        }

        public static LogicManager Instance
        {
            get
            {
                if(s_LogicManager == null)
                {
                    lock (sr_LogicManagerLock)
                    {
                        if (s_LogicManager == null)
                        {
                            s_LogicManager = new LogicManager();
                        }
                    }
                }

                return s_LogicManager;
            }
        }
        private LogicManager()
        {
        }

        public bool IsConnectToFacebook()
        {
            LoggedInUser = r_FacebookLoginFacade.ConnectToFacebook();

            return LoggedInUser != null;
        }

        public void SaveUser()
        {
            r_FacebookLoginFacade.SaveUser();
        }

        public bool StartLogin()
        {
            LoggedInUser = r_FacebookLoginFacade.GetLoggedInUser();

            return LoggedInUser != null;
        }

        public FacebookUserData GetUserData()
        {
            return new FacebookUserData(LoggedInUser);
        }

        public List<Page> CreateUserLikePagesList()
        {
            List<Page> likedPagesList = new List<Page>();
            if (r_FacebookLoginFacade.IsUserLoggedIn)
            {
                if (LoggedInUser.LikedPages.Count > 0)
                {
                    foreach (Page simplePage in LoggedInUser.LikedPages)
                    {
                        likedPagesList.Add(simplePage);
                    }

                    return likedPagesList;
                }
            }

            throw new Exception("No liked pages upTo retrieve :(");
        }

        public FacebookObjectCollection<Post> GetUserPosts()
        {
            FacebookObjectCollection<Post> userPosts = new FacebookObjectCollection<Post>();
            if (r_FacebookLoginFacade.IsUserLoggedIn)
            {
                try
                {
                    userPosts = LoggedInUser.Posts;
                }
                catch (FacebookOAuthException e)
                {
                }
            }

            return userPosts;
        }

        public bool PostStatusAndReturnIfSucceed(string i_TextToPost)
        {
            bool isSucceed = false;
            if (r_FacebookLoginFacade.IsUserLoggedIn)
            {
                LoggedInUser.PostStatus(i_TextToPost);
                isSucceed = true;
            }

            if (isSucceed)
            {
                NewPostAdded?.Invoke(GetUserPosts());
            }

            return isSucceed;
        }

        public FacebookObjectCollection<Photo> GetUserPhotosBetweenDates(DateTime i_From, DateTime i_UpTo)
        {
            FacebookObjectCollection<Photo> collectionOfPhotos = new FacebookObjectCollection<Photo>();
            if (r_FacebookLoginFacade.IsUserLoggedIn)
            {
                foreach (Album album in LoggedInUser.Albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        if (photo.CreatedTime.HasValue && isBetweenTheDates(i_From, i_UpTo, photo.CreatedTime.Value))
                        {
                            collectionOfPhotos.Add(photo);
                        }
                    }
                }
            }

            return collectionOfPhotos;
        }

        private bool isBetweenTheDates(DateTime i_From, DateTime i_UpTo, DateTime i_PhotoCreatedTime)
        {
            return i_From.Date <= i_PhotoCreatedTime.Date && i_UpTo.Date >= i_PhotoCreatedTime.Date;
        }

        public Dictionary<string, int> GetUserTop10Taggers()
        {
            Dictionary<string, int> userTaggers = new Dictionary<string, int>();
            if (r_FacebookLoginFacade.IsUserLoggedIn)
            {
                TopUsersTaggers feature2 = new TopUsersTaggers();
                feature2.CollectTop10Taggers(LoggedInUser);
                userTaggers = feature2.UserTaggedBy;
            }

            return userTaggers;
        }

        public void LoadDataFromFile()
        {
            r_FacebookLoginFacade.LoadDataFromFile();
        }

        public void Logout()
        {
            r_FacebookLoginFacade.Logout();
        }
    }
}

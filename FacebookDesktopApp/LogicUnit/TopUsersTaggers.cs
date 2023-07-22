using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;
using Facebook;

namespace LogicUnit
{
    public class TopUsersTaggers
    {
        public void CollectTop10Taggers(User i_User)
        {
            try
            {
                FacebookObjectCollection<Post> taggedInPosts = i_User.PostsTaggedIn;
                FacebookObjectCollection<Photo> taggedInPhotos = i_User.PhotosTaggedIn;
                foreach (Post post in taggedInPosts)
                {
                    UserTaggedBy[post.From.Name] += 1;
                }

                foreach (Photo photo in taggedInPhotos)
                {
                    UserTaggedBy[photo.From.Name] += 1;
                }
            }
            catch (FacebookOAuthException)
            {
                useDummyDictionaryForUsersTaggedBy();
            }

            UserTaggedBy = UserTaggedBy
                    .OrderByDescending(i_Tagger => i_Tagger.Value)
                    .ToDictionary(i_Tagger => i_Tagger.Key, i_Tagger => i_Tagger.Value);
            UserTaggedBy = UserTaggedBy
                .Take(10)
                .ToDictionary(i_Tagger => i_Tagger.Key, i_Tagger => i_Tagger.Value);
        }

        public Dictionary<string, int> UserTaggedBy { get; private set; } = new Dictionary<string, int>();

        private void useDummyDictionaryForUsersTaggedBy()
        {
            UserTaggedBy.Clear();
            UserTaggedBy.Add("Benjamin Netanyahu", 200);
            UserTaggedBy.Add("Yair Lapid", 99);
            UserTaggedBy.Add("Merav Michaeli", 88);
            UserTaggedBy.Add("Naftali Bennet", 255);
            UserTaggedBy.Add("Itamar Ben Gvir", 200);
            UserTaggedBy.Add("Beni Gantz", 175);
            UserTaggedBy.Add("Arie Deri", 30);
            UserTaggedBy.Add("Gidon Saar", 150);
            UserTaggedBy.Add("Guy Ronen", 1);
            UserTaggedBy.Add("Aviad Cohen", 25);
            UserTaggedBy.Add("Ada Tuma Suliman", 42);
            UserTaggedBy.Add("Omer Bar Lev", 66);
        }
    }
}

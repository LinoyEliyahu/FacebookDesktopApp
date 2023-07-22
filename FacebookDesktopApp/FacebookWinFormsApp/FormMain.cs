using System;
using System.Windows.Forms;
using System.Threading;
using Facebook;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using LogicUnit;
using LogicUnit.Strategy;
using BasicFacebookFeatures.Command;
using BasicFacebookFeatures.Command.FormCommands;
using BasicFacebookFeatures.Command.Interfaces;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly LogicManager r_LogicUnit = LogicManager.Instance;
        private readonly PanelBuilder r_Builder = new PanelBuilder();
        private UserInfoPick m_UserInfoPick;
        private Album m_AlbumNameChange = new Album();
        private int m_UserSelectedIndex = 0;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            r_LogicUnit.LoadDataFromFile();
            this.StartPosition = FormStartPosition.Manual;
            this.checkBoxRememberUser.Checked = r_LogicUnit.RememberUser;
        }

        public class UserInfoPick
        {
            public ICommandCreateForm CommandCreateForm { get; set; }

            public void Selected(Panel i_Panel, FacebookUserData i_CurrentUserData, PanelBuilder i_Builder)
            {
                if (CommandCreateForm != null)
                {
                    CommandCreateForm.Execute(i_Panel, i_CurrentUserData, i_Builder);
                }
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (r_LogicUnit.IsConnectToFacebook())
            {
                pictureBoxUserProfile.LoadAsync(r_LogicUnit.LoggedInUser.PictureNormalURL);
                labelProfileName.Text = r_LogicUnit.LoggedInUser.Name;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_LogicUnit.RememberUser = this.checkBoxRememberUser.Checked;
            r_LogicUnit.SaveUser();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc");
            startLogin();
        }

        private void startLogin()

        {
            bool isAccessTokenOk = r_LogicUnit.StartLogin();

            if (isAccessTokenOk)
            {
                pictureBoxUserProfile.LoadAsync(r_LogicUnit.LoggedInUser.PictureNormalURL);
                labelProfileName.Text = r_LogicUnit.LoggedInUser.Name;
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void clearFormControls()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Invoke(new Action(() => textBox.Text = string.Empty));
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Invoke(new Action(() => checkBox.Checked = false));
                }
                else if (control is ListBox listBox)
                {
                    listBox.Invoke(new Action(() => listBox.Items.Clear()));
                }
                else if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null;
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now.Date;
                }
                else if (control is Panel panel)
                {
                    panel.Controls.Clear();
                }
            }
        }

        private void logout()
        {
            r_LogicUnit.Logout();
            FacebookService.LogoutWithUI();
            clearFormControls();
            labelProfileName.Text = "ProfileName";
        }

        private void postStatus(string i_Status)
        {
            try
            {
                r_LogicUnit.NewPostAdded += fetchPosts;
                string statusMessage = r_LogicUnit.PostStatusAndReturnIfSucceed(i_Status)
                                           ? "Status Posted!"
                                           : "Post Failed";
                MessageBox.Show(statusMessage);
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("No Authorization");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            postStatus(textBoxPostStatus.Text);
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = r_LogicUnit.LoggedInUser.Posts[listBoxPosts.SelectedIndex];
            listBoxPostsComments.Invoke(new Action(() => listBoxPostsComments.DisplayMember = "Message"));
            listBoxPostsComments.Invoke(new Action(() => listBoxPostsComments.DataSource = selected.Comments));
        }

        private void linkLabelPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(() =>fetchPosts(r_LogicUnit.GetUserPosts())).Start();
        }

        private void fetchPosts(FacebookObjectCollection<Post> i_UserPosts)
        {
            r_LogicUnit.NewPostAdded -= fetchPosts;
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
            try
            {
                foreach (Post simplePosts in i_UserPosts)
                {
                    if (simplePosts.Message != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(simplePosts.Message)));
                    }
                    else if (simplePosts.Caption != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(simplePosts.Caption)));
                    }
                    else
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add($"[{simplePosts.Type}]")));
                    }
                }

                if (listBoxPosts.Items.Count == 0)
                {
                    MessageBox.Show("No Posts to retrieve :(");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void listBoxPostsComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPostsComments();
        }

        private void showPostsComments()
        {
            if (listBoxPosts.Items.Count > 0)
            {
                Post selectedPost = r_LogicUnit.LoggedInUser.Posts[listBoxPosts.SelectedIndex];
                listBoxPostsComments.Invoke(new Action(() => listBoxPostsComments.DisplayMember = "Message"));
                listBoxPostsComments.Invoke(new Action(() => listBoxPostsComments.DataSource = selectedPost.Comments));
            }
        }

        private void fetchUserAlbums()
        {
            r_Builder.ShowAlbumName += showAlbumName;
            m_UserInfoPick = new UserInfoPick { CommandCreateForm = new CreateAlbumsFormCommand() };
            m_UserInfoPick.Selected(panelPhotos, r_LogicUnit.GetUserData(), r_Builder);
        }

        private void showAlbumName(Album i_Album)
        {
            m_AlbumNameChange = i_Album;
            labelAlbumName.Visible = true;
            textBoxName.Visible = true;
            textBoxName.Text = i_Album.Name;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            foreach (Control control in panelPhotos.Controls)
            {
                if (control is Label label)
                {
                    if (string.Equals(label.Text.Remove(0, 5), m_AlbumNameChange.Name))
                    {
                        label.Text = "Name:" + (sender as TextBox)?.Text;
                    }
                }
            }

            m_AlbumNameChange.Name = (sender as TextBox)?.Text;
        }

        private void linkLabelFetchAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchUserAlbums).Start();
        }

        private void linkLabelFetchGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchUserGroups).Start();
        }

        private void fetchUserGroups()
        {
            m_UserInfoPick = new UserInfoPick { CommandCreateForm = new CreateGroupsFormCommand() };
            m_UserInfoPick.Selected(panelGroups, r_LogicUnit.GetUserData(), r_Builder);
        }

        private void linkLabelLikePages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchPages).Start();
        }

        private void fetchPages()
        {
            try
            {
                //listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Clear()));
                //listBoxLikePages.Invoke(new Action(() => listBoxLikePages.DisplayMember = "Name"));

                //List<Page> likedPagesList = r_LogicUnit.CreateUserLikePagesList();
                //foreach (Page likedPage in likedPagesList)
                //{
                //    listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Add(likedPage)));
                //}
                fetchLikedPagesByStrategy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxLikePages_SelectedIndexChanged(object sender, EventArgs e)
        {
            showLikePagesPicture();
        }

        private void showLikePagesPicture()
        {
            if (listBoxLikePages.SelectedItems.Count == 1)
            {
                if (listBoxLikePages.SelectedItem is Page selectedPage)
                {
                    pictureBoxlikedPage.LoadAsync(selectedPage.PictureNormalURL);
                }
            }
        }

        private void linkLabelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchEvents).Start();
        }

        private void fetchEvents()
        {
            m_UserInfoPick = new UserInfoPick { CommandCreateForm = new CreateEventsFormCommand() };
            m_UserInfoPick.Selected(panelEvents, r_LogicUnit.GetUserData() ,r_Builder);
        }

        private void showPicturesBetweenDates()
        {
            DateTime from = Convert.ToDateTime(dateTimePickerFrom.Text);
            DateTime upTo = Convert.ToDateTime(dateTimePickerUpTo.Text);

            if (upTo < from)
            {
                MessageBox.Show("Please enter a valid date range!");
            }
            else
            {
                FacebookObjectCollection<Photo> selectedPhotos = r_LogicUnit.GetUserPhotosBetweenDates(from, upTo);

                if (selectedPhotos.Count == 0)
                {
                    MessageBox.Show("No photos to retrieve :(");
                }
                else
                {
                    FormImageGallery selectedPhotoGallery = new FormImageGallery(selectedPhotos);
                    selectedPhotoGallery.ShowDialog();
                }
            }
        }

        private void showTop10Taggers()
        {
            FormShowTop10TaggersChart formFeature2 = new FormShowTop10TaggersChart(r_LogicUnit.GetUserTop10Taggers());
            formFeature2.ShowDialog();
        }

        private void feature2LabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(showTop10Taggers).Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(showPicturesBetweenDates).Start();
        }

        private void comboBoxLikedPagesStrategies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                m_UserSelectedIndex = comboBoxLikedPagesStrategies.SelectedIndex;
                fetchLikedPagesByStrategy();
            }
        }

        private void fetchLikedPagesByStrategy()
        {
            Page[] userLikedPages = r_LogicUnit.CreateUserLikePagesList().ToArray();

            comboBoxLikePagesDecision();

            listBoxLikePages.Invoke(new Action(() => listBoxLikePages.DisplayMember = "Name"));
            listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Clear()));

            r_LogicUnit.LikePagesSorter.StrategySort(userLikedPages);

            foreach (Page simplePage in userLikedPages)
            {
                listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Add(simplePage)));
            }
        }

        private void comboBoxLikePagesDecision()
        {
            switch (m_UserSelectedIndex)
            {
                case 0:
                    r_LogicUnit.LikePagesSorter.SortAlgorithm = new AzSortStrategy();
                    break;
                case 1:
                    r_LogicUnit.LikePagesSorter.SortAlgorithm = new ZaSortStrategy();
                    break;
                case 2:
                    r_LogicUnit.LikePagesSorter.SortAlgorithm = new LikesCountSortStrategy();
                    break;
                default:
                    break;
            }
        }
    }
}
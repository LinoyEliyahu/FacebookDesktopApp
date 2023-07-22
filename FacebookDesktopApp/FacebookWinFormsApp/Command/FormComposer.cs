using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Command.BuilderCommands;
using BasicFacebookFeatures.Command.Interfaces;
using LogicUnit;

namespace BasicFacebookFeatures.Command
{
    public partial class FormComposer : Form
    {
        private readonly List<object> r_UserInfo = new List<object>();
        private Panel m_Panel = new Panel();
        private FacebookUserData m_CurrentUser = new FacebookUserData();
        private PanelBuilder m_Builder = new PanelBuilder();
        private UserInfoBuilderPick m_UserInfoBuilderPick;

        public FormComposer()
        {
            InitializeComponent();
        }

        public class UserInfoBuilderPick
        {
            public ICommandBuildPanel CommandBuildPanel { get; set; }

            public void Selected(Panel i_Panel, List<object> i_UserInfo, FacebookUserData i_CurrentUserData, PanelBuilder i_PanelBuilder)
            {
                if (CommandBuildPanel != null)     
                {
                    CommandBuildPanel.Execute(i_Panel, i_UserInfo, i_CurrentUserData, i_PanelBuilder);
                }
            }
        }

        public void InfoToGet(Panel i_Panel, FacebookUserData i_CurrentUserData, PanelBuilder i_Builder)
        {
            m_Panel = i_Panel;
            m_CurrentUser = i_CurrentUserData;
            m_Builder = i_Builder;
        }

        private void activateBuilder()
        {
            m_UserInfoBuilderPick.Selected(m_Panel, r_UserInfo, m_CurrentUser, m_Builder);
        }

        private void checkBoxAlbumCoverPhoto_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eAlbumInfo.CoverPhoto);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eAlbumInfo.CoverPhoto);
            }
        }

        private void checkBoxAlbumNumberOfPhotos_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eAlbumInfo.NumberOfPhotos);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eAlbumInfo.NumberOfPhotos);
            }
        }

        private void checkBoxAlbumTimeCreated_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eAlbumInfo.TimeCreated);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eAlbumInfo.TimeCreated);
            }
        }

        private void checkBoxAlbumLastUpdated_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eAlbumInfo.LastUpdated);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eAlbumInfo.LastUpdated);
            }
        }

        private void checkBoxAlbumAmountOfLikes_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eAlbumInfo.AmountOfLikes);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eAlbumInfo.AmountOfLikes);
            }
        }

        private void checkBoxGroupCoverPhoto_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eGroupInfo.GroupCoverPhoto);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eGroupInfo.GroupCoverPhoto);
            }
        }

        private void checkBoxGroupDescription_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eGroupInfo.GroupDescription);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eGroupInfo.GroupDescription);
            }
        }

        private void checkBoxGroupLastUpdated_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eGroupInfo.GroupLastUpdated);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eGroupInfo.GroupLastUpdated);
            }
        }

        private void checkBoxGroupOwner_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eGroupInfo.GroupOwner);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eGroupInfo.GroupOwner);
            }
        }

        private void checkBoxEventCoverPhoto_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eEventInfo.EventCoverPhoto);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eEventInfo.EventCoverPhoto);
            }
        }

        private void checkBoxEventDescription_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eEventInfo.EventDescription);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eEventInfo.EventDescription);
            }
        }

        private void checkBoxEventStartTime_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eEventInfo.EventStartTime);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eEventInfo.EventStartTime);
            }
        }

        private void checkBoxEventEndTime_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                r_UserInfo.Add(BasicFacebookFeatures.Command.Enums.eEventInfo.EventEndTime);
            }
            else
            {
                r_UserInfo.Remove(BasicFacebookFeatures.Command.Enums.eEventInfo.EventEndTime);
            }
        }

        public void AlbumFormBuilder()
        {
            m_UserInfoBuilderPick = new UserInfoBuilderPick { CommandBuildPanel = new BuildAlbumPanelCommand() };
            this.Size = new Size(346, 545);
            Label label = new Label
            {
                Size = new Size(191, 17),
                Text = "Pick info on album to present",
                Location = new Point(28, 11)
            };
            this.Controls.Add(label);
            CheckBox checkBoxAlbumName = new CheckBox
            {
                Text = "Name",
                Size = new Size(67, 21),
                Location = new Point(61, 55),
                Checked = true,
                Enabled = false,
                Visible = true
            };
            this.Controls.Add(checkBoxAlbumName);
            CheckBox checkBoxAlbumCoverPhoto = new CheckBox
            {
                Text = "Cover Photo",
                Size = new Size(108, 21),
                Location = new Point(61, 105),
                Visible = true
            };
            checkBoxAlbumCoverPhoto.CheckedChanged += checkBoxAlbumCoverPhoto_CheckedChanged;
            this.Controls.Add(checkBoxAlbumCoverPhoto);
            CheckBox checkBoxAlbumNumberOfPhotos = new CheckBox
            {
                Text = "Number Of Photos",
                Size = new Size(147, 21),
                Location = new Point(61, 159),
                Visible = true
            };
            checkBoxAlbumNumberOfPhotos.CheckedChanged += checkBoxAlbumNumberOfPhotos_CheckedChanged;
            this.Controls.Add(checkBoxAlbumNumberOfPhotos);
            CheckBox checkBoxAlbumTimeCreated = new CheckBox
            {
                Text = "Time Created",
                Size = new Size(115, 21),
                Location = new Point(61, 207),
                Visible = true
            };
            checkBoxAlbumTimeCreated.CheckedChanged += checkBoxAlbumTimeCreated_CheckedChanged;
            this.Controls.Add(checkBoxAlbumTimeCreated);
            CheckBox checkBoxAlbumLastUpdated = new CheckBox
            {
                Text = "Last Updated",
                Size = new Size(115, 21),
                Location = new Point(61, 258),
                Visible = true
            };
            checkBoxAlbumLastUpdated.CheckedChanged += checkBoxAlbumLastUpdated_CheckedChanged;
            this.Controls.Add(checkBoxAlbumLastUpdated);
            CheckBox checkBoxAlbumAmountOfLikes = new CheckBox
            {
                Text = "Amount Of Likes",
                Size = new Size(134, 21),
                Location = new Point(61, 314),
                Visible = true
            };
            checkBoxAlbumAmountOfLikes.CheckedChanged += checkBoxAlbumAmountOfLikes_CheckedChanged;
            this.Controls.Add(checkBoxAlbumAmountOfLikes);
            buttonBuilder.Location = new Point(89, 383);
        }

        public void GroupFormBuilder()
        {
            m_UserInfoBuilderPick = new UserInfoBuilderPick { CommandBuildPanel = new BuildGroupPanelCommand() };
            this.Size = new Size(326, 489);
            Label label = new Label
            {
                Size = new Size(191, 17),
                Text = "Pick info on group to present",
                Location = new Point(28, 11)
            };
            this.Controls.Add(label);
            CheckBox checkBoxGroupName = new CheckBox
            {
                Text = "Name",
                Size = new Size(67, 21),
                Location = new Point(61, 55),
                Checked = true,
                Enabled = false,
                Visible = true
            };
            this.Controls.Add(checkBoxGroupName);
            CheckBox checkBoxGroupCoverPhoto = new CheckBox
            {
                Text = "Cover Photo",
                Size = new Size(108, 21),
                Location = new Point(61, 105),
                Visible = true
            };
            checkBoxGroupCoverPhoto.CheckedChanged += checkBoxGroupCoverPhoto_CheckedChanged;
            this.Controls.Add(checkBoxGroupCoverPhoto);
            CheckBox checkBoxGroupDescription = new CheckBox
            {
                Text = "Group Description",
                Size = new Size(147, 21),
                Location = new Point(61, 159),
                Visible = true
            };
            checkBoxGroupDescription.CheckedChanged += checkBoxGroupDescription_CheckedChanged;
            this.Controls.Add(checkBoxGroupDescription);
            CheckBox checkBoxGroupLastUpdated = new CheckBox
            {
                Text = "Last Updated",
                Size = new Size(115, 21),
                Location = new Point(61, 207),
                Visible = true
            };
            checkBoxGroupLastUpdated.CheckedChanged += checkBoxGroupLastUpdated_CheckedChanged;
            this.Controls.Add(checkBoxGroupLastUpdated);
            CheckBox checkBoxGroupOwner = new CheckBox
            {
                Text = "Owner",
                Size = new Size(134, 21),
                Location = new Point(61, 258),
                Visible = true
            };
            checkBoxGroupOwner.CheckedChanged += checkBoxGroupOwner_CheckedChanged;
            this.Controls.Add(checkBoxGroupOwner);
            buttonBuilder.Location = new Point(89, 327);
        }

        public void EventsFormBuilder()
        {
            m_UserInfoBuilderPick = new UserInfoBuilderPick{ CommandBuildPanel = new BuildEventPanelCommand()};
            this.Size = new Size(326, 489);
            Label label = new Label
            {
                Size = new Size(191, 17),
                Text = "Pick info on Event to present",
                Location = new Point(28, 11)
            };
            this.Controls.Add(label);
            CheckBox checkBoxEventName = new CheckBox
            {
                Text = "Name",
                Size = new Size(67, 21),
                Location = new Point(61, 55),
                Checked = true,
                Enabled = false,
                Visible = true
            };
            this.Controls.Add(checkBoxEventName);
            CheckBox checkBoxEventCoverPhoto = new CheckBox
            {
                Text = "Cover Photo",
                Size = new Size(108, 21),
                Location = new Point(61, 105),
                Visible = true
            };
            checkBoxEventCoverPhoto.CheckedChanged += checkBoxEventCoverPhoto_CheckedChanged;
            this.Controls.Add(checkBoxEventCoverPhoto);
            CheckBox checkBoxEventDescription = new CheckBox
            {
                Text = "Description",
                Size = new Size(147, 21),
                Location = new Point(61, 159),
                Visible = true
            };
            checkBoxEventDescription.CheckedChanged += checkBoxEventDescription_CheckedChanged;
            this.Controls.Add(checkBoxEventDescription);
            CheckBox checkBoxEventStartTime = new CheckBox
            {
                Text = "Start Time",
                Size = new Size(115, 21),
                Location = new Point(61, 207),
                Visible = true
            };
            checkBoxEventStartTime.CheckedChanged += checkBoxEventStartTime_CheckedChanged;
            this.Controls.Add(checkBoxEventStartTime);
            CheckBox checkBoxEventEndTime = new CheckBox
            {
                Text = "End Time",
                Size = new Size(115, 21),
                Location = new Point(61, 258),
                Visible = true
            };
            checkBoxEventEndTime.CheckedChanged += checkBoxEventEndTime_CheckedChanged;
            this.Controls.Add(checkBoxEventEndTime);
            buttonBuilder.Location = new Point(89, 327);
        }

        private void buttonBuilder_Click(object sender, EventArgs e)
        {
            m_Panel.Invoke(new Action(() => m_Panel.Controls.Clear()));
            Close();
            new Thread(activateBuilder).Start();
        }
    }
}

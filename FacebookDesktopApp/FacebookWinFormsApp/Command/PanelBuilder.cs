using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BasicFacebookFeatures.Command.Enums;
using FacebookWrapper.ObjectModel;
using LogicUnit;

namespace BasicFacebookFeatures.Command
{
    public class PanelBuilder
    {
        private FacebookObjectCollection<Album> m_Albums;
        private FacebookObjectCollection<Event> m_Events;
        private FacebookObjectCollection<Group> m_Groups;
        public event Action<Album> ShowAlbumName;

        public void BuildAlbumsPanel(Panel i_Panel, List<object> i_AlbumInfos, FacebookUserData i_CurrentUserData)
        {
            m_Albums = i_CurrentUserData.UserAlbums;
            int countAlbums = 0;
            int countLines = 0;
            int amountOfInfo = 0;

            foreach (Album album in m_Albums)
            {
                int previousAmountOfInfo = amountOfInfo;
                if (i_AlbumInfos.Contains(eAlbumInfo.CoverPhoto))
                {
                    amountOfInfo = 0;
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(130, 140)
                    };
                    pictureBox.Load(album.PictureAlbumURL);
                    pictureBox.Location = new Point(countAlbums * 138, countLines * 145);
                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(pictureBox)));
                }

                Label labelName = new Label
                {
                    Text = "Name:" + album.Name
                };
                if (i_AlbumInfos.Contains(eAlbumInfo.CoverPhoto))
                {
                    labelName.Location = new Point(132 + (140 * countAlbums), countLines * 145);
                }
                else
                {
                    labelName.Location = new Point(140 * countAlbums, amountOfInfo);
                }

                labelName.Size = new Size(140, 15);
                labelName.Click += labelAlbumName_Click;
                i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelName)));
                amountOfInfo += 15;

                if (i_AlbumInfos.Contains(eAlbumInfo.AmountOfLikes))
                {
                    Label labelLikes = new Label
                    {
                        Text = "Amount of likes:" + album.LikedBy.Count(),
                        Size = new Size(140, 15)
                    };
                    if (i_AlbumInfos.Contains(eAlbumInfo.CoverPhoto))
                    {
                        labelLikes.Location = new Point(132 + (140 * countAlbums), amountOfInfo + (countLines * 145));
                    }
                    else
                    {
                        labelLikes.Location = new Point(140 * countAlbums, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelLikes)));
                    amountOfInfo += 15;
                }

                if (i_AlbumInfos.Contains(eAlbumInfo.TimeCreated))
                {
                    Label labelTimeCreated = new Label
                    {
                        Text = "Time Created:" + album.CreatedTime,
                        Size = new Size(140, 15)
                    };
                    if (i_AlbumInfos.Contains(eAlbumInfo.CoverPhoto))
                    {
                        labelTimeCreated.Location = new Point(132 + (140 * countAlbums), amountOfInfo + (countLines * 145));
                    }
                    else
                    {
                        labelTimeCreated.Location = new Point(140 * countAlbums, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelTimeCreated)));
                    amountOfInfo += 15;
                }

                if (i_AlbumInfos.Contains(eAlbumInfo.NumberOfPhotos))
                {
                    Label labelNumberOfPhotos = new Label
                    {
                        Text = "Number Of Photos:" + album.Photos.Count(),
                        Size = new Size(140, 15)
                    };
                    if (i_AlbumInfos.Contains(eAlbumInfo.CoverPhoto))
                    {
                        labelNumberOfPhotos.Location = new Point(132 + (140 * countAlbums), amountOfInfo + (countLines * 145));
                    }
                    else
                    {
                        labelNumberOfPhotos.Location = new Point(140 * countAlbums, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelNumberOfPhotos)));
                    amountOfInfo += 15;
                }

                if (i_AlbumInfos.Contains(eAlbumInfo.LastUpdated))
                {
                    Label labelLastUpdated = new Label
                    {
                        Text = "Last Updated:" + album.UpdateTime,
                        Size = new Size(140, 15)
                    };
                    if (i_AlbumInfos.Contains(eAlbumInfo.CoverPhoto))
                    {
                        labelLastUpdated.Location = new Point(132 + (140 * countAlbums), amountOfInfo + (countLines * 145));
                    }
                    else
                    {
                        labelLastUpdated.Location = new Point(140 * countAlbums, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelLastUpdated)));
                }

                countAlbums += i_AlbumInfos.Contains(eAlbumInfo.CoverPhoto) ? 2 : 1;
                if (i_Panel.Width - (countAlbums * 150) < countAlbums * 150)
                {
                    countLines++;
                    countAlbums = 0;
                    if (!i_AlbumInfos.Contains(eAlbumInfo.CoverPhoto))
                    {
                        previousAmountOfInfo = amountOfInfo + 20;
                    }
                }

                if (!i_AlbumInfos.Contains(eAlbumInfo.CoverPhoto))
                {
                    amountOfInfo = previousAmountOfInfo;
                }
            }
        }

        public void BuildGroupPanel(Panel i_Panel, List<object> i_GroupInfos, FacebookUserData i_CurrentUserData)
        {
            i_Panel.Invoke(new Action(() => i_Panel.Controls.Clear()));
            m_Groups = i_CurrentUserData.UserGroups;
            int countGroups = 0;
            int countLines = 0;
            int amountOfInfo = 0;
            foreach (Group group in m_Groups)
            {
                int previousAmountOfInfo = amountOfInfo;
                if (i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                {
                    amountOfInfo = 0;
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(130, 140)
                    };
                    pictureBox.Load(group.PictureNormalURL);
                    pictureBox.Location = new Point(countGroups * 138, countLines * 145);
                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(pictureBox)));
                }

                Label labelName = new Label
                {
                    Text = "Name:" + group.Name
                };
                if (i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                {
                    labelName.Location = new Point(132 + (140 * countGroups), countLines * 145);
                }

                else
                {
                    labelName.Location = new Point(140 * countGroups, amountOfInfo);
                }

                labelName.Size = new Size(140, 15);
                i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelName)));
                amountOfInfo += 15;
                if (i_GroupInfos.Contains(eGroupInfo.GroupDescription))
                {
                    Label labelDescription = new Label
                    {
                        Text = "Description:" + group.Description,
                        Size = new Size(140, 15)
                    };
                    if (i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                    {
                        labelDescription.Location = new Point(132 + (140 * countGroups), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelDescription.Location = new Point(140 * countGroups, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelDescription)));
                    amountOfInfo += 15;
                }

                if (i_GroupInfos.Contains(eGroupInfo.GroupLastUpdated))
                {
                    Label labelLastUpdated = new Label
                    {
                        Text = "Last Updated:" + group.UpdateTime,
                        Size = new Size(140, 15)
                    };
                    if (i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                    {
                        labelLastUpdated.Location = new Point(132 + (140 * countGroups), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelLastUpdated.Location = new Point(140 * countGroups, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelLastUpdated)));
                    amountOfInfo += 15;
                }

                if (i_GroupInfos.Contains(eGroupInfo.GroupOwner))
                {
                    Label labelGroupOwner = new Label
                    {
                        Text = "Group Owner:" + group.Owner,
                        Size = new Size(140, 15)
                    };
                    if (i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                    {
                        labelGroupOwner.Location = new Point(132 + (140 * countGroups), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelGroupOwner.Location = new Point(140 * countGroups, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelGroupOwner)));
                }

                countGroups += i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto) ? 2 : 1;
                if (i_Panel.Width - (countGroups * 150) < countGroups * 150)
                {
                    countLines++;
                    countGroups = 0;
                    if (!i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                    {
                        previousAmountOfInfo = amountOfInfo + 20;
                    }
                }

                if (!i_GroupInfos.Contains(eGroupInfo.GroupCoverPhoto))
                {
                    amountOfInfo = previousAmountOfInfo;
                }
            }
        }

        public void BuildEventPanel(Panel i_Panel, List<object> i_EventInfo, FacebookUserData i_CurrentUserData)
        {
            i_Panel.Invoke(new Action(() => i_Panel.Controls.Clear()));
            m_Events = i_CurrentUserData.UserEvents;
            int countEvents = 0;
            int countLines = 0;
            int amountOfInfo = 0;
            foreach (Event thisEvent in m_Events)
            {
                int previousAmountOfInfo = amountOfInfo;
                if (i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                {
                    amountOfInfo = 0;
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(130, 140)
                    };
                    pictureBox.LoadAsync(thisEvent.PictureNormalURL);
                    pictureBox.Location = new Point(countEvents * 138, countLines * 145);
                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(pictureBox)));
                }

                Label labelName = new Label
                {
                    Text = "Name:" + thisEvent.Name
                };
                if (i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                {
                    labelName.Location = new Point(132 + (140 * countEvents), countLines * 145);
                }

                else
                {
                    labelName.Location = new Point(140 * countEvents, amountOfInfo);
                }

                labelName.Size = new Size(140, 15);
                i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelName)));
                amountOfInfo += 15;
                if (i_EventInfo.Contains(eEventInfo.EventDescription))
                {
                    Label labelDescription = new Label
                    {
                        Text = "Description:" + thisEvent.Description,
                        Size = new Size(140, 15)
                    };
                    if (i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                    {
                        labelDescription.Location = new Point(132 + (140 * countEvents), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelDescription.Location = new Point(140 * countEvents, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelDescription)));
                    amountOfInfo += 15;
                }

                if (i_EventInfo.Contains(eEventInfo.EventStartTime))
                {
                    Label labelStartTime = new Label
                    {
                        Text = "Start Time:" + thisEvent.StartTime,
                        Size = new Size(140, 15)
                    };
                    if (i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                    {
                        labelStartTime.Location = new Point(132 + (140 * countEvents), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelStartTime.Location = new Point(140 * countEvents, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelStartTime)));
                    amountOfInfo += 15;
                }

                if (i_EventInfo.Contains(eEventInfo.EventEndTime))
                {
                    Label labelEndTime = new Label
                    {
                        Text = "End Time:" + thisEvent.EndTime,
                        Size = new Size(140, 15)
                    };
                    if (i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                    {
                        labelEndTime.Location = new Point(132 + (140 * countEvents), amountOfInfo + (countLines * 145));
                    }

                    else
                    {
                        labelEndTime.Location = new Point(140 * countEvents, amountOfInfo);
                    }

                    i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(labelEndTime)));
                    amountOfInfo += 15;
                }

                countEvents += i_EventInfo.Contains(eEventInfo.EventCoverPhoto) ? 2 : 1;
                if (i_Panel.Width - (countEvents * 150) < countEvents * 150)
                {
                    countLines++;
                    countEvents = 0;
                    if (!i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                    {
                        previousAmountOfInfo = amountOfInfo + 20;
                    }
                }

                if (!i_EventInfo.Contains(eEventInfo.EventCoverPhoto))
                {
                    amountOfInfo = previousAmountOfInfo;
                }
            }
        }

        private void labelAlbumName_Click(object sender, EventArgs e)
        {
            foreach (Album album in m_Albums)
            {
                if (string.Equals((sender as Label)?.Text.Remove(0, 5), album.Name))
                {
                    ShowAlbumName?.Invoke(album);
                    break;
                }
            }
        }
    }
}

using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormImageGallery : Form
    {
        private readonly FacebookObjectCollection<Photo> r_PhotosGallery;
        private int m_PictureNumber;

        public FormImageGallery(FacebookObjectCollection<Photo> i_PhotosGallery)
        {
            InitializeComponent();
            r_PhotosGallery = i_PhotosGallery;
            m_PictureNumber = 0;
            selectedPhotoPictureBox.LoadAsync(r_PhotosGallery[m_PictureNumber].PictureNormalURL);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            if (m_PictureNumber >= 1)
            {
                m_PictureNumber--;
                selectedPhotoPictureBox.LoadAsync(r_PhotosGallery[m_PictureNumber].PictureNormalURL);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (m_PictureNumber < r_PhotosGallery.Count - 1)
            {
                m_PictureNumber++;
                selectedPhotoPictureBox.LoadAsync(r_PhotosGallery[m_PictureNumber].PictureNormalURL);
            }
        }
    }
}
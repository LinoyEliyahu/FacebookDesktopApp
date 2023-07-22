using System.Collections.Generic;
using System.Windows.Forms;
using BasicFacebookFeatures.Command.Interfaces;
using LogicUnit;

namespace BasicFacebookFeatures.Command.BuilderCommands
{
    public class BuildAlbumPanelCommand : ICommandBuildPanel
    {
        private readonly PanelBuilder r_Builder = new PanelBuilder();

        public void Execute(Panel i_Panel, List<object> i_UserInfo, FacebookUserData i_CurrentUserData, PanelBuilder i_PanelBuilder)
        {
            r_Builder.BuildAlbumsPanel(i_Panel, i_UserInfo, i_CurrentUserData);
        }
    }
}

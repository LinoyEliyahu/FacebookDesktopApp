using BasicFacebookFeatures.Command.Interfaces;

namespace BasicFacebookFeatures.Command.BuilderCommands
{
    using LogicUnit;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class BuildGroupPanelCommand : ICommandBuildPanel
    {
        private readonly PanelBuilder r_Builder = new PanelBuilder();

        public void Execute(Panel i_Panel, List<object> i_UserInfo, FacebookUserData i_CurrentUserData, PanelBuilder i_PanelBuilder)
        {
            r_Builder.BuildGroupPanel(i_Panel, i_UserInfo, i_CurrentUserData);
        }
    }
}

using System.Collections.Generic;
using System.Windows.Forms;
using LogicUnit;

namespace BasicFacebookFeatures.Command.Interfaces
{
    public interface ICommandBuildPanel
    {
        void Execute(Panel i_Panel, List<object> i_UserInfo, FacebookUserData i_CurrentUserData, PanelBuilder i_PanelBuilder);
    }
}

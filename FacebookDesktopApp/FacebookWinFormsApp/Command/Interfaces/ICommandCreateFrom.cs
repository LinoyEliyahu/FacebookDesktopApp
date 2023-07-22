using System.Windows.Forms;
using LogicUnit;

namespace BasicFacebookFeatures.Command.Interfaces
{
    public interface ICommandCreateForm
    {
        void Execute(Panel i_Panel, FacebookUserData i_CurrentUserData, PanelBuilder i_Builder);
    }
}

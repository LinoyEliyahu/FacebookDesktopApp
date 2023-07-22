using System.Windows.Forms;
using BasicFacebookFeatures.Command.Interfaces;
using LogicUnit;

namespace BasicFacebookFeatures.Command.FormCommands
{
    public class CreateGroupsFormCommand : ICommandCreateForm
    {
        private readonly FormComposer r_ComposerForm = new FormComposer();

        public void Execute(Panel i_Panel, FacebookUserData i_CurrentUserData, PanelBuilder i_Builder)
        {
            r_ComposerForm.InfoToGet(i_Panel, i_CurrentUserData, i_Builder);
            r_ComposerForm.GroupFormBuilder();
            r_ComposerForm.ShowDialog();
        }
    }
}

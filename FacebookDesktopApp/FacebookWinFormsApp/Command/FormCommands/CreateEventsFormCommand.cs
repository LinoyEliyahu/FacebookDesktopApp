﻿using System.Windows.Forms;
using BasicFacebookFeatures.Command.Interfaces;
using LogicUnit;

namespace BasicFacebookFeatures.Command.FormCommands
{
    public class CreateEventsFormCommand : ICommandCreateForm
    {
        public FormComposer m_ComposerForm = new FormComposer();

        public void Execute(Panel i_Panel, FacebookUserData i_CurrentUserData, PanelBuilder i_Builder)
        {
            m_ComposerForm.InfoToGet(i_Panel, i_CurrentUserData, i_Builder);
            m_ComposerForm.EventsFormBuilder();
            m_ComposerForm.ShowDialog();
        }
    }
}

using Forma1.MyExeception;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma1
{
    public partial class Form1Form : Form
    {

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            string teamName = textBoxTeamName.Text;
            controller.addTeamToF1(teamName);
            listBoxTeam.DataSource = null;
            listBoxTeam.DataSource = controller.getTeamNames();
            textBoxTeamName.Text = string.Empty;
        }

        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            errorProviderDeleteTeam.Clear();
            try
            {
                
                if (listBoxTeam.SelectedIndex < 0)
                {
                    return;

                }
                string teamNameToDelet = listBoxTeam.Text;
                controller.deleteTeam(teamNameToDelet);
                listBoxTeam.DataSource = null;
                listBoxTeam.DataSource = controller.getTeamNames();
            }
            catch (ControllerException ce)
            {
                errorProviderDeleteTeam.SetError(buttonDeleteTeam, ce.Message);

            }
        }
        private void buttonUpdateTeam_Click(object sender, EventArgs e)
        {
            errorProviderModosit.Clear();
            try {
                string oldTeamName = listBoxTeam.Text;
                string newTeamName = textBoxTeamName.Text;

                controller.modiflyTeamName(oldTeamName, newTeamName);
                listBoxTeam.DataSource = null;
                listBoxTeam.DataSource = controller.getTeamNames();
            }
            catch (ControllerException ce) 
            {
                errorProviderModosit.SetError(buttonUpdateTeam, ce.Message);
            }
        }
    }


}

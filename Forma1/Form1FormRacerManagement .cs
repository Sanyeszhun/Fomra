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

        private void buttonAddRacer_Click_1(object sender, EventArgs e)
        {
            errorProviderAddRacer.Clear();
            try {
                string teamName = listBoxTeam.Text;
                string racerName = listBoxRacer.Text;
                string racerAge = textBoxRacerAge.Text;
                string racerSalery = textBoxRacerSalary.Text;
                controller.addRacerToTeam(teamName, racerName, racerAge, racerSalery);
            }
            catch (ControllerException ce) 
            {
                errorProviderAddRacer.SetError(buttonAddRacer, ce.Message);
            }
        }
    
    }


}

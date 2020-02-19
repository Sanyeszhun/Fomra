using Forma1.MyExeception;
using Forma1.service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.controller
{/// <summary>
/// Comtroller reteg kapcsoaltott teremt a GUI és a SERVICE kozott
/// Feladata a bemeno adatok vizsgalata
/// Feladata a megjelenitendo adatok at alakitasa a gui szamara
/// Feldata a programozonak szánt hiba uzenetek megjelenitese
/// 
/// </summary>
    class F1Controller
    {
       

        TeamService teamService;


        public F1Controller() 
        {
            teamService = new TeamService();
        }

        public void addTeamToF1(string teamName)
        {
            try
            {
                teamService.addTeam(teamName);
            }
            catch (TeamServiceExcpetion tse) 
            {
                Debug.WriteLine(tse.Message);
            
            
            }
           
        }
    }
}

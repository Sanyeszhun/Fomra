using Forma1.MyExeception;
using Forma1.Repository;
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
    partial class F1Controller
    {
       

        TeamService teamService;

        public List<string> getTeamNames()
        {
            try
            {
                List<Team> teams = teamService.getTeams();
                return TeamListToTeamNameList(teams);

            }
            catch(TeamServiceExcpetion tse)

            {
                Debug.WriteLine(tse.Message);
                List<string> teamNames = new List<string>();
                return teamNames;

            }
        }

       

        public void deleteTeam(string teamNameToDelet)
        {
            try
            {
                if (!teamService.IsExsist(teamNameToDelet))
                {
                    throw new ControllerException(teamNameToDelet + " csapat nem letezik nemlehet torolni");
                        

                }
                else
                {
                    try
                    {
                        teamService.deleteTeam(teamNameToDelet);
                    }
                    catch (TeamServiceExcpetion tse)
                    {


                        Debug.WriteLine(tse.Message);

                    }
                    catch (TeamServiceToGUIExcpetion tsge)
                    {
                        throw new ControllerException(tsge.Message);
                      

                    }
                }
                
            }
            catch (TeamServiceExcpetion tse)
            {

                Debug.WriteLine(tse.Message);

            }
           
        }

        public void modiflyTeamName(string oldTeamName, string newTeamName)
        {
            try
            {
                if (teamService.IsExsist(newTeamName))
                {
                    throw new ControllerException(newTeamName + "Nevu csapat mar letezik erre a nevre nem lehet modositani");
                    teamService.modilfyTeamName(oldTeamName, newTeamName);
                }
                teamService.modilfyTeamName(oldTeamName, newTeamName);
            }
            catch (TeamServiceExcpetion tse)
            {

                Debug.WriteLine(tse.Message);

            }
        }

        private List<string> TeamListToTeamNameList(List<Team> teams)
        {
            List<string> teamNames = new List<string>();
            foreach (Team t in teams)
            {
                teamNames.Add(t.getTeamName());
           

            }
            return teamNames;
        }

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

using Forma1.MyExeception;
using Forma1.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.service
{
    class TeamService
    { /// <summary>
      /// Servce reteg feladata az uzleti logika megvalositsa
      /// KApcsolatott teremt a Controller es a repsitory retege kozott
      /// 
      /// </summary>
        F1 f1Repository;

        public TeamService()
        {
            f1Repository = new F1();
        
        }

        public void addTeam(string teamName)
        {
            try
            {
                Team t = new Team(teamName);
                f1Repository.add(t);


            }
            catch(F1Exeception f1e) 
            {
                throw new TeamServiceExcpetion(f1e.Message);
            
            
            }
            
        }

        public List<Team> getTeams()
        {
            try
            {
                return f1Repository.getTeams();

            }
            catch (F1Exeception f1e)
            {


                throw new TeamServiceExcpetion(f1e.Message);
            }
        }

        public bool IsExsist(string teamNameToDelet)
        {
            try
            {
                if (f1Repository.IsExsist(teamNameToDelet)) 
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (F1Exeception f1e)
            {
                throw new TeamServiceExcpetion(f1e.Message);
                
            }
        }

        public void deleteTeam(string teamNameToDelet)
        {
            try
            {
                int numberOfTeamRacers = f1Repository.getNumberOfRacers(teamNameToDelet);
                if (numberOfTeamRacers > 0)
                {
                    throw new TeamServiceExcpetion(teamNameToDelet + "Csapatott nem lehet torolni mert vannak meg versenyzoik");
                }
                else 
                {
                    f1Repository.delete(teamNameToDelet);
                
                }
            }
            catch (F1Exeception f1e)
            {

                throw new TeamServiceExcpetion(f1e.Message);
            }
        }
    }
}

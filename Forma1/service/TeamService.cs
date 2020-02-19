using Forma1.MyExeception;
using Forma1.Repository;
using System;
using System.Collections.Generic;
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
    }
}

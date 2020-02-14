using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{/// <summary>
/// F1 csapatok nyilvantarto osztaly
/// </summary>
    class F1
    {
        /// <summary>
        /// f1 csapatok
        /// </summary>
        List<Team> teams;
       /// <summary>
       /// konstruktor
       /// </summary>
        public F1()
        {
            teams = new List<Team>();
                    

        }
        /// <summary>
        /// létre hozz egy uj csapat nevet
        /// </summary>
        /// <param name="name">Az uj csapat neve</param>
        public void add(string name)
        {
            Team t = new Team(name);
            teams.Add(t);



        }
    }
}

﻿using Forma1.MyExeception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{   /// <summary>
/// Az f1 nyilvantarto osztaly
/// 
/// </summary>
    class F1
    {
        /// <summary>
        /// Az F1 csapatok
        /// </summary>
        List<Team> teams;
        /// <summary>
        /// Konstruktor
        /// </summary>
        public F1()
        {
           teams = new List<Team>();
        }

       

        /// <summary>
        /// Létrehozz egy új csapatott az F1-ben
        /// </summary>
        /// <param name="name"> Új csapat neve</param>
        public void add(string name)
        {
            if (teams == null)
            {
                throw new F1Exeception("Végzetes hiba,Team lista nincs peldanyositva");
            }
            else
            {
                Team t = new Team(name);
                teams.Add(t);
            }
        }

        public List<Team> getTeams()
        {
            if (teams == null)
            {
                throw new F1Exeception("Végzetes hiba");
            }else
            {

                return teams;
            }
        }
        /// <summary>
        /// Ellenőrzi hogy a csapat neve letezik e a listaban
        /// </summary>
        /// <param name="teamName">keresett csapat neve</param>
        /// <returns>true ha igen,false ha nem</returns>
         public bool IsExsist(string teamName)
        {
            if (teams == null)
            {
                throw new F1Exeception("Végzetes hiba");
            }
            else 
            {
                foreach (Team t in teams)
                {
                    if (t.getTeamName() == teamName) 
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        internal int getNumberOfRacers(string teamNameToDelet)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// A Teamet hozzáadja a Teamek listajahoz
        /// </summary>
        /// <param name="t"> A listahoz hozzaadot team</param>
        public void add(Team t)
        {
            if (teams == null)
            {
                throw new F1Exeception("Végzetes hiba,Team lista nincs peldanyositva");
            }
            else 
            {
                teams.Add(t);
            }
         
        }
    }
}

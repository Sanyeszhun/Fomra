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

        public void addRacerToTeam(string teamName, string racerName, string racerAge, string racerSalery)
        {
            if (teamName == string.Empty) 
            {
                throw new ControllerException("Elobb hozza letrea csapatott utana adja hozza a versenyzoket!");
                
            }
            int newRacerAge = 0;
            if (int.TryParse(racerAge,out newRacerAge))
                {
                throw new ControllerException("A versenyzo eletkora nem megfelelo");
                }
            if (newRacerAge <= 0) 
            {
                throw new ControllerException("A versenyzo eletkora nem lehet nulla vagy negativ");
            }


            int newRacerSalery = 0;
            if (int.TryParse(racerSalery, out newRacerSalery))
            {
                throw new ControllerException("A versenyzo fizetese nem megfelelo");
            }
            if (newRacerSalery <= 0)
            {
                throw new ControllerException("A versenyzo fizetese nem lehet nulla vagy negativ");
            }
        }


    }
}

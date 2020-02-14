using Forma1.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{/// <summary>
/// A Forma 1-ben szereplo csapat
/// </summary>
    class Team
    { /// <summary>
      /// Versenyzo neve
      /// </summary>
        private string name;

        /// <summary>
        /// Racer Lista elkeszitese
        /// </summary>
        /// 
        List<Racer> racers;


        /// <summary>
        /// Versenyzo neve
        /// </summary>
        public Team(string name)
        {

            this.name = name;
            racers = new List<Racer>();
        }


    }
}

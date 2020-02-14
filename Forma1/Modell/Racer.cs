using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Modell
{/// <summary>
/// A versenyzo osztaly
/// 
/// </summary>
    class Racer
    {/// <summary>
    /// A verseyzo osztaly adat tagjai
    /// </summary>
        private string name;
        private int age;
        private int salery;

        /// <summary>
        ///  ures konstruktor lehetetlen adatokal
        /// </summary>
        public Racer() 
        {
            name = string.Empty;
            age = 1;
            salery = -1;
        
                
                
         }
        /// <summary>
        /// Teljes konstruktor 
        /// </summary>
        /// <param name="name">Versenyzo neve</param>
        /// <param name="age">A versenyzo eletkora</param>
        /// <param name="salery">A versenyzo fizetese</param>
        public Racer(string name, int age, int salery)
        {
            this.name = name;
            this.age = age;
            this.salery = salery;
        }
        /// <summary>
        /// Versenyzo nevenek megadasa
        /// </summary>
        /// <param name="name">A versenyzo neve</param>
        public void setName(string name) 
        {
            this.name = name;
        }
        /// <summary>
        /// A versenyzo koranak megadasa
        /// </summary>
        /// <param name="age">A versenyzo eletkora</param>
        public void setAge(int age) 
        {
            this.age = age;
        
        }
        /// <summary>
        /// A versenyzo fiztetésének megadasa
        /// </summary>
        /// <param name="salery">A versenyzo fizetese</param>
        public void setSalery(int salery) 
        {
            this.salery = salery;
        }
        /// <summary>
        /// A versenyzo nevet adja vissza
        /// </summary>
        /// <returns>A versenyzo neve</returns>
        public string getName() 
        {
            return name;
        }
        /// <summary>
        /// A versenyzo korat adja vissza
        /// </summary>
        /// <returns>A versenyzo kora</returns>
        public int getAge()
        {
            return age;
        }
        /// <summary>
        /// A versenyzo fizeteset adja vissza
        /// </summary>
        /// <returns>A versenyzo fizetese</returns>
        public int getSalery()
        {
            return salery;
        }
    }
}

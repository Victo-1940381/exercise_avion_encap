using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio_classe_avion
{
    /// <summary>
    /// classe que représent un siège de l'avion
    /// </summary>
    public class Siege : Passagers
    {
       private string _classe;
        /// <summary>
        /// contructeur d'un siege
        /// </summary>
        /// <param name="classe">la classe de son siège</param>
        public Siege(string classe,string nom,int numéro_siege,char lettre_siege) : base(nom, numéro_siege, lettre_siege)
        {
            this._classe = classe;
        }
    }
}

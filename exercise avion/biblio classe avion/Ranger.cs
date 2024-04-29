using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio_classe_avion
{

    /// <summary>
    /// représente une ranger de section de siege
    /// </summary>
    public class Ranger : Section
    {    
       
        /// <summary>
        /// constructeur d'une ranger
        /// </summary>
        /// <param name="classe">la classe du siege</param>
        /// <param name="lettre_siege_section">la lettre du siege</param>
        /// <param name="num_siege">le numero du siège</param>
        public Ranger(string classe, string nom, int numéro_siege, char lettre_siege) : base(classe,nom, numéro_siege, lettre_siege)
        {
            
        }
    }
}

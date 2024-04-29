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
        private int _num_siege;
        /// <summary>
        /// constructeur d'une ranger
        /// </summary>
        /// <param name="classe">la classe du siege</param>
        /// <param name="lettre_siege_section">la lettre du siege</param>
        /// <param name="num_siege">le numero du siège</param>
        public Ranger(string classe,char lettre_siege_section,int num_siege) : base(classe,lettre_siege_section)
        {
            this._num_siege = num_siege;
        }
    }
}

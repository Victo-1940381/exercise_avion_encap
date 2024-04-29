using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio_classe_avion
{
    /// <summary>
    /// represente un section de sieges
    /// </summary>
    public class Section : Siège
    {
        private char _lettre_siege_section;
        /// <summary>
        /// constructeur d'une sect
        /// </summary>
        /// <param name="classe">la classe du siège</param>
        public Section(string classe,char lettre_siege_section) : base(classe)
        {
            this._lettre_siege_section = lettre_siege_section;
        }
    }
}

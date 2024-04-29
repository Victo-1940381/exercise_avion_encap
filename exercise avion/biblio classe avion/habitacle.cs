using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio_classe_avion
{
    /// <summary>
    /// représente un habitacle d'un avion avec tout les siege
    /// </summary>
    public class habitacle : Ranger
    {
        /// <summary>
        /// constrcuteur d'un habitacle
        /// </summary>
        /// <param name="classe">la classe d'un siege</param>
        /// <param name="lettre_siege_section">la lettre d'un siege</param>
        /// <param name="num_siege">le numero du siege</param>
        public habitacle(string classe, char lettre_siege_section, int num_siege) : base(classe, lettre_siege_section, num_siege)
        {
        }
    }
}

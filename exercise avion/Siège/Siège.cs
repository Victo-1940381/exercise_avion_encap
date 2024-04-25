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
    public class Siège
    {
       private string classe;
        /// <summary>
        /// contructeur d'un siege
        /// </summary>
        /// <param name="classe">la classe de son siège</param>
        public Siège(string classe)
        {
            this.classe = classe;
        }
    }
}

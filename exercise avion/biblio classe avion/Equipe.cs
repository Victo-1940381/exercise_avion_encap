using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio_classe_avion
{
    /// <summary>
    /// représente une équipe employer a bord d'un avion
    /// </summary>
    public class Equipe
    {
        private string pilote;
        private string copilote;
        private string premier_agent;
        private string deuxième_agent;
        private string trosième_agent;
        /// <summary>
        /// constructeur d'un équipe 
        /// </summary>
        /// <param name="pilote">le pilote</param>
        /// <param name="copilote">le copilote</param>
        /// <param name="premier_agent">le premier agent de bord</param>
        /// <param name="deuxième_agent">le deuxieme agend de bord</param>
        /// <param name="trosième_agent">le trosième agent de bord</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Equipe(string pilote, string copilote, string premier_agent, string deuxième_agent, string trosième_agent)
        {
            this.pilote = pilote ?? throw new ArgumentNullException(nameof(pilote));
            this.copilote = copilote ?? throw new ArgumentNullException(nameof(copilote));
            this.premier_agent = premier_agent ?? throw new ArgumentNullException(nameof(premier_agent));
            this.deuxième_agent = deuxième_agent ?? throw new ArgumentNullException(nameof(deuxième_agent));
            this.trosième_agent = trosième_agent ?? throw new ArgumentNullException(nameof(trosième_agent));
        }
    }
}

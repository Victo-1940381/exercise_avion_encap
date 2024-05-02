using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio_classe_avion
{

    /// <summary>
    /// représente un avion
    /// </summary>
    public class Avion : Habitacle
    {

        /// <summary>
        /// contructeur d'un avion
        /// </summary>
        public Avion(string classe, string nom, int numéro_siege, char lettre_siege) : base(classe, nom, numéro_siege, lettre_siege)
        {
        }
       
    }
    public void ajouterpassager(Passagers)
    {
       Stack <Passagers> passagersiege = new Stack<Passagers>();
        passagersiege.Push(Passagers);
    }
}

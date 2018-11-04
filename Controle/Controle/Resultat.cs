using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle
{
    class Resultat
    {
        Participant unParticipant;
        Epreuve uneEpreuve;
        int tempsRealise;

        public Resultat(Participant unParticipant, Epreuve uneEpreuve , int tempsRealise){
            this.unParticipant = unParticipant;
            this.uneEpreuve = uneEpreuve;
            this.tempsRealise = tempsRealise;

        }
        public Epreuve GetEpreuve()
        {
            return this.uneEpreuve;
        }
        public int GetTempsRealise() 
        {
            return this.tempsRealise;
        }
    }
}

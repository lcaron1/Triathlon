using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle
{
    class Participant
    {
        int id;
        string nom;
        DateTime dateInscription;
        List<Resultat> lesResultats;
        int lastId;
        
        
        public Participant(string nom, DateTime dateinscription)
        {
            this.nom = nom;
            this.dateInscription = dateinscription;
            lesResultats = new List<Resultat>();
            this.id = lastId;
            lastId = lastId +1;

        }
        public int GetId()
        {
            return this.id;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public DateTime GetDateInscription()
        {
            return this.dateInscription;

        }


        private bool ResultatPresent(Epreuve uneEpreuve)
        {
           for(int i= 0; i < lesResultats.Count; i++)
            {
                if (lesResultats[i].GetEpreuve().GetNom() == uneEpreuve.GetNom())
                {
                    return true;
                }
            }
            return false;
        }
        public void Add(Epreuve uneEpreuve, int tempsRealise)
        {
            Resultat unResultat;
            if (this.ResultatPresent(uneEpreuve) == false)
            {
                unResultat = new Resultat(this, uneEpreuve, tempsRealise);
                this.lesResultats.Add(unResultat);

            }
            
        }
        public int GetTempsTotal()
        {
            int tempsTotal = 0;
            for (int i = 0; i < lesResultats.Count; i++)
            {
                tempsTotal = tempsTotal + lesResultats[i].GetTempsRealise();
            }
            return tempsTotal;
        }
        public bool HorsDelai()
        {
            int EpreuveValider = 0;
            for (int i = 0; i < lesResultats.Count; i++)
            {
                if (lesResultats[i].GetEpreuve().GetNom() != "Natation")
                {
                    if (lesResultats[i].GetTempsRealise < lesResultats[i].GetEpreuve().GetTempsEliminatoire())
                    {
                        EpreuveValider = EpreuveValider +1;
                    }
                }
                if (EpreuveValider == 2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

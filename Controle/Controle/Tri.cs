using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle
{
    class Tri
    {
        string nature;
        Epreuve natation;
        Epreuve velo;
        Epreuve course;
        List<Participant> lesParticipants;

        public Tri(string nature, int distanceNatation, int distanceVelo, int distanceCourse)
        {
            this.nature = nature;
            this.natation = new Epreuve("Natation", distanceNatation);
            this.velo = new Epreuve("Velo", distanceVelo);
            this.course = new Epreuve("course", distanceCourse);
            this.lesParticipants = new List<Participant>();
        }
        public string GetNature()
        {
            return this.nature;
        }

        public void AddParticipant(Participant unParticipant)
        {
            this.lesParticipants.Add(unParticipant);

        }
        public Epreuve GetEpreuve(string nomEpreuve)
        {
            switch (nomEpreuve)
            {
                case "natation":
                    return this.natation;
                case "velo":
                    return this.velo;
                default:
                    return this.course;
            }
        }
        public Participant GetParticipantById(int id)
        {
            Participant unParticipant;
            for (int i = 0; i < lesParticipants.Count; i++)
            {
                if (lesParticipants[i].GetId() == id)
                {
                    unParticipant = lesParticipants[i];
                    return unParticipant;
                }
            }
                return null;
            }
        public int GetDistanceTotale()
        {
            int distanceTotal;
            distanceTotal = natation.GetDistance() + velo.GetDistance() + course.GetDistance();
            return distanceTotal;

            
        }
        public List<Participant> GetLesTemps()
        {
            List<Participant> EnCours = new List<Participant>();
            foreach (Participant unParticipant in lesParticipants)
            {
                if(unParticipant.HorsDelai() == false)
                {
                    EnCours.Add(unParticipant);
                }
            }
            return EnCours;
        }
    }
}

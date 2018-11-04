using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle
{
    class Program
    {
        static void Main(string[] args)
        {

            Participant participant1 = new Participant("loic", DateTime.Now);
            Epreuve epreuve1 = new Epreuve("Course", 50);
            Epreuve epreuve2 = new Epreuve("Natation", 200);
            Epreuve epreuve3 = new Epreuve("Velo", 300);

            epreuve2.SetTempsEliminatoire(15);
            epreuve3.SetTempsEliminatoire(360);
            participant1.Add(epreuve1, 11);
            participant1.Add(epreuve2, 13);
            participant1.Add(epreuve3, 249);



            Console.WriteLine("Nom de l'épreuve : {0}", epreuve1.GetNom());
            Console.WriteLine("Distance : {0}", epreuve1.GetDistance());
            Console.WriteLine("Temps éliminatoire : {0}", epreuve1.GetTempsEliminatoire());
            Console.WriteLine();

            Console.WriteLine("Nom de l'épreuve : {0}", epreuve2.GetNom());
            Console.WriteLine("Distance : {0}", epreuve2.GetDistance());
            Console.WriteLine("Temps éliminatoire : {0}", epreuve2.GetTempsEliminatoire());
            Console.WriteLine();

            Console.WriteLine("Nom de l'épreuve : {0}", epreuve3.GetNom());
            Console.WriteLine("Distance : {0}", epreuve3.GetDistance());
            Console.WriteLine("Temps éliminatoire : {0}", epreuve3.GetTempsEliminatoire());
            Console.WriteLine();

            Console.WriteLine("Nom du participant: {0} \n ID du participant: {1} \n Date de l'inscription {2}", participant1.GetNom(), participant1.GetId(), participant1.GetDateInscription());
            Console.WriteLine();

            Console.WriteLine("Son temps total est de: {0}", participant1.GetTempsTotal());
            if (participant1.HorsDelai() == true)
            {
                Console.Write("Son Temps total est hors delai ");
            }
            else
            {
                Console.Write("Son temps total est dans les delais ");
            }

            Console.ReadLine();
        }
    }
}

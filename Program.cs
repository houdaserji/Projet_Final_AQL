/*****************************
 *********Classe Cours*********
 *****************************/

using System;
using System.Collections.Generic;
using System.Text;


namespace Projet_final_Jacob_Arcand
{
    public class Cours
    {
        public string Numero_cours { get; set; }
        public string Code { get; set; }
        public string Titre { get; set; }
    }

}

    /*****************************
    *************Main*************
    *****************************/

    namespace Projet_final_Jacob_Arcand
    {
        class Program
        {
            static void Main(string[] args)
            {
                string FichierText = @"C:\Users\Jack\Desktop\Projet_Final_AQL-Jacob-Arcand\Cours.txt";

            List<Cours> cours = new List<Cours>();
            List<string> linges = File.ReadAllLines(FichierText).ToList();

            foreach(var line in linges)
            {
                string[] entres = line.Split(',');

                Cours nouveauCours = new Cours();

                nouveauCours.Numero_cours = entres[0];
                nouveauCours.Code = entres[1];
                nouveauCours.Titre = entres[2];

                cours.Add(nouveauCours);
            }

            foreach (var courss in cours)
            {
                Console.WriteLine($"{courss.Numero_cours} {courss.Code} {courss.Titre}");
            }
            Console.ReadLine();
            }
        }
    }

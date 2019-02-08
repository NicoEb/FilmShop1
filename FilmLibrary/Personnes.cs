using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary
{
   public class Personnes
    {
        private string NomPersonnes;
        private string Prenom;
        private DateTime DateDeNaissance;
        private string Adresse;
        private string Ville;
        private int CodePostal;
        private int Taille;
        private int Poid;
       
        private string Nomcomplet;

        public string NomPersonnes1 { get => NomPersonnes; set => NomPersonnes = value; }
        public string Prenom1 { get => Prenom; set => Prenom = value; }
        public DateTime DateDeNaissance1 { get => DateDeNaissance; set => DateDeNaissance = value; }
        public string Adresse1 { get => Adresse; set => Adresse = value; }
        public string Ville1 { get => Ville; set => Ville = value; }
        public int CodePostal1 { get => CodePostal; set => CodePostal = value; }
        public int Taille1 { get => Taille; set => Taille = value; }
        public int Poid1 { get => Poid; set => Poid = value; }
        
        public string Nomcomplet1 { get => NomPersonnes1 + " " + Prenom1; }

        public Personnes(string nomcomplet)
        {
            Nomcomplet = nomcomplet;
        }

        public Personnes()
        {
        }

        public Personnes(string nomPersonnes1, string prenom1, DateTime dateDeNaissance1, string adresse1, string ville1, int codePostal1, int taille1, int poid1)
        {
            NomPersonnes1 = nomPersonnes1;
            Prenom1 = prenom1;
            DateDeNaissance1 = dateDeNaissance1;
            Adresse1 = adresse1;
            Ville1 = ville1;
            CodePostal1 = codePostal1;
            Taille1 = taille1;
            Poid1 = poid1;
           
        }

        public int Age
        {
            get
            {

                int age = DateTime.Now.Year - DateDeNaissance.Year;
                DateTime dateAnniversaire =
                    new DateTime(
                        DateTime.Now.Year,
                        DateDeNaissance.Month,
                        DateDeNaissance.Day);

                if (dateAnniversaire >= DateTime.Now)
                {
                    age--;
                }

                return age;
            }
        }

        public static String SePresenter(Personnes p)
        {
            String presentation = "Bonjour je m'appelle " + p.Nomcomplet1 + ". J'ai " + p.Age + "ans. J'habite à " + p.Ville1;

            return presentation;
        }

        
    }

    
}

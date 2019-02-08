using System;
using System.Collections.Generic;

namespace FilmLibrary
{
    public class Films
    {
        
        private string TitreFilm;
        private string RealisateurFilm;
        private DateTime DateDeSortie;
        private string ResumeFilm;
        private string GenreFilm;
        private int DureeFilm;
        private List<int> ListeFilm = new List<int>();


        public string TitreFilm1 { get => TitreFilm; set => TitreFilm = value; }
        public string RealisateurFilm1 { get => RealisateurFilm; set => RealisateurFilm = value; }
        public DateTime DateDeSortie1 { get => DateDeSortie; set => DateDeSortie = value; }
        public string ResumeFilm1 { get => ResumeFilm; set => ResumeFilm = value; }
        public string GenreFilm1 { get => GenreFilm; set => GenreFilm = value; }
        public int DureeFilm1 { get => DureeFilm; set => DureeFilm = value; }
        public List<int> ListeFilm1 { get => ListeFilm; set => ListeFilm = value; }

        public Films()
        {
        }

        public Films(string titreFilm1, string realisateurFilm1, DateTime dateDeSortie1, string resumeFilm1, string genreFilm1, int dureeFilm1)
        {
            TitreFilm1 = titreFilm1;
            RealisateurFilm1 = realisateurFilm1;
            DateDeSortie1 = dateDeSortie1;
            ResumeFilm1 = resumeFilm1;
            GenreFilm1 = genreFilm1;
            DureeFilm1 = dureeFilm1;
        }

        public Films(List<int> listeFilm1)
        {
            ListeFilm1 = listeFilm1;
        }
    }
}

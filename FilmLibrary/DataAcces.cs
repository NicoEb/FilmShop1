using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using FilmLibrary;






namespace FilmLibrary
{
    class DataAcces
    {
        static string SqlConnectionString = @"Server=.\SQLExpress;Database=FilmShopBDD;Trusted_Connection=Yes";

        public static void Addfilm(Films films)
        {
            using (SqlConnection db =
                new SqlConnection(SqlConnectionString))
            {
                db.Open();

                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = db;


                insertCommand.CommandText = "INSERT INTO Films(Titre,Realisateur,DateDeSortie,Resume,Genre,DureeEnMinute) VALUES (@titre,@realisateur,@dateDeSortie,@résume,@genre,@duree);";
                insertCommand.Parameters.AddWithValue("@titre", films.TitreFilm1);
                insertCommand.Parameters.AddWithValue("@realisateur", films.RealisateurFilm1);
                insertCommand.Parameters.AddWithValue("@DateDeSortie", films.DateDeSortie1);
                insertCommand.Parameters.AddWithValue("@résume", films.ResumeFilm1);
                insertCommand.Parameters.AddWithValue("@genre", films.GenreFilm1);
                insertCommand.Parameters.AddWithValue("@duree", films.DureeFilm1);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }

        public static void AddPersonnes(Personnes personnes)
        {
            using (SqlConnection db =
                new SqlConnection(SqlConnectionString))
            {
                db.Open();

                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = db;


                insertCommand.CommandText = "INSERT INTO Personnes(Nom,Prenom,DateDeNaissance,Adresse,Ville,CodePostal) VALUES (@nom,@prenom,@datedeNaissance,@adresse,@ville,@codePostal);";
                insertCommand.Parameters.AddWithValue("@nom", personnes.NomPersonnes1);
                insertCommand.Parameters.AddWithValue("@prenom", personnes.Prenom1);
                insertCommand.Parameters.AddWithValue("@DatedeNaissance", personnes.DateDeNaissance1);
                insertCommand.Parameters.AddWithValue("@adresse", personnes.Adresse1);
                insertCommand.Parameters.AddWithValue("@ville", personnes.Ville1);
                insertCommand.Parameters.AddWithValue("@codePostal", personnes.CodePostal1);

                insertCommand.ExecuteReader();

                db.Close();
            }
        }


        public static List<String> GetAllFilms()
        {
            List<String> Films = new List<string>();

            using (SqlConnection db =
                new SqlConnection(SqlConnectionString))
            {
                db.Open();

                SqlCommand selectCommand = new SqlCommand
                    ("SELECT * from Films", db);

                SqlDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    Films.Add(query.GetString(0));
                }

                db.Close();
            }

            return Films;
        }

        public static List<String> GetAllPersonnes()
        {
            List<String> Personnes = new List<string>();

            using (SqlConnection db =
                new SqlConnection(SqlConnectionString))
            {
                db.Open();

                SqlCommand selectCommand = new SqlCommand
                    ("SELECT * from Personnes", db);

                SqlDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    Personnes.Add(query.GetString(0));
                }

                db.Close();
            }

            return Personnes;
        }
    }
}

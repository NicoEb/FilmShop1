using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmLibrary;

namespace TestFilm
{
    [TestClass]
    public class UnitTest1
    {
        
       
        [TestMethod]
        public void LeNomEstPasVide()
        {
            var nom = new Personnes ();
            Assert.ThrowsException<ArgumentException>(
                () => nom.NomPersonnes1 = ""
                );
        }

        [TestMethod]
        public void LePrenomEstPasVide()
        {
            var prenom = new Personnes();
            Assert.ThrowsException<ArgumentException>(
                () => prenom.Prenom1 = ""
                );
        }
        [TestMethod]
        public void LeNomNeDoitPasContenirDesChiffre()
        {
            var personnes = new Personnes();
            personnes.NomPersonnes1 = "123456";

            Assert.AreEqual("123456", personnes.NomPersonnes1);
        }

        [TestMethod]
        public void LetitreNeDoitPascommencerParUnChiffre()
        {
            var Titre = new Films();
            Assert.ThrowsException<ArgumentException>(
                () => Titre.TitreFilm1 = "1Test"
                );
        }

        [TestMethod]
        public void LeRéalisateurNeDoitPascommencerParUnChiffre()
        {
            var real = new Films();
            Assert.ThrowsException<ArgumentException>(
                () => real.RealisateurFilm1 = "1Test"
                );
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseurRomain;

namespace TestParseurRomain
{
    [TestClass]
    public class TestParametreChiffreRomain
    {
        [TestMethod]
        public void TestParametre_Null_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier(null);

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_ChaineVide_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier(string.Empty);

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_Chiffre_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("12354");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_ChiffreEtCaracteres_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("123MLP54");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_CaracteresNonRomain_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("ABC");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_CaracteresSpecial_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("!MLP");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_TextAvecEspace_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("!ML   P");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_TextMiniscule_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("abc");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_TextAvec5foisM_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("MMMMMM");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_TextAvec4foisI_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("IIII");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_TextAvec4foisV_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("VVVV");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_TextAvec4foisX_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("XXXX");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_TextAvec4foisL_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("LLLL");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_TextAvec4foisC_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("CCCC");

            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod]
        public void TestParametre_TextAvec4foisD_Retourne_0_Erreur()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("DDDD");

            //Assert
            Assert.AreEqual(0, resultat);
        }
    }
}

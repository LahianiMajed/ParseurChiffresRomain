using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseurRomain;

namespace TestParseurRomain
{
    [TestClass]
    public class TestParseurChiffreRomain
    {
        [TestMethod]
        public void ParseurRomain_I_Retourne_1()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("I");

            //Assert
            Assert.AreEqual(1, resultat);
        }

        [TestMethod]
        public void ParseurRomain_II_Retourne_2()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("II");

            //Assert
            Assert.AreEqual(2, resultat);
        }

        [TestMethod]
        public void ParseurRomain_III_Retourne_3()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("III");

            //Assert
            Assert.AreEqual(3, resultat);
        }

        [TestMethod]
        public void ParseurRomain_IV_Retourne_4()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("IV");

            //Assert
            Assert.AreEqual(4, resultat);
        }

        [TestMethod]
        public void ParseurRomain_V_Retourne_5()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("V");

            //Assert
            Assert.AreEqual(5, resultat);
        }

        [TestMethod]
        public void ParseurRomain_VI_Retourne_6()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("VI");

            //Assert
            Assert.AreEqual(6, resultat);
        }

        [TestMethod]
        public void ParseurRomain_VII_Retourne_7()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("VII");

            //Assert
            Assert.AreEqual(7, resultat);
        }

        [TestMethod]
        public void ParseurRomain_VII_Retourne_8()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("VIII");

            //Assert
            Assert.AreEqual(8, resultat);
        }

        [TestMethod]
        public void ParseurRomain_IX_Retourne_9()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("IX");

            //Assert
            Assert.AreEqual(9, resultat);
        }

        [TestMethod]
        public void ParseurRomain_X_Retourne_10()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("X");

            //Assert
            Assert.AreEqual(10, resultat);
        }

        [TestMethod]
        public void ParseurRomain_L_Retourne_50()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("L");

            //Assert
            Assert.AreEqual(50, resultat);
        }

        [TestMethod]
        public void ParseurRomain_C_Retourne_100()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("C");

            //Assert
            Assert.AreEqual(100, resultat);
        }

        [TestMethod]
        public void ParseurRomain_D_Retourne_500()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("D");

            //Assert
            Assert.AreEqual(500, resultat);
        }

        [TestMethod]
        public void ParseurRomain_M_Retourne_1000()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("D");

            //Assert
            Assert.AreEqual(500, resultat);
        }

        [TestMethod]
        public void ParseurRomain_XI_Retourne_11()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("XI");

            //Assert
            Assert.AreEqual(11, resultat);
        }

        [TestMethod]
        public void ParseurRomain_XX_Retourne_20()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("XX");

            //Assert
            Assert.AreEqual(20, resultat);
        }

        [TestMethod]
        public void ParseurRomain_CX_Retourne_110()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("CX");

            //Assert
            Assert.AreEqual(110, resultat);
        }

        [TestMethod]
        public void ParseurRomain_DIX_Retourne_509()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("DIX");

            //Assert
            Assert.AreEqual(509, resultat);
        }

        [TestMethod]
        public void ParseurRomain_DCLXVI_Retourne_666()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("DCLXVI");

            //Assert
            Assert.AreEqual(666, resultat);
        }

        [TestMethod]
        public void ParseurRomain_MMXX_Retourne_2020()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("MMXX");

            //Assert
            Assert.AreEqual(2020, resultat);
        }

        [TestMethod]
        public void ParseurRomain_MMD_Retourne_2500()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("MMD");

            //Assert
            Assert.AreEqual(2500, resultat);
        }

        [TestMethod]
        public void ParseurRomain_MMMDXX_Retourne_3520()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("MMMDXX");

            //Assert
            Assert.AreEqual(3520, resultat);
        }

        [TestMethod]
        public void ParseurRomain_MMMCMXCIX_Retourne_3999()
        {
            //Arrange
            ParseurChiffreRomain parseurChiffreRomain = new ParseurChiffreRomain();

            //Act
            int? resultat = parseurChiffreRomain.ParseurChiffreRomainEntier("MMMCMXCIX");

            //Assert
            Assert.AreEqual(3999, resultat);
        }
    }
}

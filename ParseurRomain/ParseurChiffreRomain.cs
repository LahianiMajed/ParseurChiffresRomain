using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ParseurRomain
{
    public class ParseurChiffreRomain
    {
        /// <summary>
        /// Dictionnaire du Chiffre Romain.
        /// </summary>
        private readonly Dictionary<char, int> DictionnaireChiffreRomain = new Dictionary<char, int>
        {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
        };

        /// <summary>
        /// Verification du chiffre romain.
        /// </summary>
        /// <param name="strChiffreRomain">Chaine de caractere chiffre romain.</param>
        /// <returns>resultat true/false.</returns>
        private bool VerificationChiffreRomain(string strChiffreRomain)
        {
            //Erreur si le parametre est null ou vide.
            if (string.IsNullOrEmpty(strChiffreRomain))
            {
                return false;
            }

            //Erreur si le parametre d'entre est correcte.
            string pattern = @"(^(?=[MDCLXVI])(M{0,4})(C[MD]|D?C{0,3})(X[CL]|L?X{0,3})(I[XV]|V?I{0,3})$)";
            if (!Regex.IsMatch(strChiffreRomain,pattern))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Convertir le texte roamin en chiffre.
        /// </summary>
        /// <param name="strChiffreRomain">Chaine de caractere chiffre romain.</param>
        /// <returns>Resultat entier (0 si erreur).</returns>
        public int ParseurChiffreRomainEntier(string strChiffreRomain)
        {
            if (!VerificationChiffreRomain(strChiffreRomain))
            {
                return 0;
            }

            int total = 0;
            int valeurLettre = 0;

            for (int i = 0; i < strChiffreRomain.Length; i++)
            {
                valeurLettre = DictionnaireChiffreRomain[strChiffreRomain[i]];

                if (i == strChiffreRomain.Length - 1)
                {
                    break;
                }

                if (valeurLettre < DictionnaireChiffreRomain[strChiffreRomain[i + 1]])
                {
                    total = total - valeurLettre;
                }
                else
                {
                    total = total + valeurLettre;
                }
            }

            return total + valeurLettre;
        }
    }
}

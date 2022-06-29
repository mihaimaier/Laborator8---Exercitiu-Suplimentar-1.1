using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator8___Exercitiu_Suplimentar_1._1
{
    class Magazin
    {
        List<Telefon> telefoaneParola = new List<Telefon>();

        public void AdaugaParola(Telefon parolaTelefon)
        {
            this.telefoaneParola.Add(parolaTelefon);
        }

        public void DeblocheazaTelefoane()
        {
            foreach(Telefon parolaVeche in telefoaneParola)
            {
                Telefon telefon = parolaVeche as Telefon;
                telefon.SchimbareParola();
            }
        }

        public void CumparareTelefon()
        {
            string faraParola = string.Empty;
            string parola;
            Console.WriteLine("Ati dori sa cumparati un telefon? Raspundeti Da sau Nu");
            if(Console.ReadLine() == "Da")
            {
                Console.WriteLine("Ati cumparat un telefon cu success! Parola telefonului este: ***No Password***{0}", faraParola);
                Console.WriteLine("Introduceti o parola!");
                parola = Console.ReadLine();
                Console.WriteLine("Ati introdus o parola la telefon cu success!");
            }
            else
            {
                Console.WriteLine("Sa aveti o zi frumoasa! Va mai asteptam!");
                Environment.Exit(0);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator8___Exercitiu_Suplimentar_1._1
{
    class Telefon : Magazin
    {
        private string parolaTelefon;
        public Telefon(string parolaTelefon)
        {
            this.parolaTelefon = parolaTelefon;
        }

        public void Deblocheaza()
        {
            string parola;
            string faraParola = string.Empty;
            Console.WriteLine("Introduceti o parola");
            parola = Console.ReadLine();
            if (parola == this.parolaTelefon || parola == faraParola)
            {
                Console.WriteLine("Telefonul este deblocat!");
            }
            else
            {
                Console.WriteLine("Telefonul este blocat!");
            }
        }
        public void SchimbareParola()
        {
            string parolaVeche;
            string parolaNoua;
            Console.WriteLine("Introduceti parola veche!");
            parolaVeche = Console.ReadLine();
            Console.WriteLine("Introduceti parola noua");
            parolaNoua = Console.ReadLine();

            if (parolaVeche == this.parolaTelefon)
            {
                Console.WriteLine("Parola a fost schimbata cu success!");
            }
            else
            {
                Console.WriteLine("Ati introdus parola veche gresita!");
            }
        }
        public void DeblocheazaTelefon()
        {
            string faraParola = string.Empty;
            string parola;
            Console.WriteLine("Introduceti o parola");
            parola = Console.ReadLine();

            if (parola == this.parolaTelefon || parola == faraParola)
            {
                Console.WriteLine("Telefonul a fost deblocat");
            }
        }
        public void BlocheazaTelefon()
        {
            string parola;
            Console.WriteLine("Introduceti o parola");
            parola = Console.ReadLine();
            if (parola != this.parolaTelefon)
            {
                Console.WriteLine("Telefonul a fost blocat!");
            }
        }
        public void Apealeaza()
        {

            string parola;
            Console.WriteLine("Introduceti o parola!");
            parola = Console.ReadLine();
            int numarTelefon;
            Console.WriteLine("Introduceti un Numar de Telefon!");
            numarTelefon = int.Parse(Console.ReadLine());

            if(parola == this.parolaTelefon)
            {
                Console.WriteLine("Parola introdusa a fost corecta!");
                Console.WriteLine($"Apelul a fost efectuat! Calling {numarTelefon}");
            }
            else
            {
                Console.WriteLine("Apelul nu a fost putut prelua! Va rog introduceti parola corecta sa deblocati telefonul");
            }
        }
    }
}
using System;

namespace Laborator8___Exercitiu_Suplimentar_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon1 = new Telefon("Romania");
            telefon1.Deblocheaza();
            telefon1.SchimbareParola();
            telefon1.DeblocheazaTelefon();
            telefon1.BlocheazaTelefon();
            telefon1.Apealeaza();

            Telefon telefoane2 = new Telefon("Norvegia");
            telefoane2.AdaugaParola(new Telefon("America"));
            telefoane2.DeblocheazaTelefoane();
            telefoane2.CumparareTelefon();

        }
    }
}

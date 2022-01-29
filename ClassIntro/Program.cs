using System;

namespace ClassIntro // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "Enes";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Enes";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Berkay";
            kurs2.IzlenmeOrani = 55;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Engin";
            kurs3.IzlenmeOrani = 70;

            //Console.WriteLine(kurs1.Egitmen + " : " + kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

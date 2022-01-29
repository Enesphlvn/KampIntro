using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, boolean, double = değer tip
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            //array, class, interface = referans tip
            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] {100,200,300};
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
        }
    }
}

using System;

namespace diziOrnegiElifDemir
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("Dizinin " + (i + 1) + ". elemanını giriniz: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nDizi elemanlarının tersten yazılısı \n");
            for (int i = (dizi.Length - 1); i >= 0; i--)
            {
                Console.WriteLine("Dizinin " + (dizi.Length - i) + ". elemanını = " + dizi[i]);
            }

            Random rnd = new Random();
            int rastgele = rnd.Next(0, dizi.Length);
            Console.WriteLine("Rastgele seçilen sayı :" + dizi[rastgele]);
            Console.ReadLine();
        }
    }
}

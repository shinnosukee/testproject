using System;

namespace quiz_09092019
{
    class BangunRuang
    {
        public static void volumeBalok()
        {
            Console.WriteLine("Menghitung Volume Balok");

            Console.WriteLine("=============================");

            //Variable
            int panjang, lebar, tinggi, volume;

            //Input
            Console.Write("Panjangnya berapa nak? ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lebarnya berapa nak? ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tingginya berapa nak? ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            //Processing
            volume = panjang * lebar * tinggi ;

            //Output
            Console.WriteLine("Ta-Daa! Volume Balok adalah "+volume);
        }

        //Volume Kubus
        public static void volumeKubus()
        {
            Console.WriteLine("Menghitung Volume Kubus"); //Text

            Console.WriteLine("=============================");

            //Variable
            int sisi, volume;

            //Input
            Console.Write("Sisinya berapa nak? "); 
            sisi = Convert.ToInt32(Console.ReadLine());

            //Processing
            volume = sisi * sisi * sisi ;

            //Output
            Console.WriteLine("Ta-Daa! Volume Kubus adalah "+volume);
        }
    }
}

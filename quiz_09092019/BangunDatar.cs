using System;

namespace quiz_09092019
{
    class BangunDatar
    {
        //luas Persegi
        public static void luasPersegi()
        {
            Console.WriteLine("Menghitung Luas Persegi");

            Console.WriteLine("=============================");
            
            //variable
            int sisi, luas;

            //input
            Console.Write("Sisinya berapa nak? ");
            sisi = Convert.ToInt32(Console.ReadLine());

            //proses
            luas = sisi * sisi;
            //output
            Console.WriteLine("Ta-Daa! Luas Persegi adalah "+luas);
        }

        //luas Segitiga
        public static void luasSegitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");

            Console.WriteLine("=============================");

            //variable
            int alas, tinggi;
            double luas, half; //digunakan untuk menginput/menghasilkan bilangan berkoma
            half=0.5;

            //input
            Console.Write("Alasnya berapa nak? ");

            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tingginya berapa nak? ");

            tinggi = Convert.ToInt32(Console.ReadLine());
            
            //proses
            luas = half * alas * tinggi;

            //output
            Console.WriteLine("Ta-Daa! Luas Segitiga adalah "+luas);
        }

        //luas lingkaran
        public static void luasLingkaran()
        {
            Console.WriteLine("Menghitung Luas Lingkaran");

            Console.WriteLine("=============================");

            //variabel
            int jari;
            double luas; //digunakan untuk menginput/menghasilkan bilangan berkoma
            double phi; //digunakan untuk menginput/menghasilkan bilangan berkoma
            phi=3.14;

            //input
            Console.Write("Jari-jarinya berapa nak? ");
            jari = Convert.ToInt32(Console.ReadLine());

            //proses
            luas = phi * jari * jari;

            //output
            Console.WriteLine("Ta-Daa! Luas Lingkaran adalah "+luas);
        }
    }
}

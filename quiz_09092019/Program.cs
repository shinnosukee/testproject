/*
Aplikasi Kalkulator Bangun Datar dan Bangun Ruang v1.0 by wed(Nicolas Neville/XTKJ1)
Digunakan untuk menghitung luas persegi, segitiga, dan lingkaran (Untuk Bangun Datar)
Untuk Bangun Ruang, aplikasi ini akan menghitung volume balok dan kubus
Apabila ada error dalam code/build aplikasi ini, silakan melaporkannya melalui Issue
Code ini 100% open-source eak, made using C#
*/

using System;

namespace quiz_09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable

            about info1 = new about(); //di file about.cs

            //Text Informasi

            Console.WriteLine("Aplikasi "+info1.info()); //Nama Aplikasi
            Console.WriteLine("Dibuat oleh "+info1.nama()); //Nama Pembuat
            Console.WriteLine("Dari "+info1.sekolah()); //Asal Sekolah

            Console.WriteLine("============================="); //pembatas

            //Bangun Datar

            BangunDatar.luasPersegi();  //Luas Persegi

            Console.WriteLine("============================="); //pembatas

            BangunDatar.luasSegitiga();  //Luas Segitiga

            Console.WriteLine("============================="); //pembatas

            BangunDatar.luasLingkaran();  //Luas Lingkaran

            //Bangun Ruang

            Console.WriteLine("============================="); //pembatas

            BangunRuang.volumeBalok(); //Volume Balok

            Console.WriteLine("============================="); //pembatas

            BangunRuang.volumeKubus();  //Volume Kubus
        }
    }
}

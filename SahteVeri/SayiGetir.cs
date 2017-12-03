using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri
{
    public static class SayiGetir
    {
        static Random rnd = new Random();
        public static int Getir(int sayi1, int sayi2)
        {
            int r = rnd.Next(sayi1, sayi2+1);
            return r;

        }
        public static int Getir(int sayi1)
        {
            int r = rnd.Next(sayi1);
            return r;

        }
        public static int Getir()
        {
            int r = rnd.Next();
            return r;

        }



    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri
{
    public static class TarihGetir
    {
        static Random rnd = new Random();
        public static string DogumTarihiGetir(int s1,int s2)
        {
            int gun = rnd.Next(1, 32);
            int ay = rnd.Next(1,13);
            int yil = DateTime.Now.Year;
            int dyil = rnd.Next(yil - s1, yil - s2);
            return (gun + "/" + ay + "/" + dyil);


        } 
        public static DateTime UretimTarihiGetir()
        {
            return DateTime.Now.Date;
        }
         public static string SonKullanmaTarihiGetir()
        {

            int gun = rnd.Next(1, 32);
            int ay = rnd.Next(1, 13);
            int yil = DateTime.Now.Year;
            int dyil = rnd.Next(yil + 1, yil + 5);
            return (gun + "/" + ay + "/" + dyil);
        }
    }
}

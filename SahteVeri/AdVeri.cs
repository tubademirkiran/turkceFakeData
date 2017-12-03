using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri
{
    public static class AdVeri
    {
        static Random rnd = new Random();

        public static string BayanAdGetir()
        {
            string[] diziBayanAd = { "Tuba","Gamze","Bilge","Deniz","Ceylan","Ceren","Ela","Duru","Jale","Nilay","Kevser","Aslı", "Fatma", "Ayşe", "Emine"," Hatice"," Zeynep",
                " Elif", "Meryem"," Şerife", "Sultan"," Zehra", "Hanife",
                " Merve", "Havva"," Zeliha", "Fadime", "Esra", "Özlem", "Hacer", "Yasemin" ," Hülya",
                "Zeynep"," Elif", "Ecrin"," Yağmur", "Zehra"," Azra"," Nisanur"," Ela", "Belinay",
                    "Nehir", "Hiranur"," Meryem",
                "Irmak"," Eylül" ," Sümeyye"," Cemre", "Rabia","Fatma","Ayşe","Emine","Hatice","Zeynep","Elif","Meryem","Şerife","Zehra",
"Sultan","Hanife","Merve","Havva","Zeliha","Esra","Fadime","Özlem","Hacer","Yasemin","Melek","Rabia","Hülya","Cemile","Sevim","Gülsüm","Leyla","Dilek","Büşra","Aysel","Songül","Kübra","Halime","Esma","Aynur","Hayriye","Kadriye","Tuba","Sevgi","Rukiye","Hava","Sibel","Derya","Asiye","Filiz","Kezban","Ebru","Aysegul","Dondu","Selma","Ayten"
            };

            int rastgeleSayi = rnd.Next(0, diziBayanAd.Length);
            return diziBayanAd[rastgeleSayi];
        }

        public static string BayAdGetir()
        {
            string[] diziBayAd = { "Cem","Can","Ayhan","Remzi","Mustafa","Erbil","Umut","Sami","Mehmet"," Mustafa"," Ahmet", "Ali", "Hüseyin",
                " Hasan", "İbrahim", "İsmail", "Osman", "Yusuf", "Murat"," Ömer",
                "Ramazan"," Halil", "Süleyman"," Abdullah", "Mahmut", "Recep", "Salih", "Fatih",
                "Yusuf"," Berat"," Emir"," Mustafa", "Ahmet"," Ömer"," Mehmet"," Muhammed",
                "Emirhan"," Eymen", "Ali", "Çınar"," Enes"," Kerem","Turgay","Anıl","Nadir","Doğan","Turan","Göktuğ","Alper","Alp","Kerem","Cemil",
                "Miraç"," Umut"," İbrahim"," Furkan"," Hüseyin"," Yunus Emre","Bülent","Mehmet","Mustafa","Ahmet","Ali","Hüseyin","Hasan","İbrahim","İsmail",
"Osman","Yusuf","Murat","Ömer","Ramazan","Halil","Süleyman","Abdullah","Mahmut","Recep","Salih","Fatih","                                                                                  Kadir","Emre","Mehmet", "Ali","Hakan","Adem","Kemal","Yasar","Bekir","Musa","Metin","Bayram","Serkan","Orhan","Burak","Furkan","Gökhan","Yasin","Uğur","Yakup","Muhammet","Muhammed","Şükrü","Cemal","Enes","Yunus","Arif","Onur","Yılmaz","Şaban","Halil","İbrahim",
            };

            int rastgeleSayi = rnd.Next(0, diziBayAd.Length);
            return diziBayAd[rastgeleSayi];
        }
        public static string AdGetir()
        {
            string[] adDizi =
            {
                "Bülent","Mehmet","Mustafa","Ahmet","Ali","Hüseyin","Hasan","İbrahim","İsmail","Osman","Yusuf","Murat","Ömer","Ramazan","Halil","Süleyman","Abdullah","Mahmut","Recep","Salih","Fatih","Kadir","Emre","Mehmet Ali","Hakan","Adem","Kemal","Yasar","Bekir","Musa","Metin","Bayram","Serkan","Orhan","Burak","Furkan","Gökhan","Yasin","Uğur","Yakup","Muhammet","Muhammed","Şükrü","Cemal","Enes","Yunus","Arif","Onur","Yılmaz","Şaban","Halil","İbrahim","Fatma","Ayşe","Emine","Hatice","Zeynep","Elif","Meryem","Şerife","Zehra","Sultan","Hanife","Merve","Havva","Zeliha","Esra","Fadime","Özlem","Hacer","Yasemin","Melek","Rabia","Hülya","Cemile","Sevim","Gülsüm","Leyla","Dilek","Büşra","Aysel","Songül","Kübra","Halime","Esma","Aynur","Hayriye","Kadriye","Tuba","Sevgi","Rukiye","Hava","Sibel","Derya","Asiye","Filiz","Kezban","Ebru","Aysegul","Dondu","Selma","Ayten" };
            int r = rnd.Next(0, adDizi.Length);
            return adDizi[r];
        }

        public static string SoyadGetir()
        {
            string[] diziSoyad = { "YILDIZ", "YILDIRIM", "ÖZTÜRK", "AYDIN", "ÖZDEMİR",
                " ARSLAN", "DOĞAN", "KILIÇ", "ARSLAN", "ÇETİN", "KARA", "KOÇ",
                "KURT", "ÖZGÜN", "ŞİMŞEK", "GENÇ", "GÜLER", "YAMAN", "ÇALIŞKAN", "ŞENER","ÖZEN","YILMAZ","KAYA","DEMİR","ÇELİK","ŞAHİN","YILDIZ","YILDIRIM",
               "ÖZTÜRK","AYDIN","ÖZDEMİR","ARSLAN","DOĞAN","KILIÇ","ASLAN","ÇETİN","KARA","KOÇ",
                "KURT","ÖZKAN","ŞİMŞEK","POLAT","ÖZCAN","KORKMAZ","ÇAKIR","ERDOĞAN","YAVUZ"
                   ,"CAN","ACAR","ŞEN","AKTAŞ","GÜLER","YALÇIN","GÜNEŞ","BOZKURT","BULUT",
                "KESKİN","ÜNAL","TURAN","GÜL","ÖZER","IŞIK",
                "KAPLAN","AVCI","SARI","TEKİN","TAŞ","KÖSE","YÜKSEL","ATEŞ","AKSOY","DEMİR","SU"
                ,"TOPRAK","DAĞ","DERE","ALTAN","ALTUĞ","YILMAZ","TEPE","DENİZ","ŞENER","ASLAN",
                "GÜZEL","ALTAŞ","ÖZCAN","AYDIN","BULUT","ÇAKMAK","DURAN","GAZİ","DOĞAN",

            };

            int rastgeleSayi = rnd.Next(0, diziSoyad.Length);
            return diziSoyad[rastgeleSayi];
        }

        public static string UrunAdGetir()
        {
            string[] diziUrunAd = { "Sprey","Parfüm","Pudra","Ruj","Rimel","Fondöten","Kaşar","Pil","El Kremi","Duş Jeli","Patates","Pizza","Şampuan","Sabun","Süt", "Ekmek", "Yumurta", "Çikolata", "Cips", "Dondurma", "Yoğurt", "Peynir", "Reçel", "Salça", "Un", "Su", "Kola", "Yağ", "Bisküvi","Şeker","Tuz","Makarna","Pirinç","Turşu","Dondurma","Çerez","Meyve Suyu","Bulgur","Nohut","Bebek Maması","Islak Mendil","Peçete","Çamaşır Suyu","Deterjan","Çay","Kahve","Mayonez","Konserve", "Krem Şanti","Puding","Şeker","Vanilya","Zeytinyağı","Gofret","Fasülye","Hazır Çorba","Zeytin","Salam","Sosis","Sucuk","Kıyma","Kraker","Sos"};

            int rastgeleSayi = rnd.Next(0, diziUrunAd.Length);
            return diziUrunAd[rastgeleSayi];
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SahteVeri;

namespace ogrenci
{
    public partial class FormOgrenci : Form
    {
        public FormOgrenci()
        {
            InitializeComponent();
        }
        List<ogrenci> olist = new List<ogrenci>();
        private void FormOgrenci_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                ogrenci o = new ogrenci();
                o.id = i;
                //o.ad = SahteVeri.AdVeri.BayanAdGetir();
                //o.ad = SahteVeri.AdVeri.BayAdGetir();
                o.ad = SahteVeri.AdVeri.AdGetir();
                o.soyad = SahteVeri.AdVeri.SoyadGetir();
                o.maas = SahteVeri.SayiGetir.Getir(500, 1000);
                o.dogumTarihi = SahteVeri.TarihGetir.DogumTarihiGetir(25, 20);
                o.sokak = SahteVeri.AdresVeri.SokakGetir();
                o.cadde = SahteVeri.AdresVeri.CaddeGetir();
                o.ilce = SahteVeri.AdresVeri.İlceGetir();
                o.sehir = SahteVeri.AdresVeri.SehirGetir();
                o.no = SahteVeri.AdresVeri.NumaraGetir();
                olist.Add(o);
            }
            dataGridView1.DataSource=olist;
        }
    }
}

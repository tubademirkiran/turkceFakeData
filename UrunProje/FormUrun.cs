using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunProje
{
    public partial class FormUrun : Form
    {
        List<urun> ulist = new List<urun>();

        public FormUrun()
        {
            InitializeComponent();
        }

        private void FormUrun_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                urun u = new urun();
                u.id = i;
                u.urunAdi = SahteVeri.AdVeri.UrunAdGetir();
                u.uretimTarihi = SahteVeri.TarihGetir.UretimTarihiGetir();
                u.sonKullanmaTarihi = SahteVeri.TarihGetir.SonKullanmaTarihiGetir();
                u.fiyat = SahteVeri.SayiGetir.Getir(0, 500);
                ulist.Add(u);
            }
           
            dataGridView1.DataSource = ulist;
        }
       
    }
}

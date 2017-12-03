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

namespace dllDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = SahteVeri.AdVeri.BayAdGetir();
            //textBox1.Text = SahteVeri.AdVeri.BayanAdGetir();
            //textBox1.Text = SahteVeri.AdVeri.SoyadGetir();
            //textBox1.Text = SahteVeri.AdVeri.UrunAdGetir();
            //textBox1.Text = SahteVeri.AdresVeri.CaddeGetir();
            //textBox1.Text = SahteVeri.AdresVeri.SokakGetir();
            //textBox1.Text = SahteVeri.AdresVeri.SehirGetir();
            //textBox1.Text = SahteVeri.AdresVeri.NumaraGetir();
            //textBox1.Text = SahteVeri.SayiGetir.Getir(5, 10).ToString();
            //textBox1.Text = SahteVeri.TarihGetir.DogumTarihiGetir(25, 20);
            //textBox1.Text = SahteVeri.TarihGetir.UretimTarihiGetir().ToString();
            textBox1.Text = SahteVeri.TarihGetir.SonKullanmaTarihiGetir().ToString();
        }
        }
}

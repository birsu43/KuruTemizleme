using KuruTemizleme.App.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KuruTemizleme.App
{
    public partial class home : Form
    {
        private LogIn logIn;
        public home(LogIn logIn)
        {
            InitializeComponent();
            this.logIn = logIn;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string veri = "Ütü";
            txtAciklama.Text = veri;
            int b = Convert.ToInt32(txtAdet.Text);
            Hesaplama(veri, b);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string veri = "Yıkama";
            txtAciklama.Text = veri;
            int b = Convert.ToInt32(txtAdet.Text);
            Hesaplama(veri, b);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string veri = "Kuru Temizleme";
            txtAciklama.Text = veri;
            int b = Convert.ToInt32(txtAdet.Text);
            Hesaplama(veri, b);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string veri = "Leke Çıkarma";
            txtAciklama.Text = veri;
            int b = Convert.ToInt32(txtAdet.Text);
            Hesaplama(veri, b);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string veri = "Ceket";
            txtKiyafet.Text = veri;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string veri = "Takım üstü";
            txtKiyafet.Text = veri;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string veri = "Deri Ceket";
            txtKiyafet.Text = veri;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string veri = "Etek";
            txtKiyafet.Text = veri;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string veri = "Gece Elbisesi";
            txtKiyafet.Text = veri;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string veri = "Gelinlik";
            txtKiyafet.Text = veri;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string veri = "Gömlek";
            txtKiyafet.Text = veri;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string veri = "Kaban";
            txtKiyafet.Text = veri;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string veri = "Kazak";
            txtKiyafet.Text = veri;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string veri = "Takım Altı";
            txtKiyafet.Text = veri;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            string veri = "Kürk";
            txtKiyafet.Text = veri;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            string veri = "Mont";
            txtKiyafet.Text = veri;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            string veri = "Pantolon";
            txtKiyafet.Text = veri;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            string veri = "Takım Elbise";
            txtKiyafet.Text = veri;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            string veri = "Yelek";
            txtKiyafet.Text = veri;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            string veri = "Elbise";
            txtKiyafet.Text = veri;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    Randevu c = new Randevu();

                    c.aciklama = txtAciklama.Text;
                    c.adet = Convert.ToInt32(txtAdet.Text);
                    c.tutar = float.Parse(txtTutar.Text);
                    c.tarih = DateTime.Parse(txtTarih.Text);
                    c.kiyafetTip = txtKiyafet.Text;
                    c.teslim = comboBox1.SelectedIndex.ToString();
                    c.makbuz = txtMAkbuz.Text;
                    c.musteriNo = Convert.ToInt32(txtMusteriNo.Text);
                    c.musteriAd = txtMusteriAd.Text;
                    if (c.tarih < DateTime.Now)
                    {
                        c.durum = "Teslim Edildi";
                    }
                    else
                    {
                        c.durum = "Hazırlanıyor";
                    }


                    if (c != null)
                    {
                        ctx.Randevular.Add(c);
                        int a = ctx.SaveChanges();

                        if (a > 0)
                        {
                            MessageBox.Show(" Başarıyla kaydedildi!");

                          

                            Getir2();



                        }
                        else
                        {
                            MessageBox.Show(" kaydedilemedi!");
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            MessageBox.Show("LÜTFEN İLK OLARAK ADET ALANINI DOLDURUNUZ!");
            try
            {
                using (var ctx = new ModelContext())
                {

                    string telefonNumarasi = logIn.txtKulAd.Text;

                    Users kullanici = ctx.User.FirstOrDefault(k => k.telefon == telefonNumarasi);



                    if (kullanici != null)
                    {
                        txtMAkbuz.Text = kullanici.telefon;
                        txtMusteriAd.Text = kullanici.ad + kullanici.soyad;
                        txtMusteriNo.Text = Convert.ToString(kullanici.id);


                    }
                }
                
                Getir2();
                KulGetir();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Hesaplama(String a, int b)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var sorgu = from k in ctx.Ucret
                                where k.islemAd == a.ToString()
                                select k.ucret;
                    var listOfUcretler = sorgu.FirstOrDefault();
                    int ucret = b * (Int32)(listOfUcretler);
                    txtTutar.Text = ucret.ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void brnSil_Click(object sender, EventArgs e)
        {
            txtAciklama.Text = string.Empty;
            txtAdet.Text = string.Empty;
            txtKiyafet.Text = string.Empty;
            txtTarih.Text = string.Empty;
            txtTutar.Text = string.Empty;
            comboBox1.Text = string.Empty;
        }


        public void Getir2()
        {
            using (var ctx = new ModelContext())
            {


                List<Randevu> randevu1 = ctx.Randevular.ToList();
                DateTime simdikiZaman = DateTime.Now;
                List<Randevu> expiredVeriler = randevu1.Where(k => k.tarih < simdikiZaman).ToList();
                List<Randevu> validVeriler = randevu1.Where(k => k.tarih >= simdikiZaman).ToList();



                var sorgu = from u in ctx.User
                            where u.telefon == logIn.txtKulAd.Text
                            select u.id;
                var kullaniciId = sorgu.FirstOrDefault();

                if (kullaniciId != null)
                {
                    var data = ctx.Randevular.Where(r => r.musteriNo == kullaniciId).ToList();
                    TableGecmis.DataSource = data.Where(r => r.tarih < simdikiZaman && r.musteriNo == kullaniciId).ToList();
                    if (data.Any(r => r.tarih >= simdikiZaman))
                    {
                        TableMevcut.DataSource = data.Where(r => r.tarih >= simdikiZaman && r.musteriNo == kullaniciId).ToList();
                    }
                    else
                    {

                        TableGecmis.DataSource = data.Where(r => r.tarih < simdikiZaman && r.musteriNo == kullaniciId).ToList();

                    }
                }

            }

        }

        public void KulGetir()
        {
            try
            {
                using (var ctx = new ModelContext())
                {

                    string tel = logIn.txtKulAd.Text;

                    Users kullanici = ctx.User.FirstOrDefault(k => k.telefon == tel);



                    if (kullanici != null)
                    {
                        txtAd1.Text = kullanici.ad;
                        txtSoyad1.Text = kullanici.soyad;
                        txtTelefon1.Text = kullanici.telefon;
                        txtSifre.Text = kullanici.sifre;
                        txtCinsiyet.Text = kullanici.cinsiyet;
                        txtAdres1.Text = kullanici.adres;


                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void btnGuncel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    string sifre1 = logIn.txtPass.Text;

                    Users kullanici = ctx.User.FirstOrDefault(k => k.sifre == sifre1);
                    kullanici.ad = txtAd1.Text;

                    kullanici.soyad = txtSoyad1.Text;
                    kullanici.telefon = txtTelefon1.Text;
                    kullanici.adres = txtAdres1.Text;
                    kullanici.sifre = txtSifre.Text;
                    kullanici.cinsiyet = txtCinsiyet.Text;
                    ctx.User.Update(kullanici);
                   int a= ctx.SaveChanges();
                    if (a>0)
                    {
                        MessageBox.Show("Başarıyla Güncellendi");

                        var sorgu = from k in ctx.User
                                    where k.telefon == txtTelefon1.Text
                                    select k;
                        var listOfKullanici = sorgu.FirstOrDefault();
                        var yeniKullanici = new LogTable
                        {
                            kullaniciId = listOfKullanici.id,
                            tarihSaat = DateTime.Now,
                            yapilanIslem = "Profil Güncellendi"
                        };
                        ctx.Log.Add(yeniKullanici);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Güncellenemedi!");
                    }

                   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new ModelContext())
                {

                    string kulAd = logIn.txtKulAd.Text;

                    Users kullanici = ctx.User.FirstOrDefault(k => k.telefon == kulAd);

                    ctx.User.Remove(kullanici);
                    int a = ctx.SaveChanges();
                    var sorgu = from k in ctx.User
                                where k.telefon == txtTelefon1.Text
                                select k;
                    var listOfKullanici = sorgu.FirstOrDefault();
                    if (a > 0)
                    {
                        MessageBox.Show(" Hesap Silindi!");
                        var yeniKullanici = new LogTable
                        {
                            kullaniciId = listOfKullanici.id,
                            tarihSaat = DateTime.Now,
                            yapilanIslem = "Profil Silindi"
                        };

                        ctx.Log.Add(yeniKullanici);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show(" Hata!");
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

     

        private void btnCikis_Click(object sender, EventArgs e)
        {
            using (var ctx = new ModelContext())
            {
                var sorgu = from k in ctx.User
                            where k.telefon == txtTelefon1.Text
                            select k;
                var listOfKullanici = sorgu.FirstOrDefault();
                var yeniKullanici = new LogTable
                {
                    kullaniciId = listOfKullanici.id,
                    tarihSaat = DateTime.Now,
                    yapilanIslem = "Profilden Çıkış Yap"
                };

                ctx.Log.Add(yeniKullanici);
                ctx.SaveChanges();
            }
            Dispose();

            logIn.Close();

        }
    }

}

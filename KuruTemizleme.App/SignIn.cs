using KuruTemizleme.App.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuruTemizleme.App
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx=new ModelContext())
                {
                    Users user=new Users();
                    user.ad=txtAd.Text;
                    user.soyad=txtSoyad.Text;
                    user.sifre=txtSifre.Text;
                    user.adres=txtAdres.Text;
                    user.cinsiyet = comboBox1.SelectedItem.ToString();
                    user.telefon=txtTel.Text;
                    
                    if (user!=null)
                    {
                        ctx.User.Add(user);
                       int a= ctx.SaveChanges();
                        if (a>0)
                        {
                            MessageBox.Show("Kullanıcı başarıyla kaydedildi!");
                            var sorgu = from k in ctx.User
                                        where k.telefon == txtTel.Text
                                        select k;
                            var listOfKullanici = sorgu.FirstOrDefault();

                            var yeniKullanici = new LogTable
                            {
                                kullaniciId =listOfKullanici.id,
                                tarihSaat = DateTime.Now,
                                yapilanIslem = "Yeni Kayit"
                            };

                            ctx.Log.Add(yeniKullanici);
                            ctx.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı kaydedilemedi!");
                        }
                    }
                   
                }

            }
            catch (Exception)
            {

                throw;
            }


            LogIn log=new LogIn();
            log.ShowDialog();
        }
    }
}

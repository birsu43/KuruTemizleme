using KuruTemizleme.App.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace KuruTemizleme.App
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SignIn sign = new SignIn();
            sign.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new ModelContext())
                {
                    var sorgu = from k in ctx.User
                                where k.telefon == txtKulAd.Text && k.sifre == txtPass.Text
                                select k;
                    var listOfKullanici = sorgu.FirstOrDefault();
                    if (listOfKullanici != null)
                    {
                     
                        
                        home home = new home(this);
                        home.Visible = true;

                        var log = new LogTable
                        {
                            kullaniciId = listOfKullanici.id,
                            tarihSaat =DateTime.Now,
                            yapilanIslem = "Giriş"
                        };

                        ctx.Log.Add(log);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı şifre veya kullanıcı adı");
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

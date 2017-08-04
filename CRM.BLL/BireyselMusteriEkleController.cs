using CRM.DAL.Repositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL
{
   public class BireyselMusteriEkleController
    {
        MusteriManagement mm = new MusteriManagement();
        AdresManagement adm = new AdresManagement();
        MusteriBireyselManagement mbm = new MusteriBireyselManagement();
        EmailManagement emm = new EmailManagement();
        TelefonManagement tm = new TelefonManagement();


        int MusteriID;
        public int MusteriEkle()
        {
            Musteri m = new Musteri();
            m.TipID = 1;
           return  MusteriID = mm.Add2(m);
        }
        public void MusteriBireyselEkle(string ad,string soyad,string tc,DateTime dogumTarihi, int id)
        {
            MusteriBireysel mb = new MusteriBireysel();
            mb.Ad = ad;
            mb.Soyad = soyad;
            mb.TC = tc;
            mb.DogumTarihi = dogumTarihi;
            mb.MusteriID = id;
            mbm.Add(mb);

        }

        public void TelefonEkle(string tel, int id)
        {
            Telefon t = new Telefon();
            t.Telefon1 = tel;
            t.MusteriID = id;
            tm.Add(t);

        }

        public void AdresEkle(string adres,string ilce,string il, int id)
        {
            Adre adr = new Adre();
            adr.Adress = adres;
            adr.Ilce = ilce;
            adr.Il = il;
            adr.MusteriID = id;
            adm.Add(adr);

        }

        public void EmailEkle(string mail, int id)
        {
            Email m = new Email();
            m.EmailAdres = mail;
            m.MusteriID = id;
            emm.Add(m);

        }
    }
}

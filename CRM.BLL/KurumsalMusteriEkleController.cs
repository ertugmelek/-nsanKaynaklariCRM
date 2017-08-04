using CRM.DAL.Repositories;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL
{
     public class KurumsalMusteriEkleController
    {
        MusteriManagement mm = new MusteriManagement();
        AdresManagement adm = new AdresManagement();
        MusteriFirmaManagement mfm = new MusteriFirmaManagement();
        EmailManagement emm = new EmailManagement();
        TelefonManagement tm = new TelefonManagement();



        int MusteriID;
        public int MusteriEkle()
        {
            Musteri m = new Musteri();
            m.TipID = 2;
            return MusteriID = mm.Add2(m);
        }
        public void MusteriFirmaEkle(string mersis, string unvan,int id)
        {
            MusteriFirma mf = new MusteriFirma();
            mf.Mersis = mersis;
            mf.Unvan = unvan;
            mf.MusteriID = id;
            mfm.Add(mf);
            

        }

        public void TelefonEkle(string tel, int id)
        {
            Telefon t = new Telefon();
            t.Telefon1 = tel;
            t.MusteriID = id;
            tm.Add(t);

        }

        public void AdresEkle(string adres, string ilce, string il, int id)
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

using CRM.BLL;
using CRM.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRM
{
    public partial class KurumsalMusteriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FaaliyetAlaniDoldur();
            }

        }


        private void FaaliyetAlaniDoldur()
        {
            FaaliyetAlaniController fac = new FaaliyetAlaniController();

            ddlFaaliyetAlani.DataSource = fac.FaaliyetAlanlariGetir();
            ddlFaaliyetAlani.DataTextField = "FaaliyetAlani1";
            ddlFaaliyetAlani.DataValueField = "FaaliyetAlanID";
            ddlFaaliyetAlani.DataBind();
            ddlFaaliyetAlani.Items.Insert(0, new ListItem("Lütfen faaliyet alanı seçiniz...", "0"));
        }


        private void KurMusteriEkle()
        {
            KurumsalMusteriEkleController kmc = new KurumsalMusteriEkleController();
            string mersis, unvan,tel, mail, adres, il, ilce;

            mersis = txtMersis.Text;
            unvan = txtUnvan.Text;      
          
            tel = txtTel.Text;
            mail = txtMail.Text;
            adres = txtAdres.Text;
            il = txtIl.Text;
            ilce = txtIlce.Text;
            int musteriID = kmc.MusteriEkle();
            kmc.MusteriFirmaEkle(mersis, unvan, musteriID);
            kmc.TelefonEkle(tel, musteriID);
            kmc.EmailEkle(mail, musteriID);
            kmc.AdresEkle(adres, ilce, il, musteriID);

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                KurMusteriEkle();
               // Helper.MesajGoster(this, "Müşteri kaydedildi");
            }
            catch (Exception)
            {
               // Helper.MesajGoster(this, "Hata oluştu!!");

            }

        }
    }
}
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
    public partial class BireyselMusteriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UnvanlariGetir();
            }

        }



        private void UnvanlariGetir()
        {
            BireyselUnvanController buc = new BireyselUnvanController();

            ddlUnvan.DataSource = buc.UnvanGetir();
            ddlUnvan.DataTextField = "Unvan";
            ddlUnvan.DataValueField = "UnvanID";
            ddlUnvan.DataBind();
            ddlUnvan.Items.Insert(0, new ListItem("Lütfen Unvan seçiniz...", "0"));
        }

        private void BMusteriEkle()
        {
            BireyselMusteriEkleController bmc = new BireyselMusteriEkleController();
            string ad, soyad, tc, tel, mail, adres, il, ilce;
            DateTime dogumtarihi = Convert.ToDateTime(txtDogumTarihi.Text);
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            tc = txtTC.Text;
            tel = txtTel.Text;
            mail = txtMail.Text;
            adres = txtAdres.Text;
            il = txtIl.Text;
            ilce = txtIlce.Text;
            int musteriID = bmc.MusteriEkle();
            bmc.MusteriBireyselEkle(ad,soyad,tc,dogumtarihi,musteriID);
            bmc.TelefonEkle(tel,musteriID);
            bmc.EmailEkle(mail,musteriID);
            bmc.AdresEkle(adres,ilce,il,musteriID);
                
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                BMusteriEkle();
                //Helper.MesajGoster(this, "Müşteri kaydedildi");
            }
            catch (Exception)
            {
               // Helper.MesajGoster(this, "Hata oluştu!!");
                
            }
           
        }
    }
}
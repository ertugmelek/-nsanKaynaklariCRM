using CRM.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRM
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                MusteriTuruListele();
            }

        }


        public void BireyselVeriListele()
        {
            MusteriBireyselController mbc = new MusteriBireyselController();
            MusteriFirmaController mfc = new MusteriFirmaController();

            GrdListele.DataSource = mbc.Listele();
            GrdListele.DataBind();

        }
        public void KurumsalVeriListele()
        {

            MusteriFirmaController mfc = new MusteriFirmaController();

            grdKurumsal.DataSource = mfc.VeriCek();
            grdKurumsal.DataBind();

        }

        public void MusteriTuruListele()
        {
            MusteriTuruController mtc = new MusteriTuruController();
            ddlMusteri.DataSource = mtc.MusteriTurListele();
            ddlMusteri.DataTextField = "TipAdi";
            ddlMusteri.DataValueField = "TipID";
            ddlMusteri.DataBind();
            ddlMusteri.Items.Insert(0, new ListItem("Lütfen müşteri türü seçiniz...", "0"));

        }
        protected void ddlMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlMusteri.SelectedItem.ToString() == "Kurumsal")
            {
                grdKurumsal.Visible = true;
                GrdListele.Visible = false;
                KurumsalVeriListele();
            }
            else if (ddlMusteri.SelectedItem.ToString() == "Bireysel")
            {
                GrdListele.Visible = true;
                grdKurumsal.Visible = false;
                BireyselVeriListele();
            }



        }




    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.TBLILETISIM.Find(x);
            TxtAdSoyad.Text= mesaj.ADSOYAD;
            TxtKonu.Text = mesaj.KONU;
            TxtMail.Text = mesaj.MAIL;
            TxtMesaj.Text = mesaj.MESAJ;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class AdresSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //database bağlantısı
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var ytnk = db.TBLADRES.Find(x);
            db.TBLADRES.Remove(ytnk);
            db.SaveChanges();
            Response.Redirect("Adres.Aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class AdresEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLADRES t = new TBLADRES();
            t.ADRES = TextBox1.Text;
            db.TBLADRES.Add(t);
            db.SaveChanges();
            Response.Redirect("AdresEkle.Aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class AdresGüncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db  = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.TBLADRES.Find(x);
                TextBox1.Text = deger.ADRES;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var deger = db.TBLADRES.Find(x);
            deger.ADRES = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Adres.Aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CvProject
{
    public partial class YetenekGüncelle : System.Web.UI.Page
    {//veri tabanı bağlantısı
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            int x = int.Parse(Request.QueryString["ID"]);
            if(Page.IsPostBack == false)
            {
                var deger = db.TBLYETENEKLER.Find(x);
                TextBox1.Text = deger.YETENEK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var deger = db.TBLYETENEKLER.Find(x);
            deger.YETENEK = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.Aspx");
        }
    }
}
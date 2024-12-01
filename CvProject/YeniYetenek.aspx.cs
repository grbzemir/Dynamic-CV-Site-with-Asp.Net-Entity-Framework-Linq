using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLYETENEKLER t = new TBLYETENEKLER();
            t.YETENEK = TextBox1.Text;
            db.TBLYETENEKLER.Add(t);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.Aspx");

        }
    }
}
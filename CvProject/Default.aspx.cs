using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CvProject
{
    public partial class _Default : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBLHAKKIMDAA.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.TBLHAKKIMDAA.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.TBLHAKKIMDAA.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.TBLYETENEKLER.ToList();
            Repeater4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLILETISIM t = new TBLILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox4.Text;
            t.MESAJ = TextBox3.Text;
            db.TBLILETISIM.Add(t);
            db.SaveChanges();
        }
    }
}
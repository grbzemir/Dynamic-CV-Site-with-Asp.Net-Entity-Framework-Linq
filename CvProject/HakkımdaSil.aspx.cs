using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProject
{
    public partial class HakkımdaSil : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            //database bağlantısı
            
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            var hakkimda = db.TBLHAKKIMDAA.Find(id);
            db.TBLHAKKIMDAA.Remove(hakkimda);
            db.SaveChanges();
            Response.Redirect("Hakkimda.Aspx");


        }
    }
}
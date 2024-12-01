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
        }

    }
}
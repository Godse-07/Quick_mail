using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GMAIL_CLONE
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet ds = Class1.fetch("select * from Message ");//where to_email='" + Session["to_email"].ToString() + "'");
            //Console.WriteLine("Test1");
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                //   Console.WriteLine("Test2");
            }

            if (Session["Name"] != null && Session["Name"].ToString() != "")
            {
                Label2.Text = Session["Email"].ToString();

                //Label2.Text = Session["Email"].ToString(); //+ "<br/>" + Session["mob"].ToString();

                Image1.ImageUrl = Session["Img"].ToString();
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }

        }


        protected void dispImg()
        {
            DataSet dx = Class1.fetch("select * from user_det where id!='" + Session["id"] + "'");
            if (dx.Tables[0].Rows.Count != 0)
            {
                //DataList1.DataSource = dx;
                //DataList1.DataBind();
            }
        }
    }
}
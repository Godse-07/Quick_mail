using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GMAIL_CLONE
{
    public partial class log_in : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/Default2.aspx");
            DataSet x = Class1.fetch("select * from user_det where Email='" + TextBox1.Text + "'");
            if (x.Tables[0].Rows.Count != 0)
            {
                if (x.Tables[0].Rows[0][2].ToString() == TextBox2.Text)
                {
                    Session["Name"] = x.Tables[0].Rows[0][0].ToString();
                    Session["Email"] = x.Tables[0].Rows[0][1].ToString(); //+ " " + x.Tables[0].Rows[0][2].ToString();
                    Session["Password"] = x.Tables[0].Rows[0][2].ToString();
                    Session["Img"] = x.Tables[0].Rows[0][3].ToString();
                   
                    Response.Redirect("~/Default2.aspx?" + Session["Name"].ToString());
                }
                else
                {
                    Response.Write("<script>alert('INVALID PASSWORD')</script>");

                }
            }

            else
            {
                Response.Write("<script>alert('INVALID USER NAME')</script>");

            }

        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}
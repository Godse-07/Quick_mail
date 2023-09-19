using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GMAIL_CLONE
{
    public partial class inboxcontent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["name"] != null && Session["name"].ToString() != "")
            {
                Label1.Text = Session["name"].ToString();

                Label2.Text = Session["email"].ToString() + "<br/>" + Session["mob"].ToString();

                Image1.ImageUrl = Session["img"].ToString();


            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
            DataSet x = Class1.fetch("select * from Message where msg_id='" + Request.QueryString["msg_id"] + "'");
            if (x.Tables[0].Rows.Count != 0)
            {
                Session["msg_id"] = x.Tables[0].Rows[0][0].ToString();
                Session["to_email"] = x.Tables[0].Rows[0][1].ToString();
                Session["my_email"] = x.Tables[0].Rows[0][2].ToString();
                Session["to_imgurl"] = x.Tables[0].Rows[0][3].ToString();
                Session["my_imgurl"] = x.Tables[0].Rows[0][4].ToString();
                Session["cc_email"] = x.Tables[0].Rows[0][5].ToString();
                Session["title"] = x.Tables[0].Rows[0][6].ToString();
                Session["body"] = x.Tables[0].Rows[0][7].ToString();
                Session["att_url"] = x.Tables[0].Rows[0][8].ToString();
                Session["dt"] = x.Tables[0].Rows[0][9].ToString();
                // Label3.Text = Session["title"].ToString();
                //  Response.Redirect("~/inboxcontent.aspx?" + Session["msgid"].ToString());
            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Inbox.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/log-in.aspx");
        }
    }
}
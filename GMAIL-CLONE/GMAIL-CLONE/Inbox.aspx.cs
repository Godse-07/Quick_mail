using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Reflection.Emit;

namespace GMAIL_CLONE
{
    public partial class Inbox : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {




           
            if (Session["name"] != null && Session["name"].ToString() != "")
            {
                
                Label2.Text = Session["email"].ToString();

                Image1.ImageUrl = Session["img"].ToString();


            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }

            DataSet ds = Class1.fetch("select * from Message where to_email='" + Session["email"].ToString() + "'");
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            if (Request.QueryString["msgid"] != null)
            {
                DataSet x = Class1.fetch("select * from Message where msg_id='" + Request.QueryString["msgid"] + "'");
                if (x.Tables[0].Rows.Count != 0)
                {
                    Session["msgid"] = x.Tables[0].Rows[0][0].ToString();
                    Session["to_email"] = x.Tables[0].Rows[0][1].ToString();
                    Session["my_email"] = x.Tables[0].Rows[0][2].ToString();
                    Session["to_imgurl"] = x.Tables[0].Rows[0][3].ToString();
                    Session["my_imgurl"] = x.Tables[0].Rows[0][4].ToString();
                    Session["cc_email"] = x.Tables[0].Rows[0][5].ToString();
                    Session["title"] = x.Tables[0].Rows[0][6].ToString();
                    Session["body"] = x.Tables[0].Rows[0][7].ToString();
                    Session["att url"] = x.Tables[0].Rows[0][8].ToString();
                    Session["dt"] = x.Tables[0].Rows[0][9].ToString();
                   
                    Label3.Text = Session["dt"].ToString();
                    Label5.Text = Session["my_email"].ToString();
                    Label6.Text = Session["to_email"].ToString();
                    Label11.Text = Session["title"].ToString();
                    TextBox5.Text = Session["body"].ToString();
                    HyperLink1.NavigateUrl = Session["att_url"].ToString();
                    Response.Redirect("~/inboxcontent.aspx?"+Session["msgid"].ToString());
                }

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

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            // Your ImageButton1_Click event handling code here...
        }

        

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/sent-page.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Draft.aspx");
        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }


        protected void ImageButton4_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Setting-Pushan.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/log-in.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/INbox.aspx");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GMAIL_CLONE
{
    public partial class Draft1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = Class1.fetch("select * from Draft ");//where to_email='" + Session["to_email"].ToString() + "'");
            //Console.WriteLine("Test1");
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                //   Console.WriteLine("Test2");
            }



            //// Check if Session["name"] and Session["email"] are not null and not empty
            //if (Session["name"] != null && !string.IsNullOrEmpty(Session["name"].ToString()) &&
            //    Session["email"] != null && !string.IsNullOrEmpty(Session["email"].ToString()))
            //{
            //    // Set user details
            //    Label1.Text = Session["name"].ToString();
            //    Label2.Text = Session["email"].ToString() + "<br/>" + Session["mob"].ToString();
            //    Image1.ImageUrl = Session["img"].ToString();

            //    // Fetch messages for the current user (Session["email"])
            //    DataSet ds = Class1.fetch("select * from Message where to_email='" + Session["to_email"].ToString() + "'");
            //    Console.WriteLine("Test1");
            //    if (ds.Tables[0].Rows.Count != 0)
            //    {
            //        GridView1.DataSource = ds;
            //        GridView1.DataBind();
            //        Console.WriteLine("Test2");
            //    }

            //    // Check if there is a "msg_id" parameter in the query string
            //    if (Request.QueryString["msg_id"] != null)
            //    {
            //        // Fetch message details based on the "msgid"
            //        DataSet x = Class1.fetch("select * from Message where msg_id='" + Request.QueryString["msg_id"] + "'");
            //        if (x.Tables[0].Rows.Count != 0)
            //        {
            //            // Store message details in session variables for use in the content page
            //           // Session["msg_id"] = x.Tables[0].Rows[0][0].ToString();
            //           // Session["to_email"] = x.Tables[0].Rows[0][1].ToString();
            //           // Session["my_email"] = x.Tables[0].Rows[0][2].ToString();
            //           // Session["to_imgurl"] = x.Tables[0].Rows[0][3].ToString();
            //           // Session["my_imgurl"] = x.Tables[0].Rows[0][4].ToString();
            //           // Session["cc_email"] = x.Tables[0].Rows[0][5].ToString();
            //           // Session["title"] = x.Tables[0].Rows[0][6].ToString();
            //           // Session["body"] = x.Tables[0].Rows[0][7].ToString();
            //           // Session["att_url"] = x.Tables[0].Rows[0][8].ToString();
            //           // Session["dt"] = x.Tables[0].Rows[0][9].ToString();

            //            // Display message details in the content layer
            //            //layerc.Visible = true;
            //            //outerc.Visible = true;
            //            //innerc.Visible = true;
            //            //Label3.Text = Session["dt"].ToString();
            //            //Label5.Text = Session["myemail"].ToString();
            //            //Label6.Text = Session["toemail"].ToString();
            //            //Label11.Text = Session["title"].ToString();
            //            //TextBox5.Text = Session["body"].ToString();
            //            //HyperLink1.NavigateUrl = Session["atturl"].ToString();
            //            //  Response.Redirect("~/inboxcontent.aspx?"+Session["msgid"].ToString());
            //        }
            //    }
            //    else
            //    {
            //        // Hide the content layer when there is no "msgid" in the query string
            //        //layerc.Visible = false;
            //        //outerc.Visible = false;
            //        //innerc.Visible = false;
            //    }
            //}
            //else
            //{
            //    //        // Handle the case where Session["name"], Session["email"], or both are null or empty.
            //    //        // You can redirect the user to the login page or display an error message.
            //    //        // For example:
            //     //Response.Redirect("~/Default.aspx");
            //}

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

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/sent-page.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Inbox.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/log-in.aspx");
        }
    }
}
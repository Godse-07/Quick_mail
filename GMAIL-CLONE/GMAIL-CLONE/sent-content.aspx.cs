using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GMAIL_CLONE
{
    public partial class sent_content : System.Web.UI.Page
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

            string title = Request.QueryString["title"];

            if (!string.IsNullOrEmpty(title))
            {
                DataSet x = Class1.fetch("select * from Message where title='" + title + "'");

                if (x.Tables[0].Rows.Count != 0)
                {
                    txtToEmail.Text = x.Tables[0].Rows[0]["to_email"].ToString(); // Assuming there is a "to_email" column
                    Ccmail.Text = x.Tables[0].Rows[0]["cc_email"].ToString();
                    txtTitle.Text = x.Tables[0].Rows[0]["title"].ToString();
                    txtBody.Text = x.Tables[0].Rows[0]["body"].ToString();
                    txtDate.Text = x.Tables[0].Rows[0]["dt"].ToString();

                    string attachmentUrl = x.Tables[0].Rows[0]["att_url"].ToString();
                    hlAttachment.NavigateUrl = attachmentUrl;
                    hlAttachment.Text = "Download Attachment";
                }
                else
                {
                    // Handle the case where the message with the specified title is not found
                    Response.Write("Message not found.");
                }
            }
            else
            {
                // Handle the case where the title is not provided in the query string
                Response.Write("Title not provided.");
            }



        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Inbox.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/sent-page.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Draft.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Setting-Pushan.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/log-in.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GMAIL_CLONE
{



    public partial class draft_content : System.Web.UI.Page
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
                DataSet x = Class1.fetch("select * from Draft where title='" + title + "'");

                if (x.Tables[0].Rows.Count != 0)
                {
                    txtToEmail.Text = x.Tables[0].Rows[0]["to_email"].ToString(); // Assuming there is a "to_email" column
                    Ccmail.Text=x.Tables[0].Rows[0]["cc_email"].ToString();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/log-in.aspx");
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

      

        protected void btnSend_Click1(object sender, EventArgs e)
        {





            DataSet x = Class1.fetch("select * from user_det where Email='" + txtToEmail.Text + "'");

            if (x.Tables[0].Rows.Count != 0)
            {
                // Retrieve the email address from the TextBox
                string toEmail = txtToEmail.Text;

                //Response.Write("<script>alert('" + toEmail + "')</script>");

                // Initialize myemail with a default value (e.g., null)
                string myemail = null;

                // Check if the necessary session variable is available
                if (Session["email"] != null)
                {
                    myemail = Session["email"].ToString();
                   // Response.Write("<script>alert('" + myemail + "')</script>");
                }
                else
                {
                    // Handle the case where Session["Email"] is null or not set
                    // You can log an error, display a message to the user, or take appropriate action.
                    // For now, I'll just display an error message.
                  //  Response.Write("<script>alert('Session[\"email\"] is null or not set.')</script>");
                    return; // Exit the method since myemail is not set
                }

                DataSet p = Class1.fetch("select max(msg_id) from Message");
                int msgId = 1; // Default value if there are no records in the Message table

                if (p.Tables[0].Rows.Count != 0 && !p.Tables[0].Rows[0].IsNull(0))
                {
                    msgId = Convert.ToInt32(p.Tables[0].Rows[0][0]) + 1;
                  
                    //  Response.Write("<script>alert('" + msgId + "')</script>");
                }

                // Handle the case where no file is uploaded
                // You can display a message to the user or take other appropriate action.
                string attUrl = !string.IsNullOrEmpty(hlAttachment.NavigateUrl) ? hlAttachment.NavigateUrl : null;

               // Response.Write("<script>alert('" + attUrl + "')</script>");


                bool r = Class1.save("insert into Message(msg_id, to_email, my_email, to_imgurl, my_imgurl, cc_email, title, body, att_url, dt) values('" + msgId + "', '" + toEmail + "', '" + myemail + "', '" + Session["Img"].ToString() + "', '" + Image1.ImageUrl + "','" + Ccmail + "', '" + txtTitle.Text + "', '" + txtBody.Text + "', '" + attUrl + "', '" + System.DateTime.Now.ToLongDateString() + "')");

             //   Response.Write("<script>alert('" + r + "')</script>");

                if (r == true)
                {
                    Response.Write("<script>alert('SUCCESSFULLY')</script>");
                    txtTitle.Text = "";
                    txtBody.Text = "";
                    txtDate.Text = "";
                    txtToEmail.Text = "";
                    Ccmail.Text = "";
                }
            }







        }
    }
}
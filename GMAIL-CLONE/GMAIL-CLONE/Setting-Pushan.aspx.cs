using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection.Emit;


namespace GMAIL_CLONE
{

    public partial class Seting_Pushan : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null && Session["Name"].ToString() != "")
            {
                Label2.Text = Session["Email"].ToString();



                Image1.ImageUrl = Session["Img"].ToString();
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
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

        protected void ImageButton4_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Setting-Pushan.aspx");
        }

        



        protected void Button2_Click(object sender, EventArgs e)
        {

            

            string filename = FileUpload2.FileName;
            string ex = Path.GetExtension(FileUpload2.FileName).ToLower();

           

            Response.Write("<script>alert('"+ex+"')</script>");

            if (ex == ".jpg" || ex == ".jpeg" || ex == ".png")
            {
                


                
                string imgurl = "~/emailpics/" + filename;
                string imgurl1 = "~/pics/" + filename;
                Image2.ImageUrl = imgurl.ToString();
                bool r = Class1.save("update user_det set Password='" + TextBox8.Text + "',img='" + imgurl + "' where Email='" + Session["email"].ToString() + "'");


    

                
                if (r==true)
                {
                    FileUpload2.PostedFile.SaveAs(Server.MapPath("~/emailpics/") + filename);
                    FileUpload2.PostedFile.SaveAs(Server.MapPath("~/pics/") + filename);
                    Label5.Text = "Changes saved successfully";
                    Response.Redirect("~/log-in.aspx");
                }
                else
                {
                    TextBox8.Text = "";
                 
                    Label5.Text = "Changes not saved";
                }
            }




        }
    }
}
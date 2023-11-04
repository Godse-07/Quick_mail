using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GMAIL_CLONE
{
    public partial class Draft1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {




            layers.Visible = false;
            outers.Visible = false;
            inners.Visible = false;
            if (Session["name"] != null && Session["name"].ToString() != "")
            {


                Label2.Text = Session["email"].ToString();

                Image1.ImageUrl = Session["img"].ToString();


            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
            DataSet ds = Class1.fetch("select * from Draft where my_email='" + Session["email"].ToString() + "'");
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            if (Request.QueryString["msgid"] != null)
            {
                DataSet x = Class1.fetch("select * from Draft where msg_id='" + Request.QueryString["msgid"] + "'");
                if (x.Tables[0].Rows.Count != null)
                {
                    Session["msgid"] = x.Tables[0].Rows[0][0].ToString();
                    Session["toemail"] = x.Tables[0].Rows[0][1].ToString();
                    Session["myemail"] = x.Tables[0].Rows[0][2].ToString();
                    Session["toimgurl"] = x.Tables[0].Rows[0][3].ToString();
                    Session["myimgurl"] = x.Tables[0].Rows[0][4].ToString();
                    Session["title"] = x.Tables[0].Rows[0][6].ToString();
                    Session["body"] = x.Tables[0].Rows[0][7].ToString();
                    Session["atturl"] = x.Tables[0].Rows[0][8].ToString();
                    Session["dt"] = x.Tables[0].Rows[0][9].ToString();
                    Session["cc"] = x.Tables[0].Rows[0][5].ToString();
                    layerc1.Visible = true;
                    outerc1.Visible = true;
                    innerc1.Visible = true;
                    Label4.Text = Session["dt"].ToString();
                    Label6.Text = Session["toemail"].ToString();
                    Label7.Text = Session["myemail"].ToString();
                    Label11.Text = Session["title"].ToString();
                    TextBox5.Text = Session["body"].ToString();
                    HyperLink1.NavigateUrl = Session["atturl"].ToString();
                }
            }
            else
            {
                layerc1.Visible = false;
                outerc1.Visible = false;
                innerc1.Visible = false;
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet x = Class1.fetch("select * from user_det where Email='" + Label6.Text + "'");
            if (x.Tables[0].Rows.Count != 0)
            {
                //Session["email"] = x.Tables[0].Rows[0][3].ToString();
                Session["img1"] = x.Tables[0].Rows[0][7].ToString();
                if (Session["att_url"] != null)
                {

                    bool r = Class1.save("insert into msg(to_email,my_email,to_imgurl,my_imgurl,cc_email,title,body,att_url,dt) values('" + Label6.Text + "','" + Label7.Text + "','" + Session["toimgurl"].ToString() + "','" + Session["myimgurl"].ToString() + "','" + Session["cc"].ToString() + "','" + Label11.Text + "','" + TextBox5.Text + "','" + Session["atturl"].ToString() + "','" + System.DateTime.Now.ToLongDateString() + "')");
                    if (r == true)
                    {

                        Label12.Text = "Mail has been sent successfully!";
                    }
                    else
                    {
                        Label12.Text = "Mail not sent";
                    }
                }

            }
            else
            {
                // string myemail = Session["email"].ToString();
                bool r = Class1.save("insert into msg(to_email,my_email,to_imgurl,my_imgurl,cc_email,title,body,dt) values('" + Label6.Text + "','" + Label7.Text + "','" + Session["toimgurl"].ToString() + "','" + Session["myimgurl"].ToString() + "','" + Session["cc"].ToString() + "','" + Label11.Text + "','" + TextBox5.Text + "','" + System.DateTime.Now.ToLongDateString() + "')");
                if (r == true)
                {
                    Label12.Text = "Mail has been sent successfully!";
                }
                else
                {
                    Label12.Text = "Mail not sent";
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string filename = FileUpload2.FileName;
            string ex = Path.GetExtension(filename);
            if (ex == ".jpg" || ex == ".jpeg" || ex == ".png")
            {
                string imgurl = "~/emailpics/" + filename;
                string imgurl1 = "~/pics/" + filename;

                Image2.ImageUrl = imgurl.ToString();
                bool r = Class1.save("update user1 set Password='" + TextBox8.Text + "',img='" + imgurl + "' where email='" + Session["email"].ToString() + "'");
                bool s = Class1.save("update msg set my_imgurl='" + imgurl1 + "' where my_email='" + Session["email"].ToString() + "'");
                bool t = Class1.save("update msg set to_imgurl='" + imgurl1 + "' where to_email='" + Session["email"].ToString() + "'");
                if (r == true && s == true && t == true)
                {
                    layers.Visible = true;
                    outers.Visible = true;
                    inners.Visible = true;
                    FileUpload2.PostedFile.SaveAs(Server.MapPath("~/emailpics/") + filename);
                    FileUpload2.PostedFile.SaveAs(Server.MapPath("~/pics/") + filename);
                    Label3.Text = "Changes saved successfully";
                }
                else
                {
                    TextBox8.Text = "";
              
                }

            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Setting-Pushan.aspx");
        }
    }
}
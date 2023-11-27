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
    public partial class sent_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["Name"] != null && Session["Name"].ToString() != "")
            //{
            //    Label2.Text = Session["Email"].ToString();

            //    //Label2.Text = Session["Email"].ToString(); //+ "<br/>" + Session["mob"].ToString();

            //    Image1.ImageUrl = Session["Img"].ToString();
            //}
            //else
            //{
            //    Response.Redirect("~/Default.aspx");
            //}


            //DataSet ds = Class1.fetch("select to_imgurl,to_email,title,dt from Message ");//where to_email='" + Session["to_email"].ToString() + "'");
            ////Console.WriteLine("Test1");
            //if (ds.Tables[0].Rows.Count != 0)
            //{
            //    GridView1.DataSource = ds;
            //    GridView1.DataBind();
            //    //   Console.WriteLine("Test2");
            //}






            /*layerc1.Visible = false;
            outerc1.Visible = false;
            innerc1.Visible = false;

            if (Session["name"] != null && Session["name"].ToString() != "")
            {
               

                Label2.Text = Session["email"].ToString();

                Image1.ImageUrl = Session["img"].ToString();
                 layerc1.Visible = false;
                 outerc1.Visible = false;
                 innerc1.Visible = false;


            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
            DataSet ds = Class1.fetch("select * from Message where my_email='" + Session["email"].ToString() + "'");
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            if (Request.QueryString["msgid"] != null)
            {
                DataSet x = Class1.fetch("select * from Message where msg_id='" + Request.QueryString["msgid"] + "'");
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
            }*/







           
            if (Session["name"] != null && Session["name"].ToString() != "")
            {
              
                Label2.Text = Session["email"].ToString();

                Image1.ImageUrl = Session["img"].ToString();
                /* layerc1.Visible = false;
                 outerc1.Visible = false;
                 innerc1.Visible = false;*/


            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
            DataSet ds = Class1.fetch("select * from Message where my_email='" + Session["email"].ToString() + "'");
            if (ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            if (Request.QueryString["msgid"] != null)
            {
                DataSet x = Class1.fetch("select * from Message where msg_id='" + Request.QueryString["msgid"] + "'");
                if (x.Tables[0].Rows.Count != null)
                {
                    Session["msg_id"] = x.Tables[0].Rows[0][0].ToString();
                    Session["to_email"] = x.Tables[0].Rows[0][1].ToString();
                    Session["my_email"] = x.Tables[0].Rows[0][2].ToString();
                    Session["to_imgurl"] = x.Tables[0].Rows[0][3].ToString();
                    Session["my_imgurl"] = x.Tables[0].Rows[0][4].ToString();
                    Session["title"] = x.Tables[0].Rows[0][6].ToString();
                    Session["body"] = x.Tables[0].Rows[0][7].ToString();
                    Session["att_url"] = x.Tables[0].Rows[0][8].ToString();
                    Session["dt"] = x.Tables[0].Rows[0][9].ToString();
                   
                }
            }
           
            /*  else
              {
                  Response.Redirect("~/Default2.aspx");
              }*/

        







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
            Response.Redirect("~/Inbox.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Draft.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/log-in.aspx");
        }

       

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Setting-Pushan.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GMAIL_CLONE
{
    public partial class Chat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            get_User();
            Load_Frends();
        }

        public void get_User()
        {
            try
            {
                Label1.Text = Session["Admin"].ToString();
                Image1.ImageUrl = Session["img"].ToString();

            }
            catch (Exception e)
            {
            }
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {

            string str1 = "insert into Chatbox values('" + Label1.Text + "','" + Label2.Text + "','" + TextBox1.Text + "','" + Image3.ImageUrl.ToString() + "')";
            bool r = Class1.save(str1);


            if (r == true)
            {
                TextBox1.Text = "";
                LoadChatbox();
            }
        }

        public void Load_Frends()
        {

            string str = "select DISTINCT email,img from user1 where email!='" + Label1.Text + "'";

            DataSet x = Class1.fetch(str);
            //DataList2.DataSource = ds;
            //DataList2.DataBind();
            DataList1.DataSource = x;
            DataList1.DataBind();

        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton lBtn = sender as LinkButton;
            string id = ((LinkButton)sender).CommandArgument.ToString();
            //Label1.Text = id;
            Label2.Text = lBtn.Text;

            DataListItem item = (DataListItem)lBtn.NamingContainer;
            Image NameLabel = (Image)item.FindControl("Image2");
            string url = NameLabel.ImageUrl.ToString();
            Image3.ImageUrl = url;
            LoadChatbox();
        }


        protected void Timer1_Tick(object sender, EventArgs e)
        {
            LoadChatbox();
        }
        protected void DataList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void LoadChatbox()
        {


            string str2 = "select * from Chatbox where Sender='" + Label1.Text + "' and Reciever='" + Label2.Text + "' or Sender='" + Label2.Text + "' and Reciever='" + Label1.Text + "'" + " ORDER BY ID";
            DataSet ds = Class1.fetch(str2);
            DataList3.DataSource = ds;
            DataList3.DataBind();


            //ScriptManager.RegisterStartupScript(this.Page, typeof(Panel), "PanelChatContent", ";ScrollToBottom();", true);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            TextBox1.Text = DateTime.Now.ToString();
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            ListBox2.Items.Add(TextBox2.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //ListBox2.Items.Remove(ListBox2.SelectedItem);
            int index = ListBox2.SelectedIndex;
            ListBox2.Items.RemoveAt(index);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int index = ListBox2.SelectedIndex;
            ListBox2.Items[index].Text = TextBox2.Text;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int index = ListBox2.SelectedIndex;
            
            TextBox2.Text = ListBox2.SelectedItem.Text;
        }
    }
}
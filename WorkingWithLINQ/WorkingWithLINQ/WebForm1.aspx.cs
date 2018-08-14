using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithLINQ
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //implicitly typed local variables
            //var n;
            //var n=null;
            //var cannot be specified as return type
            //input parameters cannot be of type var
            //data members cannot be of type var

            //var name="abc"

            //int? salary=null; //nullable type
            int? salary = 2000;
            //Nullable<int> salary2 = null;
            show(salary);

            //var n = 10;
            //var name = "abc";
            //var ary = new int[] { 1, 22, 33, 44 };

            //var answer=abc

        }
        void show(int? data)
        {

            if (data.HasValue)
                Response.Write(data.Value);

        }
    }
}
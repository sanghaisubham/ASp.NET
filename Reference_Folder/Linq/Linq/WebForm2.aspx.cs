using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var list = Enumerable.Range(1, 100);

            //var result = from c in list where c % 2 == 0 select c;
            //var result = (from c in list where c % 2 != 0 select c).Take(5);
            //var result = (from c in list where c % 2 != 0 select c).Skip(5).Take(5);
            //var result = (from c in list where c % 2 != 0 select c).Skip(5).Take(5).OrderByDescending(delegate (int c) { return c; });
            var result = (from c in list where c % 2 != 0 select c).Skip(5).Take(5).OrderBy(c => c);
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        

            foreach (var r in result)
            {
                Response.Write(r + "<br/>");
            }

        }      
        public delegate bool CompareDel(int x, int y);
     /*   protected void Page_Load(object sender, EventArgs e)
        {
            //CompareDel del = new CompareDel(Compare);
            //CompareDel del = delegate (int x, int y) { return x > y; };
            //CompareDel del =  (int x, int y)=> { return x > y; };
            //CompareDel del = (x,y) => { return x > y; };
            //CompareDel del = (x, y) =>  x > y; 
            Func<int, int, bool> del = (x, y) => x > y;
            bool result=del.Invoke(100, 20);

        }*/
        public bool Compare(int x,int y)
        {
            return x > y;
        }
    }
}
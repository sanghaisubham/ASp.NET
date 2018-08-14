using System;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  LINQ  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * LINQ =>              Only works in SQL Server.
 * Entity Framework=>   Works with any RDBMS.
 * 
 
     */

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithLINQ
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //LINQ can work on any collections

            var list = Enumerable.Range(1, 100);
            //var result = list.Where(c=>c%2==0).ToList();

            //var result = list.Where(c => c % 2 == 0).Skip(4).Take(4);
            //var result = from c in list where c % 2 == 0 select c;
            //var result = list.Where(c => c % 2 != 0).SkipWhile(p => p < 50);
            var sum = list.Where(c => c < 50).Sum();

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            string[] str1 = { "red", "green", "yellow", "gray", "orange" };
            string[] str2 = { "red", "green", "blue" };

            //var result = str1.Intersect(str2);
           // var result = str1.Except(str2);

            var result = str1.Union(str2);
            foreach(var r in result)
            {
                Response.Write(r + "<br/>");
            }
        }
    }
}
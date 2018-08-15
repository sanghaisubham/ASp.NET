using Linq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FillGrid();
        }
        newdbEntities context = new newdbEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            emp em = new emp();
            em.code = 100;
            em.name = "Mahesh";
            em.salary = 23000;
            em.deptid = 101;

            context.emps.Add(em);
            context.SaveChanges();

            FillGrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // emp em = (from c in context.emps where c.code == 99 select c).FirstOrDefault();
            var em = context.emps.Where(c => c.code == 100).FirstOrDefault();
            em.name = "$$$$$$$$$$$$$";
            em.salary = 1111;

            context.SaveChanges();
            FillGrid();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var code = Convert.ToInt32(TextBox1.Text);
            // var em = context.emps.Single(c => c.code == code);
            var em = context.emps.SingleOrDefault(c => c.code == code);
            if (em != null)
            {
                context.emps.Remove(em);
                context.SaveChanges();
                FillGrid();
            }
            else
                Label1.Text = "No record found..";
        }
        void FillGrid()
        {
            GridView1.DataSource = context.emps.ToList();
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //var result=from c in context.emps where c.salary < 4000
            //           select new { c.name,c.salary,c.deptid };


            /*  var result = from c in context.emps
                           where c.salary < 4000 
                           orderby c.deptid descending
                           select new { c.name, c.salary, c.deptid };

             */
            /*   var result = context.emps.Where(c => c.salary < 4000).
                    OrderByDescending(p => p.name).
                    Select(c=>new {c.salary,c.name });
                */

            /*    var result = from p in context.emps
                             join q in context.deptts
                    on
                    p.deptid equals q.deptid
                             where q.name == "Sales"
                             select
                             new { p.name,depttname=q.name,p.salary,q.strength };

             */
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //var result = context.emps.Join(context.deptts, p => p.deptid, q => q.deptid, (r1,r2) => new {r1.name,dptname=r2.name,r1.salary });
            /*
            var result = from p in context.emps
                         group p.salary
            by p.deptid
                       into agg
                         select new {agg.Key,sumsal=agg.Sum(c=>c.Value) };
          */
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            var result = from p in
                             context.deptts
                         join
                           q in context.emps
                           on
                           p.deptid equals q.deptid
                         group q.salary by p.name
                             into
                               container
                         select
                         new { container.Key,sumsal= container.Sum() };
    GridView1.DataSource = result.ToList();
            GridView1.DataBind();
        }
    }
}
/*
 * POSTBACK=> In The Official Microsoft ASP.NET Site is similar submitting of a 
 form for server. The name itself indicates posting something back (PostBack) 
 for checking some data or credentials with existing data 
 (which is in server backside). 
 The details will be checked and the control comes back to the page.

 =>Data collected from the same page is sent to the server for processing.
  e.g clicking on submit after filling the details will do postback operation.
  To check it in page_load you can write (Page.IsPostback).

  */

/*
CROSS PAGE POSTBACK =>Data is being collected in 2 or more pages 
and we can move to the next page after entering data in first page
and we can create some controls in the first page to post the data to
another page i.e. target page.

=>In cross page posting the data that we have entered in one page 
  is sent to another page where you do the post back.

e.g-In a form there are 2 pages 1st one our personal details and 
  2nd one work experience , so we have to get the data from the first page 
  through cross page posting with the help of PreviousPage.
  FindControl("id"); in the page_Load of the 2nd page.



*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Two : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                if (PreviousPage.IsCrossPagePostBack)
                {
                    Response.Write("Cross Page PostBack");
                    One one = (One)PreviousPage;
                    Response.Write("<br/>" + one.Data);
                }


            }
            else
            {
                Response.Write("Page Requested Directly");
                //In Redirect we cant access the data .
                //Because it is not sent 

                //One one = (One)PreviousPage;
                //Response.Write("<br/>" + one.Data);
            }
        }
    }
}
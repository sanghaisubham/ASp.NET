/*ClientSide Vs ServerSide Validation
 
 * Client Side validation can be very easily bypassed by disabiling JS on client browser.
 * IF JS is disabeled and if we dont have server side validation,
   there can be diff threats ranging from storing invalid data to security vulnerabilities.
 * Client Side validation provides better user experience as it reduces the unnecessary
   round trips between client and server.
 * Server Side validation should always be there irrespective of whether client
   side validation is present or not.

 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class CustomValidatorExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int age=Convert.ToInt32(args.Value);
            if (age < 10 || age > 80)
                args.IsValid = false;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
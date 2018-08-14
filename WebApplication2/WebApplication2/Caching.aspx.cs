/*Output Cache
 * varybyparam :Specifies the list of parameters which the cache should be varied by.
 
  * varybycontrol:varies the cache depending on the value of specified control.
   i.e. Content of page varies according to the value of the control(dropdownlist)

  * varybycustom:Helps to handle variations by ourself,by setting a custom string.
  
   * varybyheader:Vary the content  based on one or more  headers that browser send.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Caching : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
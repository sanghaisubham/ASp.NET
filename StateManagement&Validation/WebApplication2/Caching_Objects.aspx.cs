/*
  3 instances of the current date is placed in an ArrayList, 
  and the list is then cached using the Cache object. On each page load, 
  the Cache is checked to see if it contains our ArrayList, 
  using a name we have provided. If it's not, the list is generated, 
  filled and cached. If the ArrayList is already in the cache, we pull it out
  and cast it to the correct type (everything is stored as object types). 
  No matter where we get the list from, we iterate through it and output 
  each value.

Most of it should be pretty straight forward, 
except for the line where we add the list to the Cache. 
The Add method takes a bunch of parameters, and I will try to explain all of them.

First of all, the key we wish to store our object by, in this case we simply 
call it "datestamps". The key is used to get the object back from the Cache.

Next parameter is the object we wish to cache, so that goes without explaining.

Next up is the CacheDependency parameter. It can be used to tell ASP.NET that the
cached item depends on other items, allowing ASP.NET to invalidate the cache if 
one of these items changes.

The following two parameters tells ASP.NET how and when the item should expire
in the cache. The first one specifies an absolute expiration, meaning that the
item will expire at a certain time of day. This is usually not what you want, 
so we set it to NoAbsoluteExpiration. Next we can specify a sliding expiration, 
which means that the item will expire after a certain amount of time, based on 
when the item is placed in the cache. The TimeSpan class is used, and we specify
that it should expire after 0 hours, 0 minutes and 60 seconds. A priority can be
set for the item in the cache. This is used when ASP.NET is removing items from
the cache - items with a lower priority are removed first.

The last parameter allows us to specify a callback function for the item, 
which will be called once the item is removed from the cache, in case you 
need that. We simply specify a null value.

So, as you can see, storing items by using the Cache object is really easy.
Of course, we don't really earn any performance in this example, 
but only the imagination is the limit here. One of the most common 
practices are storing objects retrieved from a database in the cache,
so save resources on the database machine and allow for faster loading pages.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Caching_Objects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList datestamps;
            if (Cache["datestamps"] == null)
            {
                datestamps = new ArrayList();
                datestamps.Add(DateTime.Now);
                datestamps.Add(DateTime.Now);
                datestamps.Add(DateTime.Now);

                Cache.Add(
                    "datestamps", 
                    datestamps, 
                    null, 
                    System.Web.Caching.Cache.NoAbsoluteExpiration,
                    new TimeSpan(0, 0, 60), 
                    System.Web.Caching.CacheItemPriority.Default, null);
                
            }
            else
                datestamps = (ArrayList)Cache["datestamps"];
            foreach (DateTime dt in datestamps)
                Response.Write(dt.ToString() + "<br />");
        }
    }
}
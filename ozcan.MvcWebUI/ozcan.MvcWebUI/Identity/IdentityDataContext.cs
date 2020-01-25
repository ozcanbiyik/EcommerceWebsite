
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ozcan.MvcWebUI.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection")
        {

        }
    }
}
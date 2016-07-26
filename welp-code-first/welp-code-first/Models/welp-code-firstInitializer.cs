using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class welp_code_firstInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<welp_code_firstContext>
    {
        protected override void Seed(welp_code_firstContext context)
        {

            //context.Users.Add(new User() { Username = "MilesMorales", Email = "SpdrMn@PwrRsblty.com" });
            //context.Users.Add(new User() { Username = "PeterParker", Email = "AmzngSpdrMn@PwrRsblty.com" });
            base.Seed(context);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ActionPlatform.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext()
            : base("ModelConnection") { }

        public DbSet<AccessToken> AccessTokenSet { get; set; }

        public DbSet<User> UserSet { get; set; }
    }
}
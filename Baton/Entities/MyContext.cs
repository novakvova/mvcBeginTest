using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Baton.Entities
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
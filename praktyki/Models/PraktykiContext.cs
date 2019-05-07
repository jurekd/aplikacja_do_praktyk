using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace praktyki.Models
{
    public class PraktykiContext:DbContext
    {
        public DbSet<Praktyki> Praktyki { get; set; }
    }
}
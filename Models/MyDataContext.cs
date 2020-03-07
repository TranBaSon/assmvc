using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PenalizeManagement.Models
{
    public class MyDataContext : DbContext
    {
        public MyDataContext() : base("MyConnectionString")
        {

        }
        public DbSet<Penalize> Penalizes { get; set; }
    }
}
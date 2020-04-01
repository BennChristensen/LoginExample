using LoginExample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginExample.Storage
{
    public class UserStorage : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LoginExample.Models
{
    public class User
    {
        public int Id { get; set; }
        [DisplayName("bruger navn")]
        public String UserName { get; set; }
        public String RealName { get; set; }
        public String Role { get; set; }
    }
}
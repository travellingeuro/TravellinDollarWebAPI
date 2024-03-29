﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravellinDollarWebAPI.Models
{
    public partial class Users
    {
        public Users()
        {
            Uploads = new HashSet<Uploads>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public sbyte? EmailConfirmed { get; set; }
        public string Role { get; set; }
        public string Country { get; set; }
        public string Alias { get; set; }
        public sbyte? Keepmeinformed { get; set; }
        public sbyte? Keeplogged { get; set; }
        public ICollection<Uploads> Uploads { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravellinDollarWebAPI.Models
{
    public partial class SMS
    {
        public SMS()
        {

        }

        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
    }
}
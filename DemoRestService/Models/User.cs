﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoRestService.Models
{
    public class User
    {
        public string username { get; set; }
        public string passwordhash { get; set; }
    }
}
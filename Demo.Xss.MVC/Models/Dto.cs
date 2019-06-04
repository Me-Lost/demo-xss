﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Xss.MVC.Models
{
    public class Dto
    {
        
        //[AllowHtml]
        public string Name { get; set; }

        public string Description { get; set; }

        public Dto()
        {
            Name = string.Empty;
            Description = string.Empty;
        }
    }
}
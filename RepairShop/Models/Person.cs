﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepairShop.Models
{
    public abstract class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
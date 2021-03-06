﻿using RepairShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepairShop.ViewModels
{
    public class VMRepairOrderEdit
    {
        public RepairOrder RepairOrder { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Technician> Technicians { get; set; }
        public int? CustomerId { get; set; }
        public int? TechnicianId { get; set; }
    }
}
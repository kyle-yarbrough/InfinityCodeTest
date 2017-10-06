using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfinityCodeTest.Domain.Entities;

namespace InfinityCodeTest.WebUI.Models
{
    public class DeliveryScheduleViewModel
    {
        public Delivery[] Deliveries { get; set; }
    }
}
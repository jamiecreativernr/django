using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecycleTroop_Database_Interface.Models
{
    public class Shipments
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public float Quantity { get; set; }
        public string Comments { get; set; }
    }
}
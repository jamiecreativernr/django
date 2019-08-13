using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecycleTroop_Database_Interface.Models
{
    public class Clients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Domain { get; set; }
        public string PAddress { get; set; }
        public string ContactPerson { get; set; }
        public string Comments { get; set; }
    }
}
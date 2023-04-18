using System;
using System.Collections.Generic;
using System.Linq;

namespace XyConstruction.Models
{
    public class ProjectContact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

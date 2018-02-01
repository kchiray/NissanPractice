using System;
using System.Collections.Generic;

namespace NissanPractice.Models
{
    public partial class Location
    {
        public Location()
        {
            Customers = new HashSet<Customers>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public ICollection<Customers> Customers { get; set; }
    }
}

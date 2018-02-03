using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NissanPractice.Models
{
    public partial class Orders
    {
        public int Id { get; set; }        
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }
        public int? CustomerId { get; set; }
        public Customers Customer { get; set; }
        public Invoice Invoice { get; set; }
    }
}

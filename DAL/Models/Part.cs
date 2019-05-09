using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public partial class Part
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public int ManufacturerID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIHF.Web.Models
{
    public class Part
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public int ManufacturerID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SampleExport.Models
{
    internal class Product
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "price")]
        public decimal Price { get; set; }

        [DataMember(Name = "qty")]
        public int Quantity { get; set; }
    }
}

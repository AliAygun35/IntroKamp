using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product // entity(varlık)
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}

// Bu tür classlarda sadece özellik olur! "prop" yazarak tab'larız!
// Entity, product yani varlığımız olan classımız.
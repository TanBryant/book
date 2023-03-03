using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSchema.Responsitory
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }
        public virtual Customers Customers { get; set; }

        [ForeignKey("EmployeeID")]
        public int EmployeeID { get; set; }
        public virtual Employees Employees { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set;}

        public DateTime? ShippedDate { get; set;}
        public int ShipVia { get; set; }

        public string Freight { get; set;}

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipRegion { get; set; }

        public string ShipPostalCode { get; set; }
        
        public string ShipCountry { get; set; }

        public virtual List<OrderDetails> orderDetails { get; set; }


    }
}

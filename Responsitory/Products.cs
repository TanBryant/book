using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSchema.Responsitory
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        public string ProductName { get; set; }


        [ForeignKey(nameof(SuppllersID))]
        public int SuppllersID { get; set; }
        public virtual Suppllers Suppllers { get; set; }


        [ForeignKey(nameof(CategoryID))]
        public int CategoryID { get; set; }
        public virtual Categories Categories { get; set; }

        public int QuantityPerUnit { get; set; }

        public double UnitPrice { get; set; }

        public double UnitsInStock { get; set; }

        public double UnitsOnOrder { get; set; }

        public int ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public virtual List<OrderDetails> orderDetails { get; set; }
    }
}

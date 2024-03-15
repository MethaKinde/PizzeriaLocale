namespace PizzeriaLocale.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderItemID { get; set; }

        public int? OrderSummaryID { get; set; }

        public int? ProductID { get; set; }

        public int Quantity { get; set; }

        public virtual OrderSummary OrderSummary { get; set; }

        public virtual Product Product { get; set; }
    }
}

namespace PizzeriaLocale.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderSummary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderSummary()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderSummaryID { get; set; }

        public int? UserID { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(100)]
        public string DeliveryAddress { get; set; }

        public string Notes { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual User User { get; set; }
    }
}

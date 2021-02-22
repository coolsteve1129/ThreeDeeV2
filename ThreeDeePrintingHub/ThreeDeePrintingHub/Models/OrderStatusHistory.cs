using System;
using System.Collections.Generic;

#nullable disable

namespace ThreeDeePrintingHub.Models
{
    public partial class OrderStatusHistory
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual Order Order { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
    }
}

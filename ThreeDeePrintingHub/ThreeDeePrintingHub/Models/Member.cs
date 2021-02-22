using System;
using System.Collections.Generic;

#nullable disable

namespace ThreeDeePrintingHub.Models
{
    public partial class Member
    {
        public Member()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ShipAddr { get; set; }
        public string BillAddr { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDesigner { get; set; }
        public int SecurityRoleId { get; set; }

        public virtual SecurityRole SecurityRole { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

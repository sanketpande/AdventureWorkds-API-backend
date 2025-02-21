﻿using System;
using System.Collections.Generic;

namespace AdventureWorkds_API_backend
{
    public partial class Store
    {
        public Store()
        {
            Customers = new HashSet<Customer>();
        }

        public int BusinessEntityId { get; set; }
        public string Name { get; set; } = null!;
        public int? SalesPersonId { get; set; }
        public string? Demographics { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; } = null!;
        public virtual SalesPerson? SalesPerson { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}

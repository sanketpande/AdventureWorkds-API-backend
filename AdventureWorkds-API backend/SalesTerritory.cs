﻿using System;
using System.Collections.Generic;

namespace AdventureWorkds_API_backend
{
    public partial class SalesTerritory
    {
        public SalesTerritory()
        {
            Customers = new HashSet<Customer>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            SalesPeople = new HashSet<SalesPerson>();
            SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
            StateProvinces = new HashSet<StateProvince>();
        }

        public int TerritoryId { get; set; }
        public string Name { get; set; } = null!;
        public string CountryRegionCode { get; set; } = null!;
        public string Group { get; set; } = null!;
        public decimal SalesYtd { get; set; }
        public decimal SalesLastYear { get; set; }
        public decimal CostYtd { get; set; }
        public decimal CostLastYear { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual CountryRegion CountryRegionCodeNavigation { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<SalesPerson> SalesPeople { get; set; }
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public virtual ICollection<StateProvince> StateProvinces { get; set; }
    }
}

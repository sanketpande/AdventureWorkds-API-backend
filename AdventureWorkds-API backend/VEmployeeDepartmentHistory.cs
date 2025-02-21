﻿using System;
using System.Collections.Generic;

namespace AdventureWorkds_API_backend
{
    /// <summary>
    /// Returns employee name and current and previous departments.
    /// </summary>
    public partial class VEmployeeDepartmentHistory
    {
        public int BusinessEntityId { get; set; }
        public string? Title { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string? Suffix { get; set; }
        public string Shift { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string GroupName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

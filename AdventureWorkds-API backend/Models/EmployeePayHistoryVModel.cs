﻿namespace AdventureWorkds_API_backend.Models
{
    public class EmployeePayHistoryVModel
    {
        /// <summary>
        /// Employee identification number. Foreign key to Employee.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }
        /// <summary>
        /// Date the change in pay is effective
        /// </summary>
        public DateTime RateChangeDate { get; set; }
        /// <summary>
        /// Salary hourly rate.
        /// </summary>
        public decimal Rate { get; set; }
        /// <summary>
        /// 1 = Salary received monthly, 2 = Salary received biweekly
        /// </summary>
        public byte PayFrequency { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}

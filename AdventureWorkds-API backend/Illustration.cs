﻿using System;
using System.Collections.Generic;

namespace AdventureWorkds_API_backend
{
    /// <summary>
    /// Bicycle assembly diagrams.
    /// </summary>
    public partial class Illustration
    {
        public Illustration()
        {
            ProductModelIllustrations = new HashSet<ProductModelIllustration>();
        }

        /// <summary>
        /// Primary key for Illustration records.
        /// </summary>
        public int IllustrationId { get; set; }
        /// <summary>
        /// Illustrations used in manufacturing instructions. Stored as XML.
        /// </summary>
        public string? Diagram { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }
    }
}

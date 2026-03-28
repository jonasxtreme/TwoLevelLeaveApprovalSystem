using System;
using System.Collections.Generic;

namespace TwoLevelLeaveApprovalSystem.Models
{
    /// <summary>
    /// Role entity model
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Unique role identifier
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Role name (Employee, Manager, Admin)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Role description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Whether this role is active
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Record creation timestamp
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Last update timestamp
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        // Navigation Properties

        /// <summary>
        /// Employees with this role
        /// </summary>
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
using System;
using System.Collections.Generic;

namespace SoftUni
{
    public partial class Project
    {
        public Project()
        {
            EmployeeProjects = new HashSet<EmployeesProjects>();
        }

        public int ProjectId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<EmployeesProjects> EmployeeProjects{ get; set; }
    }
}

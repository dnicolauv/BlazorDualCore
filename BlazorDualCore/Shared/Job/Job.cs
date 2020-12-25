using System;

namespace BlazorDualCore.Shared
{
    public class Job : Base
    {
        public Employer Employer { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
        public Sector Sector { get; set; }
        public Status Status { get; set; }
        public decimal Salary { get; set; }
        public DateTime PublishDate { get; set; }
        public EmploymentType EmploymentType { get; set; }
    }
}

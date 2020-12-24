using System.Collections.Generic;

namespace BlazorDualCore.Shared
{
    public class Employer
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Sector Sector { get; set; }
        public Location Location { get; set; }
        public string LogoUrl { get; set; }
        public Status Status { get; set; }
        public IEnumerable<Job> Jobs { get; set; }
    }
}
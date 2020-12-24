using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDualCore.Shared.Data
{
    public class EmployeeService
    {
            public IEnumerable<Employee> Get(string search = null)
            {
                var employees = new List<Employee>()
            {
                new Employee()
                {
                    Name = "Jane Cooper",
                    Email = "jane.cooper@example.com",
                    Title = "Regional Paradigm Technician",
                    Department = "Optimization",
                    Status = "Active",
                    Role = "Admin",
                    AvatarUrl = "https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                },
                new Employee()
                {
                    Name = "Cody Fisher",
                    Email = "cody.fisher@example.com",
                    Title = "Product Directives Officer",
                    Department = "Intranet",
                    Status = "Active",
                    Role = "Owner",
                    AvatarUrl = "https://images.unsplash.com/photo-1570295999919-56ceb5ecca61?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                },
                new Employee()
                {
                    Name = "Esther Howard",
                    Email = "esther.howard@example.com",
                    Title = "Forward Response Developer",
                    Department = "Directives",
                    Status = "Active",
                    Role = "Member",
                    AvatarUrl = "https://images.unsplash.com/photo-1520813792240-56fc4a3765a7?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                },
                new Employee()
                {
                    Name = "Jenny Wilson",
                    Email = "jenny.wilson@example.com",
                    Title = "Central Security Manager",
                    Department = "Program",
                    Status = "Active",
                    Role = "Member",
                    AvatarUrl = "https://images.unsplash.com/photo-1498551172505-8ee7ad69f235?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                },
                new Employee()
                {
                    Name = "Kristin Watson",
                    Email = "kristin.watson@example.com",
                    Title = "Lead Implementation Liaison",
                    Department = "Mobility",
                    Status = "Active",
                    Role = "Admin",
                    AvatarUrl = "https://images.unsplash.com/photo-1532417344469-368f9ae6d187?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                },
                new Employee()
                {
                    Name = "Cameron Williamson",
                    Email = "cameron.williamson@example.com",
                    Title = "Internal Applications Engineer",
                    Department = "Security",
                    Status = "Active",
                    Role = "Member",
                    AvatarUrl = "https://images.unsplash.com/photo-1566492031773-4f4e44671857?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                },

                new Employee()
                {
                    Name = "Jane Cooper",
                    Email = "jane.cooper@example.com",
                    Title = "Regional Paradigm Technician",
                    Department = "Optimization",
                    Status = "Active",
                    Role = "Admin",
                    AvatarUrl = "https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                },
                new Employee()
                {
                    Name = "Cody Fisher",
                    Email = "cody.fisher@example.com",
                    Title = "Product Directives Officer",
                    Department = "Intranet",
                    Status = "Active",
                    Role = "Owner",
                    AvatarUrl = "https://images.unsplash.com/photo-1570295999919-56ceb5ecca61?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                },
                new Employee()
                {
                    Name = "Esther Howard",
                    Email = "esther.howard@example.com",
                    Title = "Forward Response Developer",
                    Department = "Directives",
                    Status = "Active",
                    Role = "Member",
                    AvatarUrl = "https://images.unsplash.com/photo-1520813792240-56fc4a3765a7?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                },
                new Employee()
                {
                    Name = "Jenny Wilson",
                    Email = "jenny.wilson@example.com",
                    Title = "Central Security Manager",
                    Department = "Program",
                    Status = "Active",
                    Role = "Member",
                    AvatarUrl = "https://images.unsplash.com/photo-1498551172505-8ee7ad69f235?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                },
                new Employee()
                {
                    Name = "Kristin Watson",
                    Email = "kristin.watson@example.com",
                    Title = "Lead Implementation Liaison",
                    Department = "Mobility",
                    Status = "Active",
                    Role = "Admin",
                    AvatarUrl = "https://images.unsplash.com/photo-1532417344469-368f9ae6d187?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                },
                new Employee()
                {
                    Name = "Cameron Williamson",
                    Email = "cameron.williamson@example.com",
                    Title = "Internal Applications Engineer",
                    Department = "Security",
                    Status = "Active",
                    Role = "Member",
                    AvatarUrl = "https://images.unsplash.com/photo-1566492031773-4f4e44671857?ixlib=rb-1.2.1&amp;ixid=eyJhcHBfaWQiOjEyMDd9&amp;auto=format&amp;fit=facearea&amp;facepad=4&amp;w=256&amp;h=256&amp;q=60"
                }
            };
                search = search ?? "";
                return employees.Where(x => x.Name.ToLower().StartsWith(search.ToLower()) || x.Name.ToLower().Contains(search.ToLower())).ToList();
            }
        }
    }

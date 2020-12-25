using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorDualCore.Shared.Data
{
    public class JobService
    {
        private readonly EmployerService _employerService;

        public JobService(EmployerService employerService)
        {
            this._employerService = employerService;
        }

        public IEnumerable<Job> Get(string search = null)
        {
            var jobs = new List<Job>()
            {
                new Job()
                {
                    Id = Guid.NewGuid(),
                    Employer = this._employerService.GetByName("Mix Digital Entertainment"),
                    Name = "Need charted accountant for Bank",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    Sector = new Sector(){ Name = "Automotive Jobs" },
                    Status = new Status() { Name = "Active" },
                    PublishDate = new DateTime(2020, 10, 12),
                    Salary = 40000,
                    EmploymentType = new EmploymentType(){ Name = "Full time" }
                },
                new Job()
                {
                    Id = Guid.NewGuid(),
                    Employer = this._employerService.GetByName("Ebiquity Maxi"),
                    Name = "Marketing Expert For Charity Organization",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    Sector = new Sector(){ Name = "Accounting / Finance" },
                    Status = new Status() { Name = "Featured" },
                    PublishDate = new DateTime(2020, 6, 4),
                    Salary = 18000,
                    EmploymentType = new EmploymentType(){ Name = "Temporary" }
                },
                new Job()
                {
                    Id = Guid.NewGuid(),
                    Employer = this._employerService.GetByName("Reliable Movers"),
                    Name = "Print Media Designer Required",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    Sector = new Sector(){ Name = "Telecommunications" },
                    Status = new Status() { Name = "Featured" },
                    PublishDate = new DateTime(2019, 12, 21),
                    Salary = 26000,
                    EmploymentType = new EmploymentType(){ Name = "Part time" }
                },
                new Job()
                {
                    Id = Guid.NewGuid(),
                    Employer = this._employerService.GetByName("Lasmoix Ltd"),
                    Name = "Medical Professed Required MBBS Part",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    Sector = new Sector(){ Name = "Restaurant / Food Services" },
                    Status = new Status() { Name = "Active" },
                    PublishDate = new DateTime(2019, 10, 20),
                    Salary = 36000,
                    EmploymentType = new EmploymentType(){ Name = "Temporary" }
                },
                new Job()
                {
                    Id = Guid.NewGuid(),
                    Employer = this._employerService.GetByName("Ladbrokesed Limited"),
                    Name = "Cashier For Bank Desk Urgent Required",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    Sector = new Sector(){ Name = "Construction / Facilities" },
                    Status = new Status() { Name = "Active" },
                    PublishDate = new DateTime(2020, 07, 14),
                    Salary = 54000,
                    EmploymentType = new EmploymentType(){ Name = "Freelance" }
                },
                new Job()
                {
                    Id = Guid.NewGuid(),
                    Employer = this._employerService.GetByName("Kellermite Group"),
                    Name = "Bank Manger For Uk Bank",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    Sector = new Sector(){ Name = "Automotive Jobs" },
                    Status = new Status() { Name = "Active" },
                    PublishDate = new DateTime(2020, 11, 2),
                    Salary = 29000,
                    EmploymentType = new EmploymentType(){ Name = "Full time" }
                },

                new Job()
                {
                    Id = Guid.NewGuid(),
                    Employer = this._employerService.GetByName("Schrodersty Property"),
                    Name = "Charity Organization agent Required",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    Sector = new Sector(){ Name = "Accounting / Finance" },
                    Status = new Status() { Name = "Active" },
                    PublishDate = new DateTime(2020, 2, 24),
                    Salary = 12000,
                    EmploymentType = new EmploymentType(){ Name = "Temporary" }
                },
                new Job()
                {
                    Id = Guid.NewGuid(),
                    Employer = this._employerService.GetByName("Reliable Movers"),
                    Name = "Donation Collector For Charity Office",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    Sector = new Sector(){ Name = "Accounting / Finance" },
                    Status = new Status() { Name = "Active" },
                    PublishDate = new DateTime(2020, 3, 13),
                    Salary = 33000,
                    EmploymentType = new EmploymentType(){ Name = "Temporary" }
                },
                new Job()
                {
                    Id = Guid.NewGuid(),
                    Employer = this._employerService.GetByName("Maretox Spectron"),
                    Name = "Graphics Designer Required Freelance",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    Sector = new Sector(){ Name = "Telecommunications" },
                    Status = new Status() { Name = "Active" },
                    PublishDate = new DateTime(2020, 3, 16),
                    Salary = 12000,
                    EmploymentType = new EmploymentType(){ Name = "Freelance" }
                },
                new Job()
                {
                    Id = Guid.NewGuid(),
                    Employer = this._employerService.GetByName("Feverty Media"),
                    Name = "Need Senior Rolling Property Agent",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    Sector = new Sector(){ Name = "Education Training" },
                    Status = new Status() { Name = "Active" },
                    PublishDate = new DateTime(2020, 8, 1),
                    Salary = 29000,
                    EmploymentType = new EmploymentType(){ Name = "Full time" }
                },
            };

            if (String.IsNullOrEmpty(search))
                return jobs;
            return jobs.Where(x => x.Name.ToLower().StartsWith(search.ToLower()) || x.Name.ToLower().Contains(search.ToLower())).ToList();
        }
    }
}

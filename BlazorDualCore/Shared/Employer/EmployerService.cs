using System.Collections.Generic;
using System.Linq;

namespace BlazorDualCore.Shared.Data
{
    public class EmployerService
    {
        private List<Employer> employers;
        public EmployerService()
        {
            employers = new List<Employer>()
            {
                new Employer()
                {
                    Name = "Ebiquity Maxi",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    LogoUrl = "https://careerfy.net/hireright/wp-content/uploads/employer-19-150x150.png",
                    Sector = new Sector(){ Name = "Automotive Jobs" },
                    Status = new Status() { Name = "Featured" },
                },
                new Employer()
                {
                    Name = "Mix Digital Entertainment",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    LogoUrl = "https://careerfy.net/hireright/wp-content/uploads/employer-01-150x150.png",
                    Sector = new Sector(){ Name = "Construction / Facilities" },
                    Status = new Status() { Name = "Featured" },
                },
                new Employer()
                {
                    Name = "Likeotl Hiring Co",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    LogoUrl = "https://careerfy.net/hireright/wp-content/uploads/employer-17-150x150.png",
                    Sector = new Sector(){ Name = "Telecommunications" },
                    Status = new Status() { Name = "Featured" },
                },
                new Employer()
                {
                    Name = "Reliable Movers",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    LogoUrl = "https://careerfy.net/hireright/wp-content/uploads/employer-18-150x150.png",
                    Sector = new Sector(){ Name = "Accounting / Finance" },
                    Status = new Status() { Name = "Featured" },
                },
                new Employer()
                {
                    Name = "Lasmoix Ltd",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    LogoUrl = "https://careerfy.net/hireright/wp-content/uploads/employer-18-150x150.png",
                    Sector = new Sector(){ Name = "Education Training" },
                    Status = new Status() { Name = "Active" },
                },
                new Employer()
                {
                    Name = "Ladbrokesed Limited",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    LogoUrl = "https://careerfy.net/hireright/wp-content/uploads/employer-15-150x150.png",
                    Sector = new Sector(){ Name = "Restaurant / Food Services" },
                    Status = new Status() { Name = "Active" },
                },

                new Employer()
                {
                    Name = "Kellermite Group",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    LogoUrl = "https://careerfy.net/hireright/wp-content/uploads/employer-14-150x150.png",
                    Sector = new Sector(){ Name = "Construction / Facilities" },
                    Status = new Status() { Name = "Active" },
                },
                new Employer()
                {
                    Name = "Schrodersty Property",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    LogoUrl = "https://careerfy.net/hireright/wp-content/uploads/employer-13-150x150.png",
                    Sector = new Sector(){ Name = "Automotive Jobs" },
                    Status = new Status() { Name = "Active" },
                },
                new Employer()
                {
                    Name = "Maretox Spectron",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    LogoUrl = "https://careerfy.net/hireright/wp-content/uploads/employer-12-150x150.png",
                    Sector = new Sector(){ Name = "Accounting / Finance" },
                    Status = new Status() { Name = "Active" },
                },
                new Employer()
                {
                    Name = "Feverty Media",
                    Description = "Far much that one rank beheld bluebird after outside ignobly allegedly more when oh arrogantly vehement irresistibly fussy penguin insect additionally wow absolutely crud meretriciously hastily dalmatian a glowered inset one echidna cassowary some parrot and much as goodness some froze the sullen much connected bat wonderfully on instantaneously eel valiantly petted this along across highhandedly much dog out the much alas evasively neutral lazy reset. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Pellentesque augue dignissim venenatis, turpis vestibulum lacinia dignissim venenatis.Mus arcu euismod ad hac dui, vivamus platea netus.Neque per nisl posuere sagittis, id platea dui.A enim magnis dapibus, nullam odio porta, nisl class.Turpis leo pellentesque per nam, nostra fringilla id.",
                    Location = new Location(){ Name = "United Kingdom" },
                    LogoUrl = "https://careerfy.net/hireright/wp-content/uploads/employer-11-150x150.png",
                    Sector = new Sector(){ Name = "Telecommunications" },
                    Status = new Status() { Name = "Active" },
                },
            };
        }

        public Employer GetByName(string name = null)
        {
            return this.employers.Where(x => x.Name.Equals(name)).FirstOrDefault();
        }

        public IEnumerable<Employer> Get(string search = null)
        {            
            search = search ?? "";
            return employers.Where(x => x.Name.ToLower().StartsWith(search.ToLower()) || x.Name.ToLower().Contains(search.ToLower())).ToList();
        }
    }
}

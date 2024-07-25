using UserManagment.Data.Entities;
using UserManagment.Enums;
namespace UserManagment.Data
{
    public static class Seed
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new List<User>()
            {
                new User { Name="Bibek Gurung", Username="bibek", Age=29, Designation="Accountant", Phone="9841445412", Status=StatusEnum.Open },
                new User { Name="Asha Shrestha", Username="asha", Age=25, Designation="Software Engineer", Phone="9801234567", Status=StatusEnum.Open },
                new User { Name="Rajesh Tamang", Username="rajesh", Age=32, Designation="Project Manager", Phone="9812345678", Status=StatusEnum.Closed },
                new User { Name="Sita Rai", Username="sita", Age=28, Designation="Graphic Designer", Phone="9856789123", Status=StatusEnum.Open },
                new User { Name="Pratik Lama", Username="pratik", Age=26, Designation="Marketing Executive", Phone="9845671234", Status=StatusEnum.Closed },
                new User { Name="Kiran Shah", Username="kiran", Age=30, Designation="Business Analyst", Phone="9865432109", Status=StatusEnum.Open },
                new User { Name="Nisha Thapa", Username="nisha", Age=27, Designation="HR Manager", Phone="9823456789", Status=StatusEnum.Closed },
                new User { Name="Santosh Yadav", Username="santosh", Age=31, Designation="Sales Manager", Phone="9807654321", Status=StatusEnum.Open },
                new User { Name="Anjali KC", Username="anjali", Age=24, Designation="Content Writer", Phone="9817654321", Status=StatusEnum.Closed },
                new User { Name="Ramesh Shrestha", Username="ramesh", Age=33, Designation="Network Administrator", Phone="9843210987", Status=StatusEnum.Open }
            };
            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}


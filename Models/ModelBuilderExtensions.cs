using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Rod", Element = Element.Life, Email = "rod@slav.god" },
                new Employee() { Id = 2, Name = "Perun", Element = Element.Lightning, Email = "perun@slav.god" },
                new Employee() { Id = 3, Name = "Svarog", Element = Element.Fire, Email = "Svarog" }
                );
        }
    }
}

using Microsoft.EntityFrameworkCore;

public class Employee
{
    public long Id { get; set; }

    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }
    public string Currency { get; set; }

    public long ShelterId { get; set; }
    public Shelter Shelter { get; set; }
}

public static class EmployeeContextHelper
{
    public static void AddEmployee(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().Property(x => x.Name)
            .HasMaxLength(500);

        modelBuilder.Entity<Employee>().Property(x => x.Surname)
            .HasMaxLength(500);

        modelBuilder.Entity<Employee>().Property(x => x.Currency)
            .HasMaxLength(3);

        modelBuilder.Entity<Employee>().HasOne(x => x.Shelter)
            .WithMany(x => x.Employees).HasForeignKey(x => x.ShelterId);
    }
}
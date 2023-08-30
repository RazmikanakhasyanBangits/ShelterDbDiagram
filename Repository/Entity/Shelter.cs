using Microsoft.EntityFrameworkCore;

public  class Shelter
{
    public long Id { get; set; }
    public string Name { get; set; }
    public DateTime NextOpenDorTime { get; set; }

    public List<Guest> Guests { get; set; }
    public List<Pet> Pets { get; set; }
    public List<Employee> Employees { get; set; }
}


public static class ShelterContextHelper
{
    public static void AddShelter(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Shelter>().Property(x => x.Name)
            .HasMaxLength(500);
    }
}
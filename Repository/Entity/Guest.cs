using Microsoft.EntityFrameworkCore;

public class Guest
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public long ShelterId { get; set; }
    public Shelter Shelter { get; set; }
}
public static class GuestContextHelper
{
    public static void AddGuest(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Guest>().Property(x => x.Name)
            .HasMaxLength(500);

        modelBuilder.Entity<Guest>().Property(x => x.Surname)
            .HasMaxLength(500);

        modelBuilder.Entity<Guest>().HasOne(x => x.Shelter)
            .WithMany(x => x.Guests).HasForeignKey(x => x.ShelterId);
    }
}
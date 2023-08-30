using Microsoft.EntityFrameworkCore;

public class Pet
{
    public long Id { get; set; }
    public double SatietyLevel { get; set; }
    public string Name { get; set; }
    public DateTime EatSchedule { get; set; }

    public long FoodId { get; set; }
    public Food Food { get; set; }

    public long ShelterId { get; set; }
    public Shelter Shelter { get; set; }
}
public static class PetContextHelper
{
    public static void AddPet(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pet>().Property(x => x.Name)
            .HasMaxLength(500);

        modelBuilder.Entity<Pet>().Property(x => x.SatietyLevel).HasDefaultValue(0);

        modelBuilder.Entity<Pet>().HasOne(x => x.Food)
            .WithMany(x => x.Pets).HasForeignKey(x => x.FoodId);

        modelBuilder.Entity<Pet>().HasOne(x => x.Shelter)
            .WithMany(x => x.Pets).HasForeignKey(x => x.ShelterId);
    }
}
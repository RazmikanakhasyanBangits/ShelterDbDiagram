using Microsoft.EntityFrameworkCore;

public class Food
{
    public long Id { get; set; }
    public string Name { get; set; }

    public double Remain { get; set; }
    public double Price { get; set; }

    public List<Pet> Pets { get;set; }
}

public static class FoodContextHelper
{
    public static void AddFood(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Food>().Property(x => x.Name)
            .HasMaxLength(500);

        modelBuilder.Entity<Food>().Property(x => x.Remain)
            .HasDefaultValue(100);
    }
}
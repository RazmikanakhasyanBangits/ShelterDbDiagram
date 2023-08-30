using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ShelterDbContext : DbContext
    {
        public ShelterDbContext()
        {

        }

        public ShelterDbContext(DbContextOptions<ShelterDbContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Shelter> Shelter{ get; set; }
        public virtual DbSet<Employee> Employees{ get; set; }
        public virtual DbSet<Pet> Pets{ get; set; }
        public virtual DbSet<Guest> Guests{ get; set; }
        public virtual DbSet<Food> Foods{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=DESKTOP-DP52C93\\SQLEXPRESS;Database=Shelter;TrustServerCertificate=True;Integrated Security=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddPet();
            modelBuilder.AddFood();
            modelBuilder.AddGuest();
            modelBuilder.AddShelter();
            modelBuilder.AddEmployee();
        }
    }
}

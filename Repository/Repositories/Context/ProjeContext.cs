using Microsoft.EntityFrameworkCore;
using Repository.Entities;

namespace Repository.Repositories.Context
{
    public class ProjeContext:DbContext
    {

        public DbSet<About> Abouts { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Hizmet> Hizmets { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // ovveride on yaz gerisi gelir
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=DBRestoranProje; integrated security=true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //fluent api ile ilgiliydi sanki 
        {
            //modelBuilder.Entity<About>(entity => {
            //    entity.HasOne(x => x.User).WithMany(x => x.Abouts).HasForeignKey(x => x.CreatedBy);

            //});
            //modelBuilder.Entity<Service>(entity => {
            //    entity.HasOne(x => x.User).WithMany(x => x.Services).HasForeignKey(x => x.CreatedBy);

            //});
            base.OnModelCreating(modelBuilder);
        }
    }
}

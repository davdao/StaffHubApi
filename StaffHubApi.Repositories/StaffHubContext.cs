using Microsoft.EntityFrameworkCore;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Relationship;

namespace StaffHubApi.Repositories
{
    public class StaffHubContext : DbContext
    {
        public StaffHubContext(DbContextOptions<StaffHubContext> options): base(options)
        {
        }

        public DbSet<Activity> Activity { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ActivitiesRelationship> ActivitiesRelationship { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Activity>().ToTable("Activity");
            modelBuilder.Entity<Shift>().ToTable("Shift");
            modelBuilder.Entity<Color>().ToTable("Color");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<ActivitiesRelationship>().ToTable("ActivitiesRelationship");

            modelBuilder.Entity<Activity>().HasData(new Activity { Id = 1, Name = "Modern Workplace" });
            modelBuilder.Entity<Activity>().HasData(new Activity { Id = 2, Name = "Cloud Apps Data" });

            modelBuilder.Entity<Member>().HasData(
                new { Id = 1, Name = "Pauline Console", Email = "console@infeeny.com", PictureUrl = ""},
                new { Id = 2, Name = "Muroni Brice", Email = "muroni@infeeny.com", PictureUrl = ""},
                new { Id = 3, Name = "Dao David", Email = "dao@infeeny.com", PictureUrl = ""},
                new { Id = 4, Name = "Neyrand Aurélien", Email = "neyrand@infeeny.com", PictureUrl = ""},
                new { Id = 5, Name = "Fruhinsholz Fiona", Email = "fruhinsholz@infeeny.com", PictureUrl = ""},
                new { Id = 6, Name = "Grange Sylvain", Email = "grange@infeeny.com", PictureUrl = ""},
                new { Id = 7, Name = "Fernandez Gaelle", Email = "fernandez@infeeny.com", PictureUrl = ""},
                new { Id = 8, Name = "Le Carpentier Antoine", Email = "lecarpentier@infeeny.com", PictureUrl = ""},
                new { Id = 9, Name = "Florez Angela", Email = "florez@infeeny.com", PictureUrl = ""}
                );
            modelBuilder.Entity<Color>().HasData(
                new Color { Id = 1, Name = "Infeeny", ColorCode = "#240058" },
                new Color { Id = 2, Name = "Bleu", ColorCode = "#017CE6" },
                new Color { Id = 3, Name = "Vert", ColorCode = "#8EBB0E" },
                new Color { Id = 4, Name = "Violet", ColorCode = "#8D7EF3" },
                new Color { Id = 5, Name = "Rose", ColorCode = "#E15E6F" },
                new Color { Id = 6, Name = "Jaune", ColorCode = "#FFBA00" },
                new Color { Id = 7, Name = "Gris", ColorCode = "#454644" },
                new Color { Id = 8, Name = "Bleu foncé", ColorCode = "#005295" },
                new Color { Id = 9, Name = "Vert foncé", ColorCode = "#4D8602" },
                new Color { Id = 10, Name = "Violet foncé", ColorCode = "#562888" },
                new Color { Id = 11, Name = "Rose foncé", ColorCode = "#A4202B" },
                new Color { Id = 12, Name = "Jaune foncé", ColorCode = "#FFA230" });

            modelBuilder.Entity<Client>().HasData(
                new { Id = 1, Name = "GEM", ColorId = 1 },
                new { Id = 2, Name = "Michelin", ColorId = 2 },
                new { Id = 3, Name = "Sicam", ColorId = 5 },
                new { Id = 4, Name = "Cegid", ColorId = 6 }
                );

            modelBuilder.Entity<ActivitiesRelationship>().HasData(
                    new ActivitiesRelationship { Id = 1, ActivityId = 1, MemberId = 1 },
                    new ActivitiesRelationship { Id = 2, ActivityId = 1, MemberId = 2 },
                    new ActivitiesRelationship { Id = 3, ActivityId = 1, MemberId = 3 },
                    new ActivitiesRelationship { Id = 4, ActivityId = 1, MemberId = 4 },
                    new ActivitiesRelationship { Id = 5, ActivityId = 1, MemberId = 5 },
                    new ActivitiesRelationship { Id = 6, ActivityId = 1, MemberId = 6 },
                    new ActivitiesRelationship { Id = 7, ActivityId = 1, MemberId = 7 },
                    new ActivitiesRelationship { Id = 8, ActivityId = 1, MemberId = 8 },
                    new ActivitiesRelationship { Id = 9, ActivityId = 1, MemberId = 9 },
                    new ActivitiesRelationship { Id = 10, ActivityId = 2, MemberId = 1 },
                    new ActivitiesRelationship { Id = 11, ActivityId = 2, MemberId = 2 },
                    new ActivitiesRelationship { Id = 12, ActivityId = 2, MemberId = 3 },
                    new ActivitiesRelationship { Id = 13, ActivityId = 2, MemberId = 4 },
                    new ActivitiesRelationship { Id = 14, ActivityId = 2, MemberId = 5 }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}

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
        public DbSet<Client> Client { get; set; }
        public DbSet<ActivitiesRelationship> ActivitiesRelationship { get; set; }
        public DbSet<ActivityMemberRelationship> ActivityMemberRelationship { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Activity>().ToTable("Activity");
            modelBuilder.Entity<Shift>().ToTable("Shift");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<ActivitiesRelationship>().ToTable("ActivitiesRelationship");
            modelBuilder.Entity<ActivityMemberRelationship>().ToTable("ActivityMemberRelationship");
            
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

            modelBuilder.Entity<Client>().HasData(
                new { Id = 1, Name = "GEM", Color = "#8D7EF3" },
                new { Id = 2, Name = "Michelin", Color = "#A4202B" },
                new { Id = 3, Name = "Sicam", Color = "#4D8602" },
                new { Id = 4, Name = "Cegid", Color = "#454644" }
                );

            modelBuilder.Entity<ActivityMemberRelationship>().HasData(
                    new ActivityMemberRelationship { Id = 1, ActivityId = 1, MemberId = 1 },
                    new ActivityMemberRelationship { Id = 2, ActivityId = 1, MemberId = 2 },
                    new ActivityMemberRelationship { Id = 3, ActivityId = 1, MemberId = 3 },
                    new ActivityMemberRelationship { Id = 4, ActivityId = 1, MemberId = 4 },
                    new ActivityMemberRelationship { Id = 5, ActivityId = 1, MemberId = 5 },
                    new ActivityMemberRelationship { Id = 6, ActivityId = 1, MemberId = 6 },
                    new ActivityMemberRelationship { Id = 7, ActivityId = 1, MemberId = 7 },
                    new ActivityMemberRelationship { Id = 8, ActivityId = 1, MemberId = 8 },
                    new ActivityMemberRelationship { Id = 9, ActivityId = 1, MemberId = 9 }
                );

            modelBuilder.Entity<Shift>().HasData(
                new Shift { Id = 1, StartDate = new System.DateTime(2019, 11, 25), EndDate = new System.DateTime(2019, 11, 28), Title = "bonjour" }
                );

            modelBuilder.Entity<ActivitiesRelationship>().HasData(
                new ActivitiesRelationship { Id = 1, ActivityId = 1, ClientId = 1, MemberId = 5, ShiftId = 1 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}

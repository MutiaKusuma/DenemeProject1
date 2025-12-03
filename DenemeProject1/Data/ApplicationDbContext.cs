using DenemeProject1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DenemeProject1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


		public DbSet<Service> Services { get; set; }
		public DbSet<Trainer> Trainers { get; set; }
		public DbSet<TrainerSchedule> TrainerSchedules { get; set; }
		public DbSet<Appointment> Appointments { get; set; }
	}
}

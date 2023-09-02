using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TroubleShooting_AspNet.Models;

namespace TroubleShooting_AspNet
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<AssistanceRequest> AssistanceRequest { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

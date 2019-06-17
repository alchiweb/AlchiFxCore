using System;
using System.Collections.Generic;
using System.Text;
using EntitySignal.Server.EFDbContext.Data;
using EntitySignal.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Company.WebApplication1.Models;

namespace Company.WebApplication1.Data
{
    public class AlchiDbContext : EntitySignalIdentityDbContext<AlchiUser>
    {
        public AlchiDbContext(DbContextOptions<AlchiDbContext> options, EntitySignalDataProcess entitySignalDataProcess)
            : base(options, entitySignalDataProcess)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

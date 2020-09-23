using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Rsvp.Models
{
    public class DataContext: DbContext
    {
        public static ILoggerFactory loggerFactory;
        public DbSet<GuestResponse> GuestResponses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            loggerFactory = LoggerFactory.Create(
                builder => 
                {
                    builder
                        .AddFilter("Microsoft", LogLevel.Warning)
                        .AddFilter("System", LogLevel.Warning)
                        .AddFilter("SampleApp.Program", LogLevel.Debug)
                        .AddFilter("Microsoft.EntityFrameworkCore", LogLevel.Information)
                        .AddConsole();
                }
            );
            optionsBuilder
            .UseSqlServer(@"Server=localhost;Database=efCoreDB; User Id=SA; Password=My_super_secret_password")
            .UseLoggerFactory(loggerFactory);
        }
    }
}
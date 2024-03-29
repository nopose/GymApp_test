﻿using GymApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymApp.Data
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions<GymContext> options) : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>().ToTable("Exercises");
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }

    //public static class SeedData
    //{
    //    public static void Initialize(IServiceProvider serviceProvider)
    //    {
    //        using (var context = new GymContext(
    //            serviceProvider.GetRequiredService<DbContextOptions<GymContext>>()))
    //        {
    //            // Look for any movies.
    //            if (context.Movie.Any())
    //            {
    //                return;   // DB has been seeded
    //            }

    //            context.Movie.AddRange(
    //                 new Movie
    //                 {
    //                     Title = "When Harry Met Sally",
    //                     ReleaseDate = DateTime.Parse("1989-1-11"),
    //                     Genre = "Romantic Comedy",
    //                     Price = 7.99M
    //                 },

    //                 new Movie
    //                 {
    //                     Title = "Ghostbusters ",
    //                     ReleaseDate = DateTime.Parse("1984-3-13"),
    //                     Genre = "Comedy",
    //                     Price = 8.99M
    //                 },

    //                 new Movie
    //                 {
    //                     Title = "Ghostbusters 2",
    //                     ReleaseDate = DateTime.Parse("1986-2-23"),
    //                     Genre = "Comedy",
    //                     Price = 9.99M
    //                 },

    //               new Movie
    //               {
    //                   Title = "Rio Bravo",
    //                   ReleaseDate = DateTime.Parse("1959-4-15"),
    //                   Genre = "Western",
    //                   Price = 3.99M
    //               }
    //            );
    //            context.SaveChanges();
    //        }
    //    }
    //}
}
// TODO: Add Db initializer to create db

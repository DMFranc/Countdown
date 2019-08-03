﻿// <auto-generated />
using System;
using Countdown.Website.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Countdown.Website.Migrations
{
    [DbContext(typeof(CountdownContext))]
    partial class CountdownContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Countdown.Website.DataModels.Problem", b =>
                {
                    b.Property<int>("ProblemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvailableNumbers");

                    b.Property<int>("ClosestDiff");

                    b.Property<int>("Target");

                    b.HasKey("ProblemId");

                    b.ToTable("Problems");
                });

            modelBuilder.Entity("Countdown.Website.DataModels.Solution", b =>
                {
                    b.Property<int>("SolutionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProblemId");

                    b.Property<string>("Value");

                    b.HasKey("SolutionId");

                    b.HasIndex("ProblemId");

                    b.ToTable("Solutions");
                });

            modelBuilder.Entity("Countdown.Website.DataModels.Solution", b =>
                {
                    b.HasOne("Countdown.Website.DataModels.Problem", "Problem")
                        .WithMany("Solutions")
                        .HasForeignKey("ProblemId");
                });
#pragma warning restore 612, 618
        }
    }
}
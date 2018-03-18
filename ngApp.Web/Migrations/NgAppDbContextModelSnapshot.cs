﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ngApp.Web.Persistence;

namespace ngApp.Web.Migrations
{
    [DbContext(typeof(NgAppDbContext))]
    partial class NgAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview1-28290")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ngApp.Web.Models.Vechicles.Feature", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("features");
                });

            modelBuilder.Entity("ngApp.Web.Models.Vechicles.Make", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("HeadQuatersLocation");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("makes");
                });

            modelBuilder.Entity("ngApp.Web.Models.Vechicles.Model", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<long>("MakeId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("models");
                });

            modelBuilder.Entity("ngApp.Web.Models.Vechicles.ModelFeature", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("FeatureId");

                    b.Property<long>("ModelId");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("ModelId");

                    b.ToTable("ModelFeature");
                });

            modelBuilder.Entity("ngApp.Web.Models.Vechicles.Vehicle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<double>("Mileage");

                    b.Property<long>("ModelId");

                    b.Property<double>("Power");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("vehicles");
                });

            modelBuilder.Entity("ngApp.Web.Models.Vechicles.Model", b =>
                {
                    b.HasOne("ngApp.Web.Models.Vechicles.Make", "Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ngApp.Web.Models.Vechicles.ModelFeature", b =>
                {
                    b.HasOne("ngApp.Web.Models.Vechicles.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ngApp.Web.Models.Vechicles.Model", "Model")
                        .WithMany("Features")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ngApp.Web.Models.Vechicles.Vehicle", b =>
                {
                    b.HasOne("ngApp.Web.Models.Vechicles.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

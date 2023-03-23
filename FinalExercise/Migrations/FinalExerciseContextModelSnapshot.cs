﻿// <auto-generated />
using FinalExercise.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalExercise.Migrations
{
    [DbContext(typeof(FinalExerciseContext))]
    partial class FinalExerciseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommissionTravelPackage", b =>
                {
                    b.Property<int>("CommissionsCommissionId")
                        .HasColumnType("int");

                    b.Property<int>("TravelPackagesTravelPackageId")
                        .HasColumnType("int");

                    b.HasKey("CommissionsCommissionId", "TravelPackagesTravelPackageId");

                    b.HasIndex("TravelPackagesTravelPackageId");

                    b.ToTable("CommissionTravelPackage");
                });

            modelBuilder.Entity("FinalExercise.Domain.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("FinalExercise.Domain.Models.Commission", b =>
                {
                    b.Property<int>("CommissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientTypeId")
                        .HasColumnType("int");

                    b.Property<double>("CommissionResult")
                        .HasColumnType("float");

                    b.Property<int>("PassengersAmmount")
                        .HasColumnType("int");

                    b.Property<int>("TripDuration")
                        .HasColumnType("int");

                    b.HasKey("CommissionId");

                    b.ToTable("Commission");
                });

            modelBuilder.Entity("FinalExercise.Domain.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("FinalExercise.Domain.Models.TravelPackage", b =>
                {
                    b.Property<int>("TravelPackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TravelPackageId");

                    b.ToTable("TravelPackage");
                });

            modelBuilder.Entity("ProductTravelPackage", b =>
                {
                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.Property<int>("TravelPackagesTravelPackageId")
                        .HasColumnType("int");

                    b.HasKey("ProductsProductId", "TravelPackagesTravelPackageId");

                    b.HasIndex("TravelPackagesTravelPackageId");

                    b.ToTable("ProductTravelPackage");
                });

            modelBuilder.Entity("CommissionTravelPackage", b =>
                {
                    b.HasOne("FinalExercise.Domain.Models.Commission", null)
                        .WithMany()
                        .HasForeignKey("CommissionsCommissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalExercise.Domain.Models.TravelPackage", null)
                        .WithMany()
                        .HasForeignKey("TravelPackagesTravelPackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductTravelPackage", b =>
                {
                    b.HasOne("FinalExercise.Domain.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalExercise.Domain.Models.TravelPackage", null)
                        .WithMany()
                        .HasForeignKey("TravelPackagesTravelPackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

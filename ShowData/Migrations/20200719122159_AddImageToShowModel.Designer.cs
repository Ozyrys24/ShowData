﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShowData.Data;

namespace ShowData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200719122159_AddImageToShowModel")]
    partial class AddImageToShowModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShowData.Model.DataOverview", b =>
                {
                    b.Property<int>("DataOverviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dataIncluded")
                        .HasColumnType("int");

                    b.HasKey("DataOverviewId");

                    b.ToTable("DataOverviews");
                });

            modelBuilder.Entity("ShowData.Model.ShowModel", b =>
                {
                    b.Property<int>("ShowModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DataOverviewId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DisplayDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("isAvailsable")
                        .HasColumnType("bit");

                    b.HasKey("ShowModelId");

                    b.HasIndex("DataOverviewId");

                    b.ToTable("ShowModels");
                });

            modelBuilder.Entity("ShowData.Model.ShowModel", b =>
                {
                    b.HasOne("ShowData.Model.DataOverview", "DataOverview")
                        .WithMany("ShowModels")
                        .HasForeignKey("DataOverviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
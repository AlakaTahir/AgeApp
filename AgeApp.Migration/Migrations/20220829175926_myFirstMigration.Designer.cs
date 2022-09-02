﻿// <auto-generated />
using System;
using AgeApp.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgeApp.Migrations.Migrations
{
    [DbContext(typeof(AgeAppDatabaseContext))]
    [Migration("20220829175926_myFirstMigration")]
    partial class myFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AgeApp.Model.DateCollectorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRequested")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("DateHistory");
                });
#pragma warning restore 612, 618
        }
    }
}

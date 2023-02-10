﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyProject.Data;

namespace MyProject.Data.Migrations
{
    [DbContext(typeof(MyProjectObjectContext))]
    partial class MyProjectObjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyProject.Core.Domain.Connector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("connector");
                });

            modelBuilder.Entity("MyProject.Core.Domain.Trigger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ConnectorEntry_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("ConnectorEntry_Id")
                        .HasName("IX_ConnectorEntry_Id");

                    b.ToTable("trigger");
                });

            modelBuilder.Entity("MyProject.Core.Domain.Trigger", b =>
                {
                    b.HasOne("MyProject.Core.Domain.Connector", "ConnectorEntry")
                        .WithMany("Triggers")
                        .HasForeignKey("ConnectorEntry_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
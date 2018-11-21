﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SongT1708M1_MVC.Models;

namespace SongT1708M1_MVC.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20181121082027_SongT1708M1_MVC")]
    partial class SongT1708M1_MVC
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SongT1708M1_MVC.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SongT1708M1_MVC.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("SongT1708M1_MVC.Models.SongCategory", b =>
                {
                    b.Property<int>("SongId");

                    b.Property<int>("CategoryId");

                    b.HasKey("SongId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SongCategories");
                });

            modelBuilder.Entity("SongT1708M1_MVC.Models.SongCategory", b =>
                {
                    b.HasOne("SongT1708M1_MVC.Models.Category", "Category")
                        .WithMany("SongCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SongT1708M1_MVC.Models.Song", "Song")
                        .WithMany("SongCategories")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
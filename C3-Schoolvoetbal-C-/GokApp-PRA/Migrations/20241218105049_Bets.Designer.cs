﻿// <auto-generated />
using GokApp_PRA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GokApp_PRA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241218105049_Bets")]
    partial class Bets
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("GokApp_PRA.Model.Bet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChosenMatch")
                        .HasColumnType("longtext");

                    b.Property<string>("ChosenTeam")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Bets");
                });
#pragma warning restore 612, 618
        }
    }
}

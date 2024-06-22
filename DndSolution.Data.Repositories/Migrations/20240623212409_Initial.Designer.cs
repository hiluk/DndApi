﻿// <auto-generated />
using System;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Repositories.Migrations
{
    [DbContext(typeof(DndContext))]
    [Migration("20240623212409_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Entities.Entities.CharacterEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("CharacterClass")
                        .HasColumnType("integer")
                        .HasColumnName("class");

                    b.Property<string>("CharacterId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("character_id");

                    b.Property<int>("CharacterRace")
                        .HasColumnType("integer")
                        .HasColumnName("race");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("creation_date");

                    b.Property<byte>("Level")
                        .HasColumnType("smallint")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<long>("StatsId")
                        .HasColumnType("bigint");

                    b.Property<long>("Xp")
                        .HasColumnType("bigint")
                        .HasColumnName("xp");

                    b.HasKey("Id");

                    b.HasIndex("StatsId");

                    b.ToTable("character");
                });

            modelBuilder.Entity("Data.Entities.Entities.CharacterStatsEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CharacterId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("character_id");

                    b.Property<int>("Charisma")
                        .HasColumnType("integer")
                        .HasColumnName("charisma");

                    b.Property<int>("Constitution")
                        .HasColumnType("integer")
                        .HasColumnName("constitution");

                    b.Property<int>("Dexterity")
                        .HasColumnType("integer")
                        .HasColumnName("dexterity");

                    b.Property<int>("Intelligence")
                        .HasColumnType("integer")
                        .HasColumnName("intelligence");

                    b.Property<int>("Strenght")
                        .HasColumnType("integer")
                        .HasColumnName("strength");

                    b.Property<int>("Wisdom")
                        .HasColumnType("integer")
                        .HasColumnName("wisdom");

                    b.HasKey("Id");

                    b.ToTable("stats");
                });

            modelBuilder.Entity("Data.Entities.Entities.CharacterEntity", b =>
                {
                    b.HasOne("Data.Entities.Entities.CharacterStatsEntity", "Stats")
                        .WithMany()
                        .HasForeignKey("StatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stats");
                });
#pragma warning restore 612, 618
        }
    }
}
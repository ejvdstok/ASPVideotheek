﻿// <auto-generated />
using System;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(VideoVerhuurContext))]
    [Migration("20210119202016_genrenaam2")]
    partial class genrenaam2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("InVoorraad")
                        .HasColumnType("int");

                    b.Property<decimal>("Prijs")
                        .HasColumnType("money");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true)
                        .HasMaxLength(50);

                    b.Property<int>("TotaalVerhuurd")
                        .HasColumnType("int");

                    b.Property<int>("UitVoorraad")
                        .HasColumnType("int");

                    b.HasKey("FilmId");

                    b.HasIndex("GenreId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("Data.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreNaam")
                        .IsRequired()
                        .HasColumnName("GenreNaam")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Data.Models.Klant", b =>
                {
                    b.Property<int>("KlantNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumLid")
                        .HasColumnType("date");

                    b.Property<string>("Gemeente")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("HuurAantal")
                        .HasColumnType("int");

                    b.Property<string>("KlantStat")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool>("Lidgeld")
                        .HasColumnType("bit");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("PostCode")
                        .HasColumnType("int");

                    b.Property<string>("StraatNr")
                        .IsRequired()
                        .HasColumnName("Straat_Nr")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("KlantNr");

                    b.HasIndex("DatumLid")
                        .HasName("DATUMLID");

                    b.HasIndex("PostCode")
                        .HasName("POSTCODE");

                    b.ToTable("Klanten");
                });

            modelBuilder.Entity("Data.Models.Verhuur", b =>
                {
                    b.Property<int>("VerhuurNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("KlantNr")
                        .HasColumnType("int");

                    b.Property<DateTime>("VerhuurDatum")
                        .HasColumnType("date");

                    b.HasKey("VerhuurNr");

                    b.HasIndex("FilmId")
                        .HasName("FilmId");

                    b.HasIndex("KlantNr")
                        .HasName("KlantNr");

                    b.ToTable("Verhuur");
                });

            modelBuilder.Entity("Data.Models.Film", b =>
                {
                    b.HasOne("Data.Models.Genre", "GenreNrNavigation")
                        .WithMany("Films")
                        .HasForeignKey("GenreId")
                        .HasConstraintName("fk_GenreId")
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Models.Verhuur", b =>
                {
                    b.HasOne("Data.Models.Film", "BandNrNavigation")
                        .WithMany("Verhuur")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("fk_FilmId")
                        .IsRequired();

                    b.HasOne("Data.Models.Klant", "KlantNrNavigation")
                        .WithMany("Verhuur")
                        .HasForeignKey("KlantNr")
                        .HasConstraintName("fk_KlantNr")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

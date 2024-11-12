﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppKundeProdukt.Data;

#nullable disable

namespace WebAppKundeProdukt.Migrations
{
    [DbContext(typeof(WebAppKundeProduktContext))]
    [Migration("20241112091515_Thrd")]
    partial class Thrd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAppKundeProdukt.Models.Kunde", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kunde");
                });

            modelBuilder.Entity("WebAppKundeProdukt.Models.Produkt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Beschreibung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kategorie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preis")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Produkt");
                });

            modelBuilder.Entity("WebAppKundeProdukt.Models.Warenkorbposition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Gesamtpreis")
                        .HasColumnType("float");

                    b.Property<int>("KundeId")
                        .HasColumnType("int");

                    b.Property<int>("Menge")
                        .HasColumnType("int");

                    b.Property<int>("ProduktId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KundeId");

                    b.HasIndex("ProduktId");

                    b.ToTable("Warenkorbposition");
                });

            modelBuilder.Entity("WebAppKundeProdukt.Models.Warenkorbposition", b =>
                {
                    b.HasOne("WebAppKundeProdukt.Models.Kunde", "Kunde")
                        .WithMany("Warenkorbpositionen")
                        .HasForeignKey("KundeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppKundeProdukt.Models.Produkt", "Produkt")
                        .WithMany("Warenkorbpositionen")
                        .HasForeignKey("ProduktId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kunde");

                    b.Navigation("Produkt");
                });

            modelBuilder.Entity("WebAppKundeProdukt.Models.Kunde", b =>
                {
                    b.Navigation("Warenkorbpositionen");
                });

            modelBuilder.Entity("WebAppKundeProdukt.Models.Produkt", b =>
                {
                    b.Navigation("Warenkorbpositionen");
                });
#pragma warning restore 612, 618
        }
    }
}

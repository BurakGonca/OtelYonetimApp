﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OtelRezervasyonApp.Data;

#nullable disable

namespace OtelRezervasyonApp.Migrations
{
    [DbContext(typeof(OtelRezervasyonDbContext))]
    partial class OtelRezervasyonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.Otel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OtelTuruId")
                        .HasColumnType("int");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.Property<int>("Yildizi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OtelTuruId");

                    b.HasIndex("SehirId");

                    b.HasIndex("UlkeId");

                    b.ToTable("Oteller");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.OtelKapasitesi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Kapasite")
                        .HasColumnType("int");

                    b.Property<int>("OtelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OtelId");

                    b.ToTable("OtelKapasiteleri");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.OtelOdasi", b =>
                {
                    b.Property<int>("OdaId")
                        .HasColumnType("int");

                    b.Property<int>("OtelId")
                        .HasColumnType("int");

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.HasKey("OdaId", "OtelId");

                    b.ToTable("OtelOdalari");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.OtelTuru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OtelTurleri");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UlkeId");

                    b.ToTable("Sehirler");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.Ulke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ulkeler");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.Otel", b =>
                {
                    b.HasOne("OtelRezervasyonApp.Data.Entities.OtelTuru", "OtelTuru")
                        .WithMany()
                        .HasForeignKey("OtelTuruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelRezervasyonApp.Data.Entities.Sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelRezervasyonApp.Data.Entities.Ulke", "Ulke")
                        .WithMany()
                        .HasForeignKey("UlkeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OtelTuru");

                    b.Navigation("Sehir");

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.OtelKapasitesi", b =>
                {
                    b.HasOne("OtelRezervasyonApp.Data.Entities.Otel", "Otel")
                        .WithMany()
                        .HasForeignKey("OtelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Otel");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.Sehir", b =>
                {
                    b.HasOne("OtelRezervasyonApp.Data.Entities.Ulke", "Ulke")
                        .WithMany("Sehirler")
                        .HasForeignKey("UlkeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.Ulke", b =>
                {
                    b.Navigation("Sehirler");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
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

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.OdaTuru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OdaTurAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OdaTurleri");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aciklama = "Tek Kişilik Oda",
                            OdaTurAdi = "Single Oda"
                        },
                        new
                        {
                            Id = 2,
                            Aciklama = "Çift Kişilik Oda",
                            OdaTurAdi = "Double Oda"
                        },
                        new
                        {
                            Id = 3,
                            Aciklama = "Üç Kişilik Oda",
                            OdaTurAdi = "Triple Oda"
                        },
                        new
                        {
                            Id = 4,
                            Aciklama = "Lüks Oda",
                            OdaTurAdi = "Suit Oda"
                        },
                        new
                        {
                            Id = 5,
                            Aciklama = "İki Katlı Oda",
                            OdaTurAdi = "Dublex Oda"
                        },
                        new
                        {
                            Id = 6,
                            Aciklama = "Aileler İçin Oda",
                            OdaTurAdi = "Aile Odası"
                        },
                        new
                        {
                            Id = 7,
                            Aciklama = "Ultra Lüks Oda",
                            OdaTurAdi = "Kral Dairesi"
                        });
                });

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

                    b.Property<int>("OtelId")
                        .HasColumnType("int");

                    b.Property<int>("OtelToplamKapasite")
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

                    b.Property<byte>("BulunduguKat")
                        .HasColumnType("tinyint");

                    b.Property<byte>("OdaKapasitesi")
                        .HasColumnType("tinyint");

                    b.Property<short>("OdaNumarasi")
                        .HasColumnType("smallint");

                    b.Property<short?>("OdaOlcusuM2")
                        .HasColumnType("smallint");

                    b.Property<int>("OdaTuruId")
                        .HasColumnType("int");

                    b.HasKey("OdaId", "OtelId");

                    b.HasIndex("OdaTuruId");

                    b.HasIndex("OtelId");

                    b.ToTable("OtelOdalari");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.OtelSezonKapasitesi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OtelId")
                        .HasColumnType("int");

                    b.Property<int>("OtelSezonKapasite")
                        .HasColumnType("int");

                    b.Property<int>("SezonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OtelId");

                    b.HasIndex("SezonId");

                    b.ToTable("OtelSezonKapasiteleri");
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

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.Sezon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("SezonAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sezonlar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaslangicTarihi = new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BitisTarihi = new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SezonAdi = "Yaz"
                        },
                        new
                        {
                            Id = 2,
                            BaslangicTarihi = new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BitisTarihi = new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SezonAdi = "Kış"
                        });
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

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.OtelOdasi", b =>
                {
                    b.HasOne("OtelRezervasyonApp.Data.Entities.OdaTuru", "OdaTuru")
                        .WithMany()
                        .HasForeignKey("OdaTuruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelRezervasyonApp.Data.Entities.Otel", "Otel")
                        .WithMany("OtelinOdalari")
                        .HasForeignKey("OtelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OdaTuru");

                    b.Navigation("Otel");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.OtelSezonKapasitesi", b =>
                {
                    b.HasOne("OtelRezervasyonApp.Data.Entities.Otel", "Otel")
                        .WithMany("OtelSezonKapasiteleri")
                        .HasForeignKey("OtelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelRezervasyonApp.Data.Entities.Sezon", "Sezon")
                        .WithMany()
                        .HasForeignKey("SezonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Otel");

                    b.Navigation("Sezon");
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

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.Otel", b =>
                {
                    b.Navigation("OtelSezonKapasiteleri");

                    b.Navigation("OtelinOdalari");
                });

            modelBuilder.Entity("OtelRezervasyonApp.Data.Entities.Ulke", b =>
                {
                    b.Navigation("Sehirler");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using EfCoreBahis.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreBahis.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20221115153037_initDb")]
    partial class initDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.BahisCesit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("BahisKonusuId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<double>("Oran")
                        .HasColumnType("float");

                    b.Property<int>("OynananId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("BahisKonusuId");

                    b.HasIndex("OynananId");

                    b.ToTable("BahisCesitleri");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.BahisHareket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BahisCesitId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("OynananTutar")
                        .HasColumnType("float");

                    b.Property<int>("OynayanId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BahisCesitId");

                    b.HasIndex("OynayanId");

                    b.ToTable("BahisHareketleri");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.BahisKonusu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Acikmi")
                        .HasColumnType("bit");

                    b.Property<string>("BahisAciklama")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<DateTime>("KapanisSaati")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("BahisKonulari");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.Kasa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<string>("KasaAdi")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<double>("ToplamBakiye")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("KasaAdi")
                        .IsUnique();

                    b.ToTable("Kasalar");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.KasaHareket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BahisCesitId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<byte>("HareketTipi")
                        .HasColumnType("tinyint");

                    b.Property<int>("KasaId")
                        .HasColumnType("int");

                    b.Property<int>("OynayanId")
                        .HasColumnType("int");

                    b.Property<double>("Tutar")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("BahisCesitId");

                    b.HasIndex("KasaId");

                    b.HasIndex("OynayanId");

                    b.ToTable("KasaHareketleri");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.Oynanan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("BahisKonusuId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<double>("Guc")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("BahisKonusuId");

                    b.ToTable("Oyanananlar");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.Oynayan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Bakiye")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<string>("TcNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("TcNo")
                        .IsUnique();

                    b.ToTable("Oynayanlar");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.BahisCesit", b =>
                {
                    b.HasOne("EfCoreBahis.Entites.Concrete.BahisKonusu", "BahisKonusu")
                        .WithMany("BahisCesitleri")
                        .HasForeignKey("BahisKonusuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreBahis.Entites.Concrete.Oynanan", "Oynanan")
                        .WithMany("BahisCesitleri")
                        .HasForeignKey("OynananId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BahisKonusu");

                    b.Navigation("Oynanan");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.BahisHareket", b =>
                {
                    b.HasOne("EfCoreBahis.Entites.Concrete.BahisCesit", "BahisCesit")
                        .WithMany()
                        .HasForeignKey("BahisCesitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreBahis.Entites.Concrete.Oynayan", "Oynayan")
                        .WithMany()
                        .HasForeignKey("OynayanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BahisCesit");

                    b.Navigation("Oynayan");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.KasaHareket", b =>
                {
                    b.HasOne("EfCoreBahis.Entites.Concrete.BahisCesit", "BahisCesit")
                        .WithMany()
                        .HasForeignKey("BahisCesitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreBahis.Entites.Concrete.Kasa", "Kasa")
                        .WithMany("KasaHareketleri")
                        .HasForeignKey("KasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreBahis.Entites.Concrete.Oynayan", "Oynayan")
                        .WithMany()
                        .HasForeignKey("OynayanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BahisCesit");

                    b.Navigation("Kasa");

                    b.Navigation("Oynayan");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.Oynanan", b =>
                {
                    b.HasOne("EfCoreBahis.Entites.Concrete.BahisKonusu", null)
                        .WithMany("Oyuncular")
                        .HasForeignKey("BahisKonusuId");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.BahisKonusu", b =>
                {
                    b.Navigation("BahisCesitleri");

                    b.Navigation("Oyuncular");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.Kasa", b =>
                {
                    b.Navigation("KasaHareketleri");
                });

            modelBuilder.Entity("EfCoreBahis.Entites.Concrete.Oynanan", b =>
                {
                    b.Navigation("BahisCesitleri");
                });
#pragma warning restore 612, 618
        }
    }
}

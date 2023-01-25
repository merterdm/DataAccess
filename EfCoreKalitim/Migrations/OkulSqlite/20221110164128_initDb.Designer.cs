﻿// <auto-generated />
using System;
using EfCoreKalitim.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreKalitim.Migrations.OkulSqlite
{
    [DbContext(typeof(OkulSqliteContext))]
    [Migration("20221110164128_initDb")]
    partial class initDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("EfCoreKalitim.Concrete.Brans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BransAdi")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Branslar");
                });

            modelBuilder.Entity("EfCoreKalitim.Concrete.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Cinsiyet")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DogumTarihi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gsm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("EfCoreKalitim.Concrete.Ogretmen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("BransId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Cinsiyet")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("GSM")
                        .HasColumnType("TEXT");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BransId");

                    b.ToTable("Ogretmenler");
                });

            modelBuilder.Entity("EfCoreKalitim.Concrete.Sinif", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Kapasite")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SinifAdi")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sinif");
                });

            modelBuilder.Entity("EfCoreKalitim.Concrete.Ogretmen", b =>
                {
                    b.HasOne("EfCoreKalitim.Concrete.Brans", "Brans")
                        .WithMany("Ogretmenler")
                        .HasForeignKey("BransId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brans");
                });

            modelBuilder.Entity("EfCoreKalitim.Concrete.Brans", b =>
                {
                    b.Navigation("Ogretmenler");
                });
#pragma warning restore 612, 618
        }
    }
}

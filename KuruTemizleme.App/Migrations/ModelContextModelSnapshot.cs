﻿// <auto-generated />
using System;
using KuruTemizleme.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KuruTemizleme.App.Migrations
{
    [DbContext(typeof(ModelContext))]
    partial class ModelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KuruTemizleme.App.Models.LogTable", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("kullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("tarihSaat")
                        .HasColumnType("datetime2");

                    b.Property<string>("yapilanIslem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("id")
                        .IsUnique();

                    b.ToTable("LogKayit", (string)null);
                });

            modelBuilder.Entity("KuruTemizleme.App.Models.Randevu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("adet")
                        .HasColumnType("int");

                    b.Property<string>("durum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kiyafetTip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("makbuz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("musteriAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("musteriNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("teslim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("tutar")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("id")
                        .IsUnique();

                    b.ToTable("Randevu", (string)null);
                });

            modelBuilder.Entity("KuruTemizleme.App.Models.Ucretler", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("islemAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ucret")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("id")
                        .IsUnique();

                    b.ToTable("Ucretler", (string)null);
                });

            modelBuilder.Entity("KuruTemizleme.App.Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cinsiyet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("id")
                        .IsUnique();

                    b.ToTable("Users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

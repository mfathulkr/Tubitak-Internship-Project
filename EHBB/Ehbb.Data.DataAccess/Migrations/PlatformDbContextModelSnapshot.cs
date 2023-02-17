﻿// <auto-generated />
using System;
using Ehbb.Data.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ehbb.Data.DataAccess.Migrations
{
    [DbContext(typeof(PlatformDbContext))]
    partial class PlatformDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.Emitter", b =>
                {
                    b.Property<int>("EmitterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmitterID"));

                    b.Property<string>("EmitterDescription")
                        .HasColumnType("text");

                    b.Property<string>("EmitterFunction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmitterName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Notation")
                        .HasColumnType("text");

                    b.Property<int?>("NumOfModes")
                        .HasColumnType("integer");

                    b.Property<string>("SpotNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EmitterID");

                    b.ToTable("Emitters");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.EmitterMode", b =>
                {
                    b.Property<int>("EmitterModeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmitterModeID"));

                    b.Property<int?>("EmitterID")
                        .HasColumnType("integer");

                    b.Property<string>("EmitterModeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("PDlimits")
                        .HasMaxLength(100000)
                        .HasColumnType("double precision");

                    b.Property<double>("PRIlimits")
                        .HasMaxLength(100000)
                        .HasColumnType("double precision");

                    b.Property<double>("RFlimits")
                        .HasMaxLength(100000)
                        .HasColumnType("double precision");

                    b.Property<double>("ScanLimits")
                        .HasMaxLength(10000)
                        .HasColumnType("double precision");

                    b.HasKey("EmitterModeID");

                    b.HasIndex("EmitterID");

                    b.ToTable("EmitterModes");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.Laser", b =>
                {
                    b.Property<int>("LaserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LaserID"));

                    b.Property<string>("LaserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("OperatingTemperature")
                        .HasMaxLength(100)
                        .HasColumnType("double precision");

                    b.Property<double?>("Power")
                        .HasMaxLength(100000)
                        .HasColumnType("double precision");

                    b.Property<string>("SpotNumber")
                        .HasColumnType("text");

                    b.Property<double?>("StorageTemperature")
                        .HasMaxLength(100)
                        .HasColumnType("double precision");

                    b.Property<double?>("Weight")
                        .HasMaxLength(1000)
                        .HasColumnType("double precision");

                    b.HasKey("LaserID");

                    b.ToTable("Lasers");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.LaserMode", b =>
                {
                    b.Property<int>("LaserModeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LaserModeID"));

                    b.Property<int>("LaserID")
                        .HasColumnType("integer");

                    b.Property<string>("LaserModeCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LaserModeInfo")
                        .HasColumnType("text");

                    b.Property<double?>("LaserModePRI")
                        .HasMaxLength(1000000)
                        .HasColumnType("double precision");

                    b.Property<double?>("LaserModePulseDuration")
                        .HasMaxLength(1000000)
                        .HasColumnType("double precision");

                    b.Property<double?>("ScanPeriod")
                        .HasMaxLength(1000000)
                        .HasColumnType("double precision");

                    b.HasKey("LaserModeID");

                    b.HasIndex("LaserID");

                    b.ToTable("LaserModes");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.Platform", b =>
                {
                    b.Property<int>("PlatformID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PlatformID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateLastUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("Height")
                        .HasColumnType("double precision");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Length")
                        .HasColumnType("double precision");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("MaxSpeed")
                        .HasColumnType("double precision");

                    b.Property<double>("MinSpeed")
                        .HasColumnType("double precision");

                    b.Property<int>("PlatformCategory")
                        .HasColumnType("integer");

                    b.Property<string>("PlatformName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PlatformType")
                        .HasColumnType("integer");

                    b.Property<string>("Remarks")
                        .HasColumnType("text");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.Property<double>("Width")
                        .HasColumnType("double precision");

                    b.HasKey("PlatformID");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.PlatformEmitter", b =>
                {
                    b.Property<int>("PlatformEmitterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PlatformEmitterID"));

                    b.Property<int>("EmitterID")
                        .HasColumnType("integer");

                    b.Property<int>("PlatformID")
                        .HasColumnType("integer");

                    b.HasKey("PlatformEmitterID");

                    b.HasIndex("EmitterID");

                    b.HasIndex("PlatformID");

                    b.ToTable("PlatformEmitter");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.PlatformLaser", b =>
                {
                    b.Property<int>("PlatformLaserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PlatformLaserID"));

                    b.Property<int>("LaserID")
                        .HasColumnType("integer");

                    b.Property<int>("PlatformID")
                        .HasColumnType("integer");

                    b.HasKey("PlatformLaserID");

                    b.HasIndex("LaserID");

                    b.HasIndex("PlatformID");

                    b.ToTable("PlatformLaser");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.EmitterMode", b =>
                {
                    b.HasOne("Ehbb.Data.Entities.Entities.Emitter", "Emitter")
                        .WithMany("EmitterModes")
                        .HasForeignKey("EmitterID");

                    b.Navigation("Emitter");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.LaserMode", b =>
                {
                    b.HasOne("Ehbb.Data.Entities.Entities.Laser", "LaserThreat")
                        .WithMany("LaserModes")
                        .HasForeignKey("LaserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LaserThreat");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.PlatformEmitter", b =>
                {
                    b.HasOne("Ehbb.Data.Entities.Entities.Emitter", "Emitter")
                        .WithMany()
                        .HasForeignKey("EmitterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ehbb.Data.Entities.Entities.Platform", "Platform")
                        .WithMany()
                        .HasForeignKey("PlatformID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Emitter");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.PlatformLaser", b =>
                {
                    b.HasOne("Ehbb.Data.Entities.Entities.Laser", "Laser")
                        .WithMany()
                        .HasForeignKey("LaserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ehbb.Data.Entities.Entities.Platform", "Platform")
                        .WithMany()
                        .HasForeignKey("PlatformID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laser");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.Emitter", b =>
                {
                    b.Navigation("EmitterModes");
                });

            modelBuilder.Entity("Ehbb.Data.Entities.Entities.Laser", b =>
                {
                    b.Navigation("LaserModes");
                });
#pragma warning restore 612, 618
        }
    }
}

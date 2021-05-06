﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using feudalismData;

namespace feudalismData.Migrations
{
    [DbContext(typeof(FeudalismContext))]
    partial class FeudalismContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("feudalismData.Character", b =>
                {
                    b.Property<string>("CharacterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CharacterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourtesyTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dynasty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("feudalismData.Province", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CharactersCharacterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerrainDetailsTerrainDetailId")
                        .HasColumnType("int");

                    b.Property<int>("TerrainId")
                        .HasColumnType("int");

                    b.HasKey("ProvinceId");

                    b.HasIndex("CharactersCharacterId");

                    b.HasIndex("TerrainDetailsTerrainDetailId");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("feudalismData.TerrainDetail", b =>
                {
                    b.Property<int>("TerrainDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TerrainDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TravelSpeed")
                        .HasColumnType("int");

                    b.HasKey("TerrainDetailId");

                    b.ToTable("TerrainDetails");
                });

            modelBuilder.Entity("feudalismData.Province", b =>
                {
                    b.HasOne("feudalismData.Character", "Characters")
                        .WithMany("Provinces")
                        .HasForeignKey("CharactersCharacterId");

                    b.HasOne("feudalismData.TerrainDetail", "TerrainDetails")
                        .WithMany("Provinces")
                        .HasForeignKey("TerrainDetailsTerrainDetailId");

                    b.Navigation("Characters");

                    b.Navigation("TerrainDetails");
                });

            modelBuilder.Entity("feudalismData.Character", b =>
                {
                    b.Navigation("Provinces");
                });

            modelBuilder.Entity("feudalismData.TerrainDetail", b =>
                {
                    b.Navigation("Provinces");
                });
#pragma warning restore 612, 618
        }
    }
}

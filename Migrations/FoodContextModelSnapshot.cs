﻿// <auto-generated />
using System;
using EmptyFridge.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmptyFridge.Migrations
{
    [DbContext(typeof(FoodContext))]
    partial class FoodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("EmptyFridge.Models.AmountMeasure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MeasureUnitId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MeasureUnitId");

                    b.ToTable("AmountMeasure");
                });

            modelBuilder.Entity("EmptyFridge.Models.FoodGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FoodGroup");
                });

            modelBuilder.Entity("EmptyFridge.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AmountMeasureId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FoodGroupId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AmountMeasureId");

                    b.HasIndex("FoodGroupId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("EmptyFridge.Models.MeasureUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Unit")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MeasureUnit");
                });

            modelBuilder.Entity("EmptyFridge.Models.AmountMeasure", b =>
                {
                    b.HasOne("EmptyFridge.Models.MeasureUnit", "MeasureUnit")
                        .WithMany()
                        .HasForeignKey("MeasureUnitId");

                    b.Navigation("MeasureUnit");
                });

            modelBuilder.Entity("EmptyFridge.Models.Ingredient", b =>
                {
                    b.HasOne("EmptyFridge.Models.AmountMeasure", "AmountMeasure")
                        .WithMany()
                        .HasForeignKey("AmountMeasureId");

                    b.HasOne("EmptyFridge.Models.FoodGroup", "FoodGroup")
                        .WithMany()
                        .HasForeignKey("FoodGroupId");

                    b.Navigation("AmountMeasure");

                    b.Navigation("FoodGroup");
                });
#pragma warning restore 612, 618
        }
    }
}

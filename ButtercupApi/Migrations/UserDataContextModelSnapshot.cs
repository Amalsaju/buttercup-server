﻿// <auto-generated />
using ButtercupAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ButtercupApi.Migrations
{
    [DbContext(typeof(UserDataContext))]
    partial class UserDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("ButtercupAPI.Models.UserData", b =>
                {
                    b.Property<string>("tideUID")
                        .HasColumnType("TEXT");

                    b.Property<string>("vaultData")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("vaultName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("tideUID");

                    b.ToTable("UserDatas");
                });
#pragma warning restore 612, 618
        }
    }
}

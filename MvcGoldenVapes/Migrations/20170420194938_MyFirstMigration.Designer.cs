using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MvcGoldenVapes.Data;

namespace MvcGoldenVapes.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20170420194938_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcGoldenVapes.Models.ShoppingCartModels.vapeProducts", b =>
                {
                    b.Property<int>("VapeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("VapeBrand");

                    b.Property<string>("VapeName");

                    b.Property<double>("VapePrice");

                    b.Property<string>("VapeSize");

                    b.Property<int>("VapeStock");

                    b.HasKey("VapeID");

                    b.ToTable("VapeJuices");
                });
        }
    }
}

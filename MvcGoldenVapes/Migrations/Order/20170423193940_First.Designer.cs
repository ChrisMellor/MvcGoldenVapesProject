using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MvcGoldenVapes.Data;

namespace MvcGoldenVapes.Migrations.Order
{
    [DbContext(typeof(OrderContext))]
    [Migration("20170423193940_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcGoldenVapes.Models.Cart", b =>
                {
                    b.Property<int>("VapeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Quantity");

                    b.Property<string>("SubTotal");

                    b.Property<string>("VapeName");

                    b.Property<double>("VapePrice");

                    b.HasKey("VapeID");

                    b.ToTable("CustomerOrders");
                });
        }
    }
}

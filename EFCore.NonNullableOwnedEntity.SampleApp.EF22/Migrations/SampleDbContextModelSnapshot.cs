﻿// <auto-generated />
using EFCore.NonNullableOwnedEntity.SampleApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.NonNullableOwnedEntity.SampleApp.EF22.Migrations
{
    [DbContext(typeof(SampleDbContext))]
    partial class SampleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.NonNullableOwnedEntity.SampleApp.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("EFCore.NonNullableOwnedEntity.SampleApp.Models.Person", b =>
                {
                    b.OwnsOne("EFCore.NonNullableOwnedEntity.SampleApp.Models.Metric", "Metric", b1 =>
                        {
                            b1.Property<int>("PersonId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<double>("Height");

                            b1.Property<double>("Weight");

                            b1.HasKey("PersonId");

                            b1.ToTable("People");

                            b1.HasOne("EFCore.NonNullableOwnedEntity.SampleApp.Models.Person")
                                .WithOne("Metric")
                                .HasForeignKey("EFCore.NonNullableOwnedEntity.SampleApp.Models.Metric", "PersonId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

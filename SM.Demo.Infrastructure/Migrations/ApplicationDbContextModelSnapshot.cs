﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SM.Demo.Infrastructure;

namespace SM.Demo.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<Guid>("AuthorsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BooksId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("SM.Demo.Domain.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("51fb4291-d963-4750-8037-00a64359a91d"),
                            DOB = new DateTime(1999, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Email@Email.com",
                            Name = "First Author"
                        },
                        new
                        {
                            Id = new Guid("67dbb77c-4eb7-47ea-abf8-1a268efef33c"),
                            DOB = new DateTime(1956, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Email@Email.com",
                            Name = "Second Author"
                        },
                        new
                        {
                            Id = new Guid("b1089abe-1540-489c-b30b-b87dace19bd5"),
                            DOB = new DateTime(1980, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Email@Email.com",
                            Name = "Third Author"
                        });
                });

            modelBuilder.Entity("SM.Demo.Domain.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("SM.Demo.Domain.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SM.Demo.Domain.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

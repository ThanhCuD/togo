﻿// <auto-generated />
using System;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210822091510_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18");

            modelBuilder.Entity("Domain.Entities.Task", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnName("content")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnName("created_by")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("create_date")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnName("last_modified_by")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnName("last_modified_date")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnName("user_id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("task");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnName("created_by")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("created_date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnName("last_modified_by")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnName("last_modified_date")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxTodo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("max_to_do")
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(5);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("Domain.Entities.Task", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("UserId")
                        .HasConstraintName("tasks_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

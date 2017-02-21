using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AssignmntOrm;

namespace AssignmntOrm.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20170221084110_database added")]
    partial class databaseadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssignmntOrm.ProductModels", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("HomepageUrl")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.HasKey("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("ProductModels");
                });

            modelBuilder.Entity("AssignmntOrm.UserModels", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("DOB");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("UserId");

                    b.ToTable("UserModels");
                });

            modelBuilder.Entity("AssignmntOrm.ProductModels", b =>
                {
                    b.HasOne("AssignmntOrm.UserModels", "UserModel")
                        .WithMany("ProductModels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

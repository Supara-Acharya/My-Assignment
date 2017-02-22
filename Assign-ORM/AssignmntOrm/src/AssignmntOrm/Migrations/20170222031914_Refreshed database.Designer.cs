using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AssignmntOrm;

namespace AssignmntOrm.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20170222031914_Refreshed database")]
    partial class Refresheddatabase
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

                    b.HasKey("ProductId");

                    b.ToTable("ProductModels");
                });

            modelBuilder.Entity("AssignmntOrm.UpdateModels", b =>
                {
                    b.Property<int>("UpdaeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ProductId");

                    b.HasKey("UpdaeId");

                    b.HasIndex("ProductId");

                    b.ToTable("UpdateModels");
                });

            modelBuilder.Entity("AssignmntOrm.UpdateModels", b =>
                {
                    b.HasOne("AssignmntOrm.ProductModels", "ProductModels")
                        .WithMany("UpdateModels")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

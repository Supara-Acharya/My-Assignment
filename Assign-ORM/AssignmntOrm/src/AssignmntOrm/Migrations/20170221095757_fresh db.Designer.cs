using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AssignmntOrm;

namespace AssignmntOrm.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20170221095757_fresh db")]
    partial class freshdb
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

                    b.Property<int?>("ProductModelsProductId");

                    b.Property<int>("UpdateId");

                    b.Property<int?>("UpdateModelUpdaeId");

                    b.HasKey("UpdaeId");

                    b.HasIndex("ProductModelsProductId");

                    b.HasIndex("UpdateModelUpdaeId");

                    b.ToTable("UpdateModels");
                });

            modelBuilder.Entity("AssignmntOrm.UpdateModels", b =>
                {
                    b.HasOne("AssignmntOrm.ProductModels")
                        .WithMany("UpdateModels")
                        .HasForeignKey("ProductModelsProductId");

                    b.HasOne("AssignmntOrm.UpdateModels", "UpdateModel")
                        .WithMany()
                        .HasForeignKey("UpdateModelUpdaeId");
                });
        }
    }
}

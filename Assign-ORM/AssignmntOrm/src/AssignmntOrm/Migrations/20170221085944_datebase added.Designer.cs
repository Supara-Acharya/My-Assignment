using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AssignmntOrm;

namespace AssignmntOrm.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20170221085944_datebase added")]
    partial class datebaseadded
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

                    b.Property<int>("UpdateId");

                    b.Property<int?>("UpdateModelUpdaeId");

                    b.HasKey("ProductId");

                    b.HasIndex("UpdateModelUpdaeId");

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

                    b.HasKey("UpdaeId");

                    b.ToTable("UpdateModels");
                });

            modelBuilder.Entity("AssignmntOrm.ProductModels", b =>
                {
                    b.HasOne("AssignmntOrm.UpdateModels", "UpdateModel")
                        .WithMany("ProductModels")
                        .HasForeignKey("UpdateModelUpdaeId");
                });
        }
    }
}

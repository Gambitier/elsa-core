﻿// <auto-generated />
using Elsa.EntityFrameworkCore.Modules.Labels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elsa.EntityFrameworkCore.MySql.Migrations.Labels
{
    [DbContext(typeof(LabelsElsaDbContext))]
    [Migration("20230517105302_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Elsa")
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Elsa.Labels.Entities.Label", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Color")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Labels", "Elsa");
                });

            modelBuilder.Entity("Elsa.Labels.Entities.WorkflowDefinitionLabel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LabelId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("WorkflowDefinitionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("WorkflowDefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("LabelId")
                        .HasDatabaseName("WorkflowDefinitionLabel_LabelId");

                    b.HasIndex("WorkflowDefinitionId")
                        .HasDatabaseName("WorkflowDefinitionLabel_WorkflowDefinitionId");

                    b.HasIndex("WorkflowDefinitionVersionId")
                        .HasDatabaseName("WorkflowDefinitionLabel_WorkflowDefinitionVersionId");

                    b.ToTable("WorkflowDefinitionLabels", "Elsa");
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using System.Collections.Generic;
using DBRepositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DBRepositories;

public partial class HoaPhat2024Context : DbContext
{
    public HoaPhat2024Context()
    {
    }

    public HoaPhat2024Context(DbContextOptions<HoaPhat2024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<DataReader> DataReaders { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<ErrorDatum> ErrorData { get; set; }

    public virtual DbSet<Model> Models { get; set; }

    public virtual DbSet<ModelDatum> ModelData { get; set; }

    public virtual DbSet<OperationDatum> OperationData { get; set; }

    public virtual DbSet<Operator> Operators { get; set; }

    public virtual DbSet<ProductionOrder> ProductionOrders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());

    private string? GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DBDefault"];
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK__Account__66DCF95D997F15C9");

            entity.ToTable("Account");

            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .HasColumnName("accountName");
            entity.Property(e => e.PassWord)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("passWord");
            entity.Property(e => e.Role).HasColumnName("role");
        });

        modelBuilder.Entity<DataReader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DataRead__3213E83F648F2129");

            entity.ToTable("DataReader");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("barcode");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.GrossWeight).HasColumnName("grossWeight");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modelCode");
            entity.Property(e => e.OperatorName).HasColumnName("operator_name");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");

            entity.HasOne(d => d.ModelCodeNavigation).WithMany(p => p.DataReaders)
                .HasForeignKey(d => d.ModelCode)
                .HasConstraintName("fk_modelCode_DataReader");
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.HasKey(e => e.BitError).HasName("PK__Error__B60A96D027EC2726");

            entity.ToTable("Error");

            entity.Property(e => e.BitError)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("bitError");
            entity.Property(e => e.ErrorName)
                .HasMaxLength(50)
                .HasColumnName("errorName");
            entity.Property(e => e.Solution)
                .HasMaxLength(100)
                .HasColumnName("solution");
        });

        modelBuilder.Entity<ErrorDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ErrorDat__3213E83F4510C862");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BitError)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("bitError");
            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("ngay");

            entity.HasOne(d => d.BitErrorNavigation).WithMany(p => p.ErrorData)
                .HasForeignKey(d => d.BitError)
                .HasConstraintName("fk_bitError_ErrorData");
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.HasKey(e => e.ModelCode).HasName("PK__Model__24A6F7C52434DD09");

            entity.ToTable("Model");

            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modelCode");
            entity.Property(e => e.GrossWeight).HasColumnName("grossWeight");
            entity.Property(e => e.ModelName)
                .HasMaxLength(50)
                .HasColumnName("modelName");
            entity.Property(e => e.ToLerance).HasColumnName("toLerance");
        });

        modelBuilder.Entity<ModelDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ModelDat__3213E83FF4EECD8C");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualOutput).HasColumnName("actualOutput");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExpectedOutput).HasColumnName("expectedOutput");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modelCode");

            entity.HasOne(d => d.ModelCodeNavigation).WithMany(p => p.ModelData)
                .HasForeignKey(d => d.ModelCode)
                .HasConstraintName("fk_modelCode_ModelData");
        });

        modelBuilder.Entity<OperationDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Operatio__3213E83F10C58A58");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EndTime).HasColumnName("endTime");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modelCode");
            entity.Property(e => e.NumOperator).HasColumnName("numOperator");
            entity.Property(e => e.StartTime).HasColumnName("startTime");

            entity.HasOne(d => d.ModelCodeNavigation).WithMany(p => p.OperationData)
                .HasForeignKey(d => d.ModelCode)
                .HasConstraintName("fk_modelCode_OperationData");
        });

        modelBuilder.Entity<Operator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Operator");

            entity.Property(e => e.ExcutionTime).HasColumnName("excutionTime");
            entity.Property(e => e.IsIgnore).HasColumnName("isIgnore");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modelCode");
            entity.Property(e => e.NumOperator).HasColumnName("numOperator");
            entity.Property(e => e.OperatorName)
                .HasMaxLength(100)
                .HasColumnName("operatorName");

            entity.HasOne(d => d.ModelCodeNavigation).WithMany()
                .HasForeignKey(d => d.ModelCode)
                .HasConstraintName("fk_modelCode_Operator");
        });

        modelBuilder.Entity<ProductionOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producti__3213E83F8782C9B5");

            entity.ToTable("ProductionOrder");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualOutput).HasColumnName("actualOutput");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.ExpectedOutput).HasColumnName("expectedOutput");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("modelCode");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");

            entity.HasOne(d => d.ModelCodeNavigation).WithMany(p => p.ProductionOrders)
                .HasForeignKey(d => d.ModelCode)
                .HasConstraintName("fk_modelCode_ProductionOrder");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

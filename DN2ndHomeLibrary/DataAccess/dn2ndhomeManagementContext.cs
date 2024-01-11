using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DN2ndHomeLibrary.DataAccess
{
    public partial class dn2ndhomeManagementContext : DbContext
    {
        public dn2ndhomeManagementContext()
        {
        }

        public dn2ndhomeManagementContext(DbContextOptions<dn2ndhomeManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avatar> Avatars { get; set; } = null!;
        public virtual DbSet<CartNew> CartNews { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<Img> Imgs { get; set; } = null!;
        public virtual DbSet<PrdInfo> PrdInfos { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Ward> Wards { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =(local); database = dn2ndhomeManagement;uid=test;pwd=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avatar>(entity =>
            {
                entity.ToTable("avatar");

                entity.Property(e => e.AvatarId).HasColumnName("avatar_id");

                entity.Property(e => e.Avatar1)
                    .HasColumnType("image")
                    .HasColumnName("avatar");

                entity.Property(e => e.AvatarName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avatar_name");
            });

            modelBuilder.Entity<CartNew>(entity =>
            {
                entity.HasKey(e => e.CartId);

                entity.ToTable("cart_new");

                entity.Property(e => e.CartId).HasColumnName("cart_id");

                entity.Property(e => e.IdPrd).HasColumnName("id_prd");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("district");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.DistrictName)
                    .HasMaxLength(50)
                    .HasColumnName("district_name");
            });

            modelBuilder.Entity<Img>(entity =>
            {
                entity.ToTable("img");

                entity.Property(e => e.ImgId).HasColumnName("img_id");

                entity.Property(e => e.Img1)
                    .HasColumnType("image")
                    .HasColumnName("img");

                entity.Property(e => e.ImgName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("img_name");

                entity.Property(e => e.PrdId).HasColumnName("prd_id");
            });

            modelBuilder.Entity<PrdInfo>(entity =>
            {
                entity.HasKey(e => e.PrdId);

                entity.ToTable("prdInfo");

                entity.Property(e => e.PrdId).HasColumnName("prd_id");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Booked).HasColumnName("booked");

                entity.Property(e => e.CreateDay)
                    .HasColumnType("datetime")
                    .HasColumnName("create_day")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DetailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("detail_address");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.PrdDetail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prd_detail");

                entity.Property(e => e.PrdStatus).HasColumnName("prd_status");

                entity.Property(e => e.PrdTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prd_title");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WardId).HasColumnName("ward_id");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.AvatarId).HasColumnName("avatar_id");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.UserLevel)
                    .HasColumnName("user_level")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.ToTable("ward");

                entity.Property(e => e.WardId).HasColumnName("ward_id");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.WardName)
                    .HasMaxLength(50)
                    .HasColumnName("ward_name");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Wards)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_ward_district");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

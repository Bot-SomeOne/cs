using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.Data;

public partial class QuanlybanhangContext : DbContext
{
    public QuanlybanhangContext()
    {
    }

    public QuanlybanhangContext(DbContextOptions<QuanlybanhangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblChatlieu> TblChatlieus { get; set; }

    public virtual DbSet<TblChitietHdban> TblChitietHdbans { get; set; }

    public virtual DbSet<TblHang> TblHangs { get; set; }

    public virtual DbSet<TblHdban> TblHdbans { get; set; }

    public virtual DbSet<TblKhach> TblKhaches { get; set; }

    public virtual DbSet<TblNhanvien> TblNhanviens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source='192.168.0.101, 1435';Initial Catalog=QUANLYBANHANG;Persist Security Info=True;User ID=sa;Password=P@ss12345;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblChatlieu>(entity =>
        {
            entity.HasKey(e => e.MaChatlieu).HasName("PK__tblChatl__DDC1A44E5FADC192");

            entity.ToTable("tblChatlieu");

            entity.Property(e => e.MaChatlieu).HasMaxLength(10);
            entity.Property(e => e.Tenchatlieu).HasMaxLength(50);
        });

        modelBuilder.Entity<TblChitietHdban>(entity =>
        {
            entity.HasKey(e => new { e.MaHdban, e.Mahang }).HasName("PK__tblChiti__432BD1C83BE40A95");

            entity.ToTable("tblChitietHDBan");

            entity.Property(e => e.MaHdban)
                .HasMaxLength(30)
                .HasColumnName("MaHDBan");
            entity.Property(e => e.Mahang).HasMaxLength(10);

            entity.HasOne(d => d.MaHdbanNavigation).WithMany(p => p.TblChitietHdbans)
                .HasForeignKey(d => d.MaHdban)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblChitie__MaHDB__440B1D61");

            entity.HasOne(d => d.MahangNavigation).WithMany(p => p.TblChitietHdbans)
                .HasForeignKey(d => d.Mahang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblChitie__Mahan__44FF419A");
        });

        modelBuilder.Entity<TblHang>(entity =>
        {
            entity.HasKey(e => e.Mahang).HasName("PK__tblHang__03BBFE21E73D72B5");

            entity.ToTable("tblHang");

            entity.Property(e => e.Mahang).HasMaxLength(10);
            entity.Property(e => e.Anh).HasColumnType("ntext");
            entity.Property(e => e.Ghichu).HasColumnType("ntext");
            entity.Property(e => e.MaChatlieu).HasMaxLength(10);
            entity.Property(e => e.Tenhang).HasMaxLength(50);

            entity.HasOne(d => d.MaChatlieuNavigation).WithMany(p => p.TblHangs)
                .HasForeignKey(d => d.MaChatlieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblHang__MaChatl__398D8EEE");
        });

        modelBuilder.Entity<TblHdban>(entity =>
        {
            entity.HasKey(e => e.MaHdban).HasName("PK__tblHDBan__43106E2AB1988BD8");

            entity.ToTable("tblHDBan");

            entity.Property(e => e.MaHdban)
                .HasMaxLength(30)
                .HasColumnName("MaHDBan");
            entity.Property(e => e.Makhach).HasMaxLength(10);
            entity.Property(e => e.Manhanvien).HasMaxLength(10);

            entity.HasOne(d => d.MakhachNavigation).WithMany(p => p.TblHdbans)
                .HasForeignKey(d => d.Makhach)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblHDBan__Makhac__412EB0B6");

            entity.HasOne(d => d.ManhanvienNavigation).WithMany(p => p.TblHdbans)
                .HasForeignKey(d => d.Manhanvien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblHDBan__Manhan__403A8C7D");
        });

        modelBuilder.Entity<TblKhach>(entity =>
        {
            entity.HasKey(e => e.Makhach).HasName("PK__tblKhach__95457A2AE29AF740");

            entity.ToTable("tblKhach");

            entity.Property(e => e.Makhach).HasMaxLength(10);
            entity.Property(e => e.Diachi).HasColumnType("ntext");
            entity.Property(e => e.Dienthoai).HasMaxLength(15);
            entity.Property(e => e.Tenkhach).HasMaxLength(50);
        });

        modelBuilder.Entity<TblNhanvien>(entity =>
        {
            entity.HasKey(e => e.Manhanvien).HasName("PK__tblNhanv__4015B8D27DC0FF6A");

            entity.ToTable("tblNhanvien");

            entity.Property(e => e.Manhanvien).HasMaxLength(10);
            entity.Property(e => e.Diachi).HasMaxLength(100);
            entity.Property(e => e.Dienthoai).HasMaxLength(15);
            entity.Property(e => e.Gioitinh).HasMaxLength(50);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tennhanvien).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

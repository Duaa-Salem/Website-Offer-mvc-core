using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace duaaOffer.Models
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Home> Home { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Offer> Offer { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<Role> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Test;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>(entity =>
            {
                entity.ToTable("about");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_Register1");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                //entity.Property(e => e.PasswordHash)
                //    .IsRequired()
                //    .HasColumnName("passwordHash")
                //    .HasMaxLength(50)
                //    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("FK_Register1_role");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoryname)
                    .IsRequired()
                    .HasColumnName("categoryname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.ToTable("home");

                entity.Property(e => e.Homeid).HasColumnName("homeid");

                entity.Property(e => e.Aboutid).HasColumnName("aboutid");

                entity.Property(e => e.Contactid).HasColumnName("contactid");

                

                entity.HasOne(d => d.About)
                    .WithMany(p => p.Home)
                    .HasForeignKey(d => d.Aboutid)
                    .HasConstraintName("FK_home_about");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Home)
                    .HasForeignKey(d => d.Contactid)
                    .HasConstraintName("FK_home_contact");

                
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("login");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                //entity.Property(e => e.PasswordHash)
                //    .IsRequired()
                //    .HasColumnName("PasswordHash")
                //    .HasMaxLength(50)
                //    .IsUnicode(false);

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("FK_login_login1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_login_register");
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.ToTable("offer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Communication)
                    .IsRequired()
                    .HasColumnName("communication")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regular)
                    .HasColumnName("regular")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Sale)
                    .HasColumnName("sale")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Startdate).HasColumnName("startdate");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Offer)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_offer_category");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.Offer)
                //    .HasForeignKey(d => d.Userid)
                //    .HasConstraintName("FK_offer_Register1");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("review");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.RoleId).HasColumnName("roleID");

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasColumnName("rolename")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

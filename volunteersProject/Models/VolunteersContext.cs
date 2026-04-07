using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace volunteersProject.Models;

public partial class VolunteersContext : DbContext
{
    public VolunteersContext()
    {
    }

    public VolunteersContext(DbContextOptions<VolunteersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Doing> Doings { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Place> Places { get; set; }

    public virtual DbSet<RegistrationVolunteer> RegistrationVolunteers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<StatusesEvent> StatusesEvents { get; set; }

    public virtual DbSet<StatusesRegistration> StatusesRegistrations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Database=volunteers;Password=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categories_pkey");

            entity.ToTable("categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryName).HasColumnName("category_name");
        });

        modelBuilder.Entity<Doing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("doings_pkey");

            entity.ToTable("doings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountVolunteer).HasColumnName("count_volunteer");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DoingName).HasColumnName("doing_name");
            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.IdPlace).HasColumnName("id_place");
            entity.Property(e => e.IdStatusEvent).HasColumnName("id_status_event");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Doings)
                .HasForeignKey(d => d.IdCategory)
                .HasConstraintName("doings_id_category_fkey");

            entity.HasOne(d => d.IdPlaceNavigation).WithMany(p => p.Doings)
                .HasForeignKey(d => d.IdPlace)
                .HasConstraintName("doings_id_place_fkey");

            entity.HasOne(d => d.IdStatusEventNavigation).WithMany(p => p.Doings)
                .HasForeignKey(d => d.IdStatusEvent)
                .HasConstraintName("doings_id_status_event_fkey");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Doings)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("doings_id_user_fkey");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("events_pkey");

            entity.ToTable("events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EventName).HasColumnName("event_name");
        });

        modelBuilder.Entity<Place>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("places_pkey");

            entity.ToTable("places");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PlaceName).HasColumnName("place_name");
        });

        modelBuilder.Entity<RegistrationVolunteer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("registration_volunteers_pkey");

            entity.ToTable("registration_volunteers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateRegistration).HasColumnName("date_registration");
            entity.Property(e => e.IdEvent).HasColumnName("id_event");
            entity.Property(e => e.IdStatusRegistration).HasColumnName("id_status_registration");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdEventNavigation).WithMany(p => p.RegistrationVolunteers)
                .HasForeignKey(d => d.IdEvent)
                .HasConstraintName("registration_volunteers_id_event_fkey");

            entity.HasOne(d => d.IdStatusRegistrationNavigation).WithMany(p => p.RegistrationVolunteers)
                .HasForeignKey(d => d.IdStatusRegistration)
                .HasConstraintName("registration_volunteers_id_status_registration_fkey");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.RegistrationVolunteers)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("registration_volunteers_id_user_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<StatusesEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses_event");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('statuses_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<StatusesRegistration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_registration_pkey");

            entity.ToTable("statuses_registration");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameStatuses).HasColumnName("name_statuses");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Password).HasColumnName("password");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("users_id_role_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

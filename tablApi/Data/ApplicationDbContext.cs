using System;
using Microsoft.EntityFrameworkCore;
using tablApi.Model;
namespace tablApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options){}
    public DbSet<User> Users { get; set; }
    public DbSet<Tutor> Tutors { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<ClassSchedule> ClassSchedules { get; set; }
    public DbSet<ClassEntry> ClassEntries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure primary keys
        modelBuilder.Entity<User>().HasKey(e => e.User_ID);
        modelBuilder.Entity<Tutor>().HasKey(e => e.Tutor_ID);
        modelBuilder.Entity<Student>().HasKey(e => e.Student_ID);
        modelBuilder.Entity<Class>().HasKey(e => e.Class_ID);
        modelBuilder.Entity<ClassSchedule>().HasKey(e => e.Schedule_ID);
        modelBuilder.Entity<ClassEntry>().HasKey(e => e.ClassEntry_ID);

        // User-Student relationship (One-to-One)
        modelBuilder.Entity<User>()
            .HasOne(u => u.Student)
            .WithOne(s => s.User)
            .HasForeignKey<Student>(s => s.User_ID)
            .OnDelete(DeleteBehavior.Restrict);

        // User-Tutor relationship (One-to-One)
        modelBuilder.Entity<User>()
            .HasOne(u => u.Tutor)
            .WithOne(t => t.User)
            .HasForeignKey<Tutor>(t => t.User_ID)
            .OnDelete(DeleteBehavior.Restrict);

        // Class-Tutor relationship (Many-to-One)
        modelBuilder.Entity<Class>()
            .HasOne(c => c.Tutor)
            .WithMany(t => t.Courses)
            .HasForeignKey(c => c.Tutor_ID)
            .OnDelete(DeleteBehavior.Restrict);

        // Class-Student relationship (Many-to-Many)
        modelBuilder.Entity<Class>()
            .HasMany(c => c.EnrolledStudents)
            .WithMany(s => s.EnrolledClasses)
            .UsingEntity(j => j.ToTable("ClassStudents"));

        // Class-ClassSchedule relationship (One-to-Many)
        modelBuilder.Entity<Class>()
            .HasMany(c => c.Schedules)
            .WithOne(s => s.Class)
            .HasForeignKey(s => s.Class_ID)
            .OnDelete(DeleteBehavior.Restrict);

        // ClassSchedule-ClassEntry relationship (One-to-Many)
        modelBuilder.Entity<ClassSchedule>()
            .HasMany(s => s.ClassEntries)
            .WithOne(e => e.ClassSchedule)
            .HasForeignKey(e => e.ClassSchedule_ID)
            .OnDelete(DeleteBehavior.Restrict);

        // Class-ClassEntry relationship (One-to-Many)
        modelBuilder.Entity<Class>()
            .HasMany(c => c.ClassEntries)
            .WithOne(e => e.Class)
            .HasForeignKey(e => e.Class_ID)
            .OnDelete(DeleteBehavior.Restrict);

        // ClassEntry-Student relationship (Many-to-Many)
        modelBuilder.Entity<ClassEntry>()
            .HasMany(e => e.Students)
            .WithMany(s => s.ClassEntries)
            .UsingEntity(j => j.ToTable("ClassEntryStudents"));

        // Seed Data
        modelBuilder.Entity<User>().HasData(
            new User { 
                User_ID = 1, 
                User_email = "admin@school.com", 
                User_password = "admin123", 
                User_type = "Admin" 
            },
            new User { 
                User_ID = 2, 
                User_email = "john.doe@school.com", 
                User_password = "hashed_password_2", 
                User_type = "Tutor" 
            },
            new User { 
                User_ID = 3, 
                User_email = "jane.smith@school.com", 
                User_password = "hashed_password_3", 
                User_type = "Tutor" 
            },
            new User { 
                User_ID = 4, 
                User_email = "alice@student.com", 
                User_password = "hashed_password_4", 
                User_type = "Student" 
            },
            new User { 
                User_ID = 5, 
                User_email = "bob@student.com", 
                User_password = "hashed_password_5", 
                User_type = "Student" 
            },
            new User { 
                User_ID = 6, 
                User_email = "charlie@student.com", 
                User_password = "hashed_password_6", 
                User_type = "Student" 
            }
        );

        modelBuilder.Entity<Tutor>().HasData(
            new Tutor { 
                Tutor_ID = 1, 
                Tutor_firstName = "John", 
                Tutor_LastName = "Doe", 
                User_ID = 2 
            },
            new Tutor { 
                Tutor_ID = 2, 
                Tutor_firstName = "Jane", 
                Tutor_LastName = "Smith", 
                User_ID = 3 
            }
        );

        modelBuilder.Entity<Student>().HasData(
            new Student { 
                Student_ID = 1, 
                Student_firstName = "Alice", 
                Student_LastName = "Johnson", 
                student_yearLevel = 1, 
                User_ID = 4 
            },
            new Student { 
                Student_ID = 2, 
                Student_firstName = "Bob", 
                Student_LastName = "Williams", 
                student_yearLevel = 2, 
                User_ID = 5 
            },
            new Student { 
                Student_ID = 3, 
                Student_firstName = "Charlie", 
                Student_LastName = "Brown", 
                student_yearLevel = 1, 
                User_ID = 6 
            }
        );

        modelBuilder.Entity<Class>().HasData(
            new Class { 
                Class_ID = 1, 
                Class_Name = "Mathematics", 
                Class_Desc = "Advanced mathematics class covering calculus and linear algebra",
                Class_yearLevel = 1,
                StartDate = new DateTime(2024, 5, 26),
                EndDate = new DateTime(2024, 6, 20),
                Tutor_ID = 1
            },
            new Class { 
                Class_ID = 2, 
                Class_Name = "Physics", 
                Class_Desc = "Introduction to physics covering mechanics and thermodynamics",
                Class_yearLevel = 1,
                StartDate = new DateTime(2024, 5, 26),
                EndDate = new DateTime(2024, 6, 20),
                Tutor_ID = 1
            },
            new Class { 
                Class_ID = 3, 
                Class_Name = "Computer Science", 
                Class_Desc = "Programming fundamentals and data structures",
                Class_yearLevel = 1,
                StartDate = new DateTime(2024, 5, 26),
                EndDate = new DateTime(2024, 6, 20),
                Tutor_ID = 2
            }
        );

        modelBuilder.Entity<ClassSchedule>().HasData(
            // Mathematics Class Schedules
            new ClassSchedule { 
                Schedule_ID = 1, 
                Class_ID = 1, 
                DayOfWeek = DayOfWeek.Monday, 
                StartTime = new TimeSpan(9, 0, 0), 
                EndTime = new TimeSpan(11, 0, 0),
                Room = "Room 101"
            },
            new ClassSchedule { 
                Schedule_ID = 2, 
                Class_ID = 1, 
                DayOfWeek = DayOfWeek.Wednesday, 
                StartTime = new TimeSpan(9, 0, 0), 
                EndTime = new TimeSpan(11, 0, 0),
                Room = "Room 101"
            },
            new ClassSchedule { 
                Schedule_ID = 3, 
                Class_ID = 1, 
                DayOfWeek = DayOfWeek.Friday, 
                StartTime = new TimeSpan(9, 0, 0), 
                EndTime = new TimeSpan(11, 0, 0),
                Room = "Room 101"
            },

            // Physics Class Schedules
            new ClassSchedule { 
                Schedule_ID = 4, 
                Class_ID = 2, 
                DayOfWeek = DayOfWeek.Monday, 
                StartTime = new TimeSpan(13, 0, 0), 
                EndTime = new TimeSpan(15, 0, 0),
                Room = "Room 102"
            },
            new ClassSchedule { 
                Schedule_ID = 5, 
                Class_ID = 2, 
                DayOfWeek = DayOfWeek.Wednesday, 
                StartTime = new TimeSpan(13, 0, 0), 
                EndTime = new TimeSpan(15, 0, 0),
                Room = "Room 102"
            },
            new ClassSchedule { 
                Schedule_ID = 6, 
                Class_ID = 2, 
                DayOfWeek = DayOfWeek.Friday, 
                StartTime = new TimeSpan(13, 0, 0), 
                EndTime = new TimeSpan(15, 0, 0),
                Room = "Room 102"
            },

            // Computer Science Class Schedules
            new ClassSchedule { 
                Schedule_ID = 7, 
                Class_ID = 3, 
                DayOfWeek = DayOfWeek.Tuesday, 
                StartTime = new TimeSpan(9, 0, 0), 
                EndTime = new TimeSpan(11, 0, 0),
                Room = "Room 103"
            },
            new ClassSchedule { 
                Schedule_ID = 8, 
                Class_ID = 3, 
                DayOfWeek = DayOfWeek.Thursday, 
                StartTime = new TimeSpan(9, 0, 0), 
                EndTime = new TimeSpan(11, 0, 0),
                Room = "Room 103"
            }
        );
    }
}


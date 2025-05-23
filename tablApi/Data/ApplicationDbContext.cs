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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure primary keys
        modelBuilder.Entity<User>().HasKey(e => e.User_ID);
        modelBuilder.Entity<Tutor>().HasKey(e => e.Tutor_ID);
        modelBuilder.Entity<Student>().HasKey(e => e.Student_ID);
        modelBuilder.Entity<Class>().HasKey(e => e.Class_ID);
        modelBuilder.Entity<ClassSchedule>().HasKey(e => e.Schedule_ID);

        // User-Tutor relationship (One-to-One)
        modelBuilder.Entity<User>()
            .HasOne(u => u.Tutor)
            .WithOne(t => t.User)
            .HasForeignKey<Tutor>(d => d.User_ID)
            .OnDelete(DeleteBehavior.Restrict);

        // User-Student relationship (One-to-One)
        modelBuilder.Entity<User>()
            .HasOne(u => u.Student)
            .WithOne(s => s.User)
            .HasForeignKey<Student>(s => s.User_ID)
            .OnDelete(DeleteBehavior.Restrict);

        // Tutor-Class relationship (One-to-Many)
        modelBuilder.Entity<Tutor>()
            .HasMany(t => t.Courses)
            .WithOne(c => c.Tutor)
            .HasForeignKey(c => c.Tutor_ID)
            .OnDelete(DeleteBehavior.Restrict);

        // Student-Class relationship (One-to-Many)
        modelBuilder.Entity<Student>()
            .HasMany(s => s.EnrolledCLass)
            .WithMany(c => c.EnrolledStudents)
            .UsingEntity(j => j.ToTable("StudentClasses"));

        // Class-ClassSchedule relationship (One-to-Many)
        modelBuilder.Entity<Class>()
            .HasMany(c => c.Schedules)
            .WithOne(s => s.Class)
            .HasForeignKey(s => s.Class_ID)
            .OnDelete(DeleteBehavior.Cascade);

        // Seed Data
        modelBuilder.Entity<User>().HasData(
            new User { User_ID = 1, User_email = "admin", User_password = "admin", User_type = "Admin" },
            new User { User_ID = 2, User_email = "jane.smith@email.com", User_password = "hashed_password_2", User_type = "Tutor" },
            new User { User_ID = 3, User_email = "alice@email.com", User_password = "hashed_password_3", User_type = "Student" },
            new User { User_ID = 4, User_email = "bob@email.com", User_password = "hashed_password_4", User_type = "Student" },
            new User { User_ID = 5, User_email = "charlie@email.com", User_password = "hashed_password_5", User_type = "Student" }
        );

        modelBuilder.Entity<Tutor>().HasData(
            new Tutor { Tutor_ID = 1, Tutor_firstName = "John", Tutor_LastName = "Doe", User_ID = 1 },
            new Tutor { Tutor_ID = 2, Tutor_firstName = "Jane", Tutor_LastName = "Smith", User_ID = 2 }
        );

        modelBuilder.Entity<Student>().HasData(
            new Student { Student_ID = 1, Student_firstName = "Alice", Student_LastName = "Johnson", student_yearLevel = 1, User_ID = 3 },
            new Student { Student_ID = 2, Student_firstName = "Bob", Student_LastName = "Williams", student_yearLevel = 2, User_ID = 4 },
            new Student { Student_ID = 3, Student_firstName = "Charlie", Student_LastName = "Brown", student_yearLevel = 1, User_ID = 5 }
        );

        modelBuilder.Entity<Class>().HasData(
            new Class { 
                Class_ID = 1, 
                Class_Name = "Mathematics", 
                Class_Desc = "Advanced mathematics class",
                Class_yearLevel = 1,
                StartDate = new DateTime(2025, 5, 19),
                EndDate = new DateTime(2025, 6, 13),
                Tutor_ID = 1
            },
            new Class { 
                Class_ID = 2, 
                Class_Name = "Physics", 
                Class_Desc = "Introduction to physics",
                Class_yearLevel = 1,
                StartDate = new DateTime(2025, 5, 19),
                EndDate = new DateTime(2025, 6, 13),
                Tutor_ID = 1
            },
            new Class { 
                Class_ID = 3, 
                Class_Name = "Computer Science", 
                Class_Desc = "Programming fundamentals",
                Class_yearLevel = 1,
                StartDate = new DateTime(2025, 5, 19),
                EndDate = new DateTime(2025, 6, 13),
                Tutor_ID = 2
            },
            new Class { 
                Class_ID = 4, 
                Class_Name = "English", 
                Class_Desc = "English literature and composition",
                Class_yearLevel = 1,
                StartDate = new DateTime(2025, 5, 19),
                EndDate = new DateTime(2025, 6, 13),
                Tutor_ID = 2
            },
            new Class { 
                Class_ID = 5, 
                Class_Name = "History", 
                Class_Desc = "World history overview",
                Class_yearLevel = 1,
                StartDate = new DateTime(2025, 5, 19),
                EndDate = new DateTime(2025, 6, 13),
                Tutor_ID = 1
            }
        );

        modelBuilder.Entity<ClassSchedule>().HasData(
            // Mathematics Class Schedules (3 days)
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

            // Physics Class Schedules (3 days)
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

            // Computer Science Class Schedules (3 days)
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
            },
            new ClassSchedule { 
                Schedule_ID = 9, 
                Class_ID = 3, 
                DayOfWeek = DayOfWeek.Friday, 
                StartTime = new TimeSpan(13, 0, 0), 
                EndTime = new TimeSpan(15, 0, 0),
                Room = "Room 103"
            },

            // English Class Schedules (3 days)
            new ClassSchedule { 
                Schedule_ID = 10, 
                Class_ID = 4, 
                DayOfWeek = DayOfWeek.Monday, 
                StartTime = new TimeSpan(13, 0, 0), 
                EndTime = new TimeSpan(15, 0, 0),
                Room = "Room 104"
            },
            new ClassSchedule { 
                Schedule_ID = 11, 
                Class_ID = 4, 
                DayOfWeek = DayOfWeek.Tuesday, 
                StartTime = new TimeSpan(13, 0, 0), 
                EndTime = new TimeSpan(15, 0, 0),
                Room = "Room 104"
            },
            new ClassSchedule { 
                Schedule_ID = 12, 
                Class_ID = 4, 
                DayOfWeek = DayOfWeek.Thursday, 
                StartTime = new TimeSpan(13, 0, 0), 
                EndTime = new TimeSpan(15, 0, 0),
                Room = "Room 104"
            },

            // History Class Schedules (3 days)
            new ClassSchedule { 
                Schedule_ID = 13, 
                Class_ID = 5, 
                DayOfWeek = DayOfWeek.Tuesday, 
                StartTime = new TimeSpan(9, 0, 0), 
                EndTime = new TimeSpan(11, 0, 0),
                Room = "Room 105"
            },
            new ClassSchedule { 
                Schedule_ID = 14, 
                Class_ID = 5, 
                DayOfWeek = DayOfWeek.Wednesday, 
                StartTime = new TimeSpan(13, 0, 0), 
                EndTime = new TimeSpan(15, 0, 0),
                Room = "Room 105"
            },
            new ClassSchedule { 
                Schedule_ID = 15, 
                Class_ID = 5, 
                DayOfWeek = DayOfWeek.Friday, 
                StartTime = new TimeSpan(9, 0, 0), 
                EndTime = new TimeSpan(11, 0, 0),
                Room = "Room 105"
            }
        );
    }
}


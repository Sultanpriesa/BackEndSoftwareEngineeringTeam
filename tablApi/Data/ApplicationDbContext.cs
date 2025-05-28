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
    public DbSet<ClassList> ClassLists { get; set; }
    public DbSet<StudentClassEntry> StudentClassEntries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure primary keys
        modelBuilder.Entity<User>().HasKey(e => e.User_ID);
        modelBuilder.Entity<Tutor>().HasKey(e => e.Tutor_ID);
        modelBuilder.Entity<Student>().HasKey(e => e.Student_ID);
        modelBuilder.Entity<Class>().HasKey(e => e.Class_ID);
        modelBuilder.Entity<ClassSchedule>().HasKey(e => e.Schedule_ID);
        modelBuilder.Entity<ClassEntry>().HasKey(e => e.ClassEntry_ID);
        modelBuilder.Entity<ClassList>().HasKey(e => new { e.Student_ID, e.Class_ID });
        modelBuilder.Entity<StudentClassEntry>().HasKey(e => new { e.Student_ID, e.ClassEntry_ID });

        // Configure relationships
        // User to Student (One-to-One)
        modelBuilder.Entity<User>()
            .HasOne(u => u.Student)
            .WithOne(s => s.User)
            .HasForeignKey<Student>(s => s.User_ID);

        // User to Tutor (One-to-One)
        modelBuilder.Entity<User>()
            .HasOne(u => u.Tutor)
            .WithOne(t => t.User)
            .HasForeignKey<Tutor>(t => t.User_ID);

        // Tutor to Classes (One-to-Many)
        modelBuilder.Entity<Tutor>()
            .HasMany(t => t.Classes)
            .WithOne(c => c.Tutor)
            .HasForeignKey(c => c.Tutor_ID)
            .OnDelete(DeleteBehavior.Restrict);

        // Class to ClassSchedules (One-to-Many)
        modelBuilder.Entity<Class>()
            .HasMany(c => c.Schedules)
            .WithOne(s => s.Class)
            .HasForeignKey(s => s.Class_ID)
            .OnDelete(DeleteBehavior.Cascade);

        // ClassSchedule to ClassEntries (One-to-Many)
        modelBuilder.Entity<ClassSchedule>()
            .HasMany(s => s.ClassEntries)
            .WithOne(e => e.ClassSchedule)
            .HasForeignKey(e => e.ClassSchedule_ID)
            .OnDelete(DeleteBehavior.Cascade);

        // Student to Classes (Many-to-Many) - ClassList junction table
        modelBuilder.Entity<Student>()
            .HasMany(s => s.EnrolledClasses)
            .WithMany(c => c.EnrolledStudents)
            .UsingEntity<ClassList>(
                j => j.HasOne(cl => cl.Class)
                    .WithMany()
                    .HasForeignKey(cl => cl.Class_ID),
                j => j.HasOne(cl => cl.Student)
                    .WithMany()
                    .HasForeignKey(cl => cl.Student_ID)
            );

        // Student to ClassEntries (Many-to-Many) - StudentClassEntry junction table
        modelBuilder.Entity<Student>()
            .HasMany(s => s.ClassEntries)
            .WithMany(e => e.Students)
            .UsingEntity<StudentClassEntry>(
                j => j.HasOne(sce => sce.ClassEntry)
                    .WithMany()
                    .HasForeignKey(sce => sce.ClassEntry_ID),
                j => j.HasOne(sce => sce.Student)
                    .WithMany()
                    .HasForeignKey(sce => sce.Student_ID)
            );

        // Using static dates for seeding
        var startDate = new DateTime(2024, 1, 1);
        var endDate = new DateTime(2024, 4, 1);

        // Seed Data
        modelBuilder.Entity<User>().HasData(
            new User { User_ID = 1, User_email = "admin", User_password = "admin", User_type = "Admin" },
            new User { User_ID = 2, User_email = "john.tutor@school.com", User_password = "tutor123", User_type = "Tutor" },
            new User { User_ID = 3, User_email = "jane.tutor@school.com", User_password = "tutor123", User_type = "Tutor" },
            new User { User_ID = 4, User_email = "alice.student@school.com", User_password = "student123", User_type = "Student" },
            new User { User_ID = 5, User_email = "bob.student@school.com", User_password = "student123", User_type = "Student" }
        );

        modelBuilder.Entity<Tutor>().HasData(
            new Tutor { Tutor_ID = 1, Tutor_firstName = "John", Tutor_LastName = "Smith", User_ID = 2 },
            new Tutor { Tutor_ID = 2, Tutor_firstName = "Jane", Tutor_LastName = "Doe", User_ID = 3 }
        );

        modelBuilder.Entity<Student>().HasData(
            new Student { Student_ID = 1, Student_firstName = "Alice", Student_LastName = "Johnson", User_ID = 4 },
            new Student { Student_ID = 2, Student_firstName = "Bob", Student_LastName = "Williams", User_ID = 5 }
        );

        modelBuilder.Entity<Class>().HasData(
            new Class 
            { 
                Class_ID = 1,
                Class_Name = "Mathematics 101",
                Class_Desc = "Introduction to Basic Mathematics",
                StartDate = startDate,
                EndDate = endDate,
                Room = "Room 101",
                Tutor_ID = 1
            },
            new Class 
            { 
                Class_ID = 2,
                Class_Name = "Physics 101",
                Class_Desc = "Introduction to Physics",
                StartDate = startDate,
                EndDate = endDate,
                Room = "Room 102",
                Tutor_ID = 2
            },
            new Class 
            { 
                Class_ID = 3,
                Class_Name = "Chemistry 101",
                Class_Desc = "Introduction to Chemistry",
                StartDate = startDate,
                EndDate = endDate,
                Room = "Room 103",
                Tutor_ID = 1
            },
            new Class 
            { 
                Class_ID = 4,
                Class_Name = "Biology 101",
                Class_Desc = "Introduction to Biology",
                StartDate = startDate,
                EndDate = endDate,
                Room = "Room 104",
                Tutor_ID = 2
            },
            new Class 
            { 
                Class_ID = 5,
                Class_Name = "Computer Science 101",
                Class_Desc = "Introduction to Programming",
                StartDate = startDate,
                EndDate = endDate,
                Room = "Room 105",
                Tutor_ID = 1
            }
        );

        // Create schedules for each class (2 schedules per class)
        var schedules = new List<ClassSchedule>();
        var scheduleId = 1;
        for (int classId = 1; classId <= 5; classId++)
        {
            // First schedule for each class
            schedules.Add(new ClassSchedule 
            { 
                Schedule_ID = scheduleId++,
                DayOfWeek = DayOfWeek.Monday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 30, 0),
                Class_ID = classId
            });
            
            // Second schedule for each class
            schedules.Add(new ClassSchedule 
            { 
                Schedule_ID = scheduleId++,
                DayOfWeek = DayOfWeek.Wednesday,
                StartTime = new TimeSpan(9, 0, 0),
                EndTime = new TimeSpan(10, 30, 0),
                Class_ID = classId
            });
        }
        modelBuilder.Entity<ClassSchedule>().HasData(schedules);

        // Create class entries for each schedule
        var entries = new List<ClassEntry>();
        var entryId = 1;
        foreach (var schedule in schedules)
        {
            var currentDate = startDate;
            while (currentDate <= endDate)
            {
                if (currentDate.DayOfWeek == schedule.DayOfWeek)
                {
                    entries.Add(new ClassEntry 
                    { 
                        ClassEntry_ID = entryId++,
                        Date = currentDate,
                        ClassSchedule_ID = schedule.Schedule_ID
                    });
                }
                currentDate = currentDate.AddDays(1);
            }
        }
        modelBuilder.Entity<ClassEntry>().HasData(entries);

        // Seed junction table data - Enroll students in classes
        modelBuilder.Entity<ClassList>().HasData(
            // Alice's enrollments
            new ClassList { Student_ID = 1, Class_ID = 1 }, // Math
            new ClassList { Student_ID = 1, Class_ID = 2 }, // Physics
            new ClassList { Student_ID = 1, Class_ID = 3 }, // Chemistry
            new ClassList { Student_ID = 1, Class_ID = 5 }, // Computer Science
            
            // Bob's enrollments
            new ClassList { Student_ID = 2, Class_ID = 1 }, // Math
            new ClassList { Student_ID = 2, Class_ID = 3 }, // Chemistry
            new ClassList { Student_ID = 2, Class_ID = 4 }, // Biology
            new ClassList { Student_ID = 2, Class_ID = 5 }  // Computer Science
        );

        // Seed StudentClassEntry data - Record student attendance
        var studentEntries = new List<StudentClassEntry>();
        foreach (var entry in entries)
        {
            // Get the class ID for this entry
            var schedule = schedules.First(s => s.Schedule_ID == entry.ClassSchedule_ID);
            var classId = schedule.Class_ID;

            // Add entries for students enrolled in this class
            var enrolledStudents = new[]
            {
                new { Student_ID = 1, Class_ID = 1 },
                new { Student_ID = 1, Class_ID = 2 },
                new { Student_ID = 1, Class_ID = 3 },
                new { Student_ID = 1, Class_ID = 5 },
                new { Student_ID = 2, Class_ID = 1 },
                new { Student_ID = 2, Class_ID = 3 },
                new { Student_ID = 2, Class_ID = 4 },
                new { Student_ID = 2, Class_ID = 5 }
            }.Where(cl => cl.Class_ID == classId)
             .Select(cl => cl.Student_ID);

            foreach (var studentId in enrolledStudents)
            {
                studentEntries.Add(new StudentClassEntry 
                { 
                    Student_ID = studentId,
                    ClassEntry_ID = entry.ClassEntry_ID
                });
            }
        }
        modelBuilder.Entity<StudentClassEntry>().HasData(studentEntries);
    }
}

public class ClassList
{
    public int Student_ID { get; set; }
    public int Class_ID { get; set; }
    public Student? Student { get; set; }
    public Class? Class { get; set; }
}

public class StudentClassEntry
{
    public int Student_ID { get; set; }
    public int ClassEntry_ID { get; set; }
    public Student? Student { get; set; }
    public ClassEntry? ClassEntry { get; set; }
}


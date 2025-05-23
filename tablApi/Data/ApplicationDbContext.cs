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
    public DbSet<Course> Courses { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<ClassSchedule> ClassSchedules { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<User>().HasKey(e => e.User_ID);
        modelBuilder.Entity<Tutor>().HasKey(e => e.Tutor_ID);
        modelBuilder.Entity<Student>().HasKey(e => e.Student_ID);
        modelBuilder.Entity<Course>().HasKey(e => e.Course_ID);
        modelBuilder.Entity<Class>().HasKey(e => e.Class_ID);
        modelBuilder.Entity<ClassSchedule>().HasKey(e => e.Schedule_ID);

        modelBuilder.Entity<User>()
            .HasOne(u => u.Tutor)
            .WithOne(t => t.User)
            .HasForeignKey<Tutor>(d => d.User_ID);

        modelBuilder.Entity<User>()
            .HasOne(u => u.Student)
            .WithOne(s => s.User)
            .HasForeignKey<Student>(s => s.User_ID);

        modelBuilder.Entity<Class>()
            .HasOne(u => u.Tutor)
            .WithMany(s => s.ClassList)
            .HasForeignKey(i => i.Tutor_ID);

        modelBuilder.Entity<ClassSchedule>()
            .HasOne(u => u.Student)
            .WithMany(s => s.ClassSchedulesList)
            .HasForeignKey(i => i.Student_ID);

        modelBuilder.Entity<ClassSchedule>()
            .HasOne(u => u.Class)
            .WithMany(s => s.ClassSchedulesList)
            .HasForeignKey(u => u.Class_ID);

        // Dummy Data
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

        modelBuilder.Entity<Course>().HasData(
            new Course { Course_ID = 1, Course_Name = "Mathematics", Course_Desc = "Advanced mathematics course" },
            new Course { Course_ID = 2, Course_Name = "Physics", Course_Desc = "Introduction to physics" },
            new Course { Course_ID = 3, Course_Name = "Computer Science", Course_Desc = "Programming fundamentals" },
            new Course { Course_ID = 4, Course_Name = "English", Course_Desc = "English literature and composition" },
            new Course { Course_ID = 5, Course_Name = "History", Course_Desc = "World history overview" }
        );

        modelBuilder.Entity<Class>().HasData(
            new Class { Class_ID = 1, Class_name = "Math 101", Class_desc = "Basic Mathematics", Class_yearLevel = 1, Course_ID = 1, Tutor_ID = 1 },
            new Class { Class_ID = 2, Class_name = "Physics 101", Class_desc = "Introduction to Physics", Class_yearLevel = 1, Course_ID = 2, Tutor_ID = 1 },
            new Class { Class_ID = 3, Class_name = "Programming 101", Class_desc = "Introduction to Programming", Class_yearLevel = 1, Course_ID = 3, Tutor_ID = 2 },
            new Class { Class_ID = 4, Class_name = "English 101", Class_desc = "Basic English", Class_yearLevel = 1, Course_ID = 4, Tutor_ID = 2 },
            new Class { Class_ID = 5, Class_name = "History 101", Class_desc = "World History", Class_yearLevel = 1, Course_ID = 5, Tutor_ID = 1 }
        );

        modelBuilder.Entity<ClassSchedule>().HasData(
            // Week 1 (May 19-23, 2025)
            new ClassSchedule { Schedule_ID = 1, Class_ID = 1, Student_ID = 1, Date = new DateTime(2025, 5, 19), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 2, Class_ID = 1, Student_ID = 2, Date = new DateTime(2025, 5, 19), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 3, Class_ID = 2, Student_ID = 1, Date = new DateTime(2025, 5, 19), Time = new TimeSpan(13, 0, 0) },
            new ClassSchedule { Schedule_ID = 4, Class_ID = 3, Student_ID = 3, Date = new DateTime(2025, 5, 20), Time = new TimeSpan(10, 0, 0) },
            new ClassSchedule { Schedule_ID = 5, Class_ID = 4, Student_ID = 2, Date = new DateTime(2025, 5, 20), Time = new TimeSpan(14, 0, 0) },
            new ClassSchedule { Schedule_ID = 6, Class_ID = 5, Student_ID = 3, Date = new DateTime(2025, 5, 21), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 7, Class_ID = 1, Student_ID = 3, Date = new DateTime(2025, 5, 21), Time = new TimeSpan(13, 0, 0) },
            new ClassSchedule { Schedule_ID = 8, Class_ID = 2, Student_ID = 2, Date = new DateTime(2025, 5, 22), Time = new TimeSpan(10, 0, 0) },
            new ClassSchedule { Schedule_ID = 9, Class_ID = 3, Student_ID = 1, Date = new DateTime(2025, 5, 22), Time = new TimeSpan(14, 0, 0) },
            new ClassSchedule { Schedule_ID = 10, Class_ID = 4, Student_ID = 3, Date = new DateTime(2025, 5, 23), Time = new TimeSpan(9, 0, 0) },

            // Week 2 (May 26-30, 2025)
            new ClassSchedule { Schedule_ID = 11, Class_ID = 5, Student_ID = 1, Date = new DateTime(2025, 5, 26), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 12, Class_ID = 1, Student_ID = 2, Date = new DateTime(2025, 5, 26), Time = new TimeSpan(13, 0, 0) },
            new ClassSchedule { Schedule_ID = 13, Class_ID = 2, Student_ID = 3, Date = new DateTime(2025, 5, 27), Time = new TimeSpan(10, 0, 0) },
            new ClassSchedule { Schedule_ID = 14, Class_ID = 3, Student_ID = 1, Date = new DateTime(2025, 5, 27), Time = new TimeSpan(14, 0, 0) },
            new ClassSchedule { Schedule_ID = 15, Class_ID = 4, Student_ID = 2, Date = new DateTime(2025, 5, 28), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 16, Class_ID = 5, Student_ID = 3, Date = new DateTime(2025, 5, 28), Time = new TimeSpan(13, 0, 0) },
            new ClassSchedule { Schedule_ID = 17, Class_ID = 1, Student_ID = 1, Date = new DateTime(2025, 5, 29), Time = new TimeSpan(10, 0, 0) },
            new ClassSchedule { Schedule_ID = 18, Class_ID = 2, Student_ID = 2, Date = new DateTime(2025, 5, 29), Time = new TimeSpan(14, 0, 0) },
            new ClassSchedule { Schedule_ID = 19, Class_ID = 3, Student_ID = 3, Date = new DateTime(2025, 5, 30), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 20, Class_ID = 4, Student_ID = 1, Date = new DateTime(2025, 5, 30), Time = new TimeSpan(13, 0, 0) },

            // Week 3 (June 2-6, 2025)
            new ClassSchedule { Schedule_ID = 21, Class_ID = 5, Student_ID = 2, Date = new DateTime(2025, 6, 2), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 22, Class_ID = 1, Student_ID = 3, Date = new DateTime(2025, 6, 2), Time = new TimeSpan(13, 0, 0) },
            new ClassSchedule { Schedule_ID = 23, Class_ID = 2, Student_ID = 1, Date = new DateTime(2025, 6, 3), Time = new TimeSpan(10, 0, 0) },
            new ClassSchedule { Schedule_ID = 24, Class_ID = 3, Student_ID = 2, Date = new DateTime(2025, 6, 3), Time = new TimeSpan(14, 0, 0) },
            new ClassSchedule { Schedule_ID = 25, Class_ID = 4, Student_ID = 3, Date = new DateTime(2025, 6, 4), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 26, Class_ID = 5, Student_ID = 1, Date = new DateTime(2025, 6, 4), Time = new TimeSpan(13, 0, 0) },
            new ClassSchedule { Schedule_ID = 27, Class_ID = 1, Student_ID = 2, Date = new DateTime(2025, 6, 5), Time = new TimeSpan(10, 0, 0) },
            new ClassSchedule { Schedule_ID = 28, Class_ID = 2, Student_ID = 3, Date = new DateTime(2025, 6, 5), Time = new TimeSpan(14, 0, 0) },
            new ClassSchedule { Schedule_ID = 29, Class_ID = 3, Student_ID = 1, Date = new DateTime(2025, 6, 6), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 30, Class_ID = 4, Student_ID = 2, Date = new DateTime(2025, 6, 6), Time = new TimeSpan(13, 0, 0) },

            // Week 4 (June 9-13, 2025)
            new ClassSchedule { Schedule_ID = 31, Class_ID = 5, Student_ID = 3, Date = new DateTime(2025, 6, 9), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 32, Class_ID = 1, Student_ID = 1, Date = new DateTime(2025, 6, 9), Time = new TimeSpan(13, 0, 0) },
            new ClassSchedule { Schedule_ID = 33, Class_ID = 2, Student_ID = 2, Date = new DateTime(2025, 6, 10), Time = new TimeSpan(10, 0, 0) },
            new ClassSchedule { Schedule_ID = 34, Class_ID = 3, Student_ID = 3, Date = new DateTime(2025, 6, 10), Time = new TimeSpan(14, 0, 0) },
            new ClassSchedule { Schedule_ID = 35, Class_ID = 4, Student_ID = 1, Date = new DateTime(2025, 6, 11), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 36, Class_ID = 5, Student_ID = 2, Date = new DateTime(2025, 6, 11), Time = new TimeSpan(13, 0, 0) },
            new ClassSchedule { Schedule_ID = 37, Class_ID = 1, Student_ID = 3, Date = new DateTime(2025, 6, 12), Time = new TimeSpan(10, 0, 0) },
            new ClassSchedule { Schedule_ID = 38, Class_ID = 2, Student_ID = 1, Date = new DateTime(2025, 6, 12), Time = new TimeSpan(14, 0, 0) },
            new ClassSchedule { Schedule_ID = 39, Class_ID = 3, Student_ID = 2, Date = new DateTime(2025, 6, 13), Time = new TimeSpan(9, 0, 0) },
            new ClassSchedule { Schedule_ID = 40, Class_ID = 4, Student_ID = 3, Date = new DateTime(2025, 6, 13), Time = new TimeSpan(13, 0, 0) }
        );

        
    }
}


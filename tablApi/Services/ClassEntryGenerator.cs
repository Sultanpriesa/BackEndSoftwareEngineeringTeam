using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tablApi.Data;
using tablApi.Model;

namespace tablApi.Services;

public class ClassEntryGenerator
{
    private readonly ApplicationDbContext _context;

    public ClassEntryGenerator(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<ClassEntry>> GenerateClassEntries()
    {
        var entries = new List<ClassEntry>();
        var classes = await _context.Classes
            .Include(c => c.Schedules)
            .Include(c => c.EnrolledStudents)
            .ToListAsync();

        foreach (var classItem in classes)
        {
            if (classItem.Schedules == null || !classItem.Schedules.Any())
                continue;

            var currentDate = classItem.StartDate;
            while (currentDate <= classItem.EndDate)
            {
                foreach (var schedule in classItem.Schedules)
                {
                    if (currentDate.DayOfWeek == schedule.DayOfWeek)
                    {
                        var entry = new ClassEntry
                        {
                            Class_ID = classItem.Class_ID,
                            ClassSchedule_ID = schedule.Schedule_ID,
                            Date = currentDate,
                            IsDeleted = false
                        };

                        entries.Add(entry);
                    }
                }
                currentDate = currentDate.AddDays(1);
            }
        }

        await _context.ClassEntries.AddRangeAsync(entries);
        await _context.SaveChangesAsync();
        return entries;
    }

    public async Task<List<ClassEntry>> GetStudentClassEntries(int studentId)
    {
        var student = await _context.Students
            .Include(s => s.EnrolledClasses)
            .FirstOrDefaultAsync(s => s.Student_ID == studentId);

        if (student == null)
            return new List<ClassEntry>();

        var classIds = student.EnrolledClasses?.Select(c => c.Class_ID).ToList() ?? new List<int>();
        
        var entries = await _context.ClassEntries
            .Include(ce => ce.Class)
            .Include(ce => ce.ClassSchedule)
            .Include(ce => ce.Students)
            .Where(ce => classIds.Contains(ce.Class_ID) && !ce.IsDeleted)
            .ToListAsync();

        return entries;
    }

    public async Task<List<ClassEntry>> GetAllClassEntries(bool includeDeleted = false)
    {
        var query = _context.ClassEntries.AsQueryable();

        if (!includeDeleted)
        {
            query = query.Where(ce => !ce.IsDeleted);
        }

        return await query
            .Include(ce => ce.Class)
            .Include(ce => ce.ClassSchedule)
            .Include(ce => ce.Students)
            .ToListAsync();
    }

    public async Task ToggleClassEntryDeleted(int classEntryId)
    {
        var entry = await _context.ClassEntries.FindAsync(classEntryId);
        if (entry != null)
        {
            entry.IsDeleted = !entry.IsDeleted;
            await _context.SaveChangesAsync();
        }
    }
} 
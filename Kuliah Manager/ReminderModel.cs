/*using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Kuliah_Manager
{
    public partial class ReminderModel : DbContext
    {
        public ReminderModel()
            : base("name=ReminderModel")
        {
        }

        public virtual DbSet<ClassTbl> ClassTbls { get; set; }
        public virtual DbSet<TaskTbl> TaskTbls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassTbl>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTbl>()
                .Property(e => e.MeetingLink)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTbl>()
                .Property(e => e.AttendanceLink)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTbl>()
                .Property(e => e.DriveLink)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTbl>()
                .Property(e => e.Day)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTbl>()
                .Property(e => e.Hour)
                .IsUnicode(false);

            modelBuilder.Entity<ClassTbl>()
                .Property(e => e.Min)
                .IsUnicode(false);

            modelBuilder.Entity<TaskTbl>()
                .Property(e => e.DueHour)
                .IsUnicode(false);

            modelBuilder.Entity<TaskTbl>()
                .Property(e => e.DueMin)
                .IsUnicode(false);

            modelBuilder.Entity<TaskTbl>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<TaskTbl>()
                .Property(e => e.Desc)
                .IsUnicode(false);
        }
    }
}
*/
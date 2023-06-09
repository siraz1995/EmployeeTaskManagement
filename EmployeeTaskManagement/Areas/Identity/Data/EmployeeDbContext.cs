
using EmployeeTaskManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeTaskManagement.Data;

public class EmployeeDbContext : IdentityDbContext<IdentityUser>
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        //builder.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(127));
        //builder.Entity<IdentityRole>(entity => entity.Property(m => m.ConcurrencyStamp).HasColumnType("varchar(256)"));
        ////builder.Entity<AppUser>()
        ////    .HasOne<Designation>(s => s.Designation)
        ////    .WithMany(g => g.AppUsers)
        ////    .HasForeignKey(s => s.DesignationId).OnDelete(DeleteBehavior.NoAction);

        ////builder.Entity<AppUser>()
        ////    .HasOne<Department>(s => s.Department)
        ////    .WithMany(g => g.AppUser)
        ////    .HasForeignKey(s => s.DepartmentId).OnDelete(DeleteBehavior.NoAction);
        //ModelBuilder modelBuilder = builder.Entity<IdentityUserLogin<string>>(entity =>
        //{
        //    entity.Property(m => m.LoginProvider).HasMaxLength(127);
        //    entity.Property(m => m.ProviderKey).HasMaxLength(127);
        //});

        //builder.Entity<IdentityUserRole<string>>(entity =>
        //{
        //    entity.Property(m => m.UserId).HasMaxLength(127);
        //    entity.Property(m => m.RoleId).HasMaxLength(127);
        //});

        //builder.Entity<IdentityUserToken<string>>(entity =>
        //{
        //    entity.Property(m => m.UserId).HasMaxLength(127);
        //    entity.Property(m => m.LoginProvider).HasMaxLength(127);
        //    entity.Property(m => m.Name).HasMaxLength(127);
        //});
    }
    public DbSet<MainMenu> MainMenus { get; set; }
    public DbSet<SubMenu> SubMenus { get; set; }
    public DbSet<RoleSubMenu> RoleSubMenus { get; set; }
    public DbSet<Department> Department { get; set; }
    public DbSet<Designation> Designation { get; set; }
    public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
    public DbSet<TaskAssign> TaskAssign { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<UserWiseRole> UserWiseRole { get; set;}
}

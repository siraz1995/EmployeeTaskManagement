using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EmployeeTaskManagement.Data;
//using EmployeeTaskManagement.Areas.Identity.Data;
using EmployeeTaskManagement.Interface.Manager;
using EmployeeTaskManagement.Manager;
using EmployeeTaskManagement.Models;

namespace EmployeeTaskManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("EmployeeDbContextConnection");
            builder.Services.AddDbContext<EmployeeDbContext>(x => x.UseSqlServer(connectionString));

            builder.Services.AddDbContext<EmployeeDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<EmployeeDbContext>();
            builder.Services.AddIdentity<EmployeeInfo, IdentityRole>()
    .AddEntityFrameworkStores<EmployeeDbContext>()
    .AddDefaultTokenProviders();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IDepartmentManager, DepartmentManager>();
            builder.Services.AddScoped<IDesignationManager,DesignationManager>();
            builder.Services.AddScoped<IEmployeeInfoManager, EmployeeInfoManager>();
            builder.Services.AddScoped<ITaskAssignManager, TaskAssignManager>();
            builder.Services.AddScoped<RoleManager<IdentityRole>>();

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
                        app.UseAuthentication();;

            app.UseAuthorization();
            app.MapRazorPages();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
          
            app.Run();
           
        }
    }
}
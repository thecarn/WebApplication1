using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication.DataAccess.Data;
using Microsoft.AspNetCore.Builder;
using WebApplication.DataAccess.Repository.IRepository;
using WebApplication.DataAccess.Repository;
/*
 
transient is good if you need something new or timestamped



sometimes you want to limit the number of connections to a service,
    - need a rabbitmq instance, but only 1 connection at a time therefore use a singleton

    orms
 npoco
 dapper

factory pattern


mvc isnt completely like react
    - view data
    - view bag
    - temp data

null checking
    gaurd clauses

    null coelessing ?? and ??=
        -check for null and assign at the same time

FromQuery, FromBody, newtonsoftjson

HTTP methods

overloading, different ways to call same function
    jsonpropertyname("name")

dont want to use frombody in a get request

can change request body values in immediate window in IDE
    can drag arrow to reverse time in the same context of the current block


NULL HANDELING IS IMPORTANT FOR THESE TWO 
CREATED DATE
UPDATED DATE


internal vs private

partial classes, can create a class in two places
    -
 
fields vs properties

 should seperate request models from entity models 

stripe 


how to use the route, or how to get info from the body to breakpoint into it to access the data that was provdided and display it

how to do this joson stuff with it, serialization/deserialization and making sure it shows on the page

how to get a request object into code

parameterless constructor

 */

var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("WebApplication.DataAccess")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

//if we dont load our repo service into the DI container, then we will be presented with an exception
//invalidoperationexception, unable to resolve service for type webapplication.dataccess.repoisitory.irepository.icategoryrepository
//while attempting to activate webapplication.cointrollers.categorycontreoller
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


var app = builder.Build();

//MIDDLEWARE TIME
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();




/*
 public class Course
{
    public int CourseID { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }
    public int DepartmentID { get; set; }
    public virtual Department Department { get; set; }
}

public class Department
{
    public Department()
    {
        this.Courses = new HashSet<Course>();
    }
    public int DepartmentID { get; set; }
    public string Name { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public int? Administrator { get; set; }
    public virtual ICollection<Course> Courses { get; set; }
}
 */

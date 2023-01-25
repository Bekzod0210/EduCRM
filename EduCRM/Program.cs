using EduCRM.Data;
using EduCRM.Interfaces;
using EduCRM.Models;
using EduCRM.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => 
                options.UseNpgsql(builder.Configuration.GetConnectionString("Postgres")));

builder.Services.AddScoped<IMentorRepository, MentorRepasitory>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region
//var student1 = new Student()
//{
//    Id = 1,
//    Name = "Ali",
//    GroupId = 1,
//};
//List<Student> students = new List<Student>()
//{
//    student1,
//    new Student(){Id = 2, Name = "Vali", GroupId = 1},
//    new Student(){Id = 3, Name = "Azizbek", GroupId = 1},
//    new Student(){Id = 4, Name = "Bob", GroupId = 1},
//    new Student(){Id = 5, Name = "John", GroupId = 1},
//    new Student(){Id = 6, Name = "Tom", GroupId = 1},
//    new Student(){Id = 7, Name = "Alice", GroupId = 1},
//    new Student(){Id = 8, Name = "Jack", GroupId = 1}
//};
//Group group = new Group()
//{
//    Id = 1,
//    Name = "dotNet",
//    RegisterId = 1,
//};
//Register register = new Register()
//{
//    Id = 1,
//    Email = "aaa111",
//    Password = "1234",
//    Name = "Alibek",
//};

//AppDbContext appDbContext = new AppDbContext();
//appDbContext.Registers.Add(register);
//appDbContext.Groups.Add(group);
//appDbContext.Students.AddRange(students);
//appDbContext.SaveChanges();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


using Microsoft.EntityFrameworkCore;
using RecruitCatChaudhnt.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<RecruitCatChaudhntContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RecruitCatChaudhntContext")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

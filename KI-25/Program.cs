var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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
//     pattern: "{controller=Home}/{action=Index}/{num1?}/{num2?}/{operation?}");
    pattern: "{controller=Calc}/{action=Index}/{a?}/{b?}/{c?}/");
//     pattern: "{controller=Products}/{action=GetInfo}/{id?}");
//     pattern: "{controller=Start}/{action=Index}/{num1?}/{num2?}");
app.Run();

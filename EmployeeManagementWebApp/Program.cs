var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();
//comment
var app = builder.Build();

// Configure the HTTP request pipeline.
//comment

    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

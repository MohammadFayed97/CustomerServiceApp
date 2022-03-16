using AppSquare.Shared.AssemplyScanning;
using AppSquare.Shared.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Use Assembly scanning for register services automaticly
builder.Services.AddInstallerFromReferancedAssemblies(builder.Configuration, typeof(Program).Assembly, "*.Server.dll");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSwagger();
app.UseSwaggerUI();

app.ConfigureExceptionHandler();
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseCors("_myAllowSpecificOrigins");
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

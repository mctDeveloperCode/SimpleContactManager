using SimpleContactManager.Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.UseDefaultFiles();

app.UseStaticFiles();

app.MapGet("api/things", ScmApi.GetThings);

app.Run();

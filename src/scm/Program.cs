using Microsoft.AspNetCore.Mvc;
using SimpleContactManager.Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("api/things", ScmApi.GetThings);

app.MapPost(
    "api/things",
    (HttpRequest httpRequest) =>
    {
        ScmApi.CreateThing(
            new ScmApi.Thing()
            {
                Left = httpRequest.Form["Left"].ToString(),
                Right = httpRequest.Form["Right"].ToString()
            });
        return Results.Redirect("/");
    });

app.MapDelete(
    "api/things",
    ([FromBody] ScmApi.Thing thing) =>
        ScmApi.DeleteThing(thing));

app.Run();

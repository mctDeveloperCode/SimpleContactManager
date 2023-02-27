var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.UseDefaultFiles();

app.UseStaticFiles(
    new StaticFileOptions
    {
        DefaultContentType = "text/html; charset=utf-8"
    });

app.MapGet(
    "api/stuff",
    () => """[{"left":"top and left","right":"top and right"},{"left":"bottom left yo","right":"last one out!!"},{"left":"wait, waht now?","right":"THERE ARE THREE OF THEM?!?!"}]""");

app.Run();

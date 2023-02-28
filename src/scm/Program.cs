var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.UseDefaultFiles();

app.UseStaticFiles();

app.MapGet(
    "api/things",
    () => """[{"left":"top and left","right":"top and right"},{"left":"bottom left yo","right":"last one out!!"},{"left":"wait, waht now?","right":"THERE ARE THREE OF THEM?!?!"}]""");

app.Run();

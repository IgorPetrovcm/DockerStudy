var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async(context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";

    string html = "<h1>test1</h1>";

    await context.Response.WriteAsync(html);
});

app.Run();

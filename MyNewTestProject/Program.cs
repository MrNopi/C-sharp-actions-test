var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

String[] arr = new String[];

arr[0] = "Hello";
arr[1] = "World";
arr[2] = "!!";

app.MapGet("/", () => "Hello World!!");
app.MapGet("/hello" => "Hello World!");
app.MapGet("/hi" => arr);

app.Run();

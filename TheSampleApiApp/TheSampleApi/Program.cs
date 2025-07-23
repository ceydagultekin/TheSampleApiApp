using Scalar.AspNetCore;
using TheSampleApi.Endpoints;
using TheSampleApi.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.AddDependencies();

var app = builder.Build();

app.UseOpenApi();

app.UseHttpsRedirection();

app.MappAllHealthChecks();

app.ApplyCorsConfig();
app.AddRootEndpoints();
app.AddCourseEndpoints();
app.AddErrorEndpoints();

app.Run();

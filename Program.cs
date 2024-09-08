using AspNetExercise1;
using AspNetExercise1.HostingExtension;
using AspNetExercise1.Infrastructure.Persistence.Extensions;
using AspNetExercise1.Middlewares.Extensions;
using AspNetExercise1.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

var app = builder
    .ConfigureServices()
    .ConfigurePipeline();

app.Run();

using GraphQL.API;
using GraphQL.API.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddAuthorization();

builder.Services
    .AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

builder.Services
    .AddSingleton<BookRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapGraphQL();

app.Run();
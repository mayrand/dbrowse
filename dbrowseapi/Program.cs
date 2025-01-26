using System.Data;
using System.Data.SqlClient;
using Dapper;
using dbrowseModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/InformationSchema", async () =>
    {
        using IDbConnection connection =
            new SqlConnection("Server=localhost;User=sa;Password=Passw0rd;Database=AdventureWorks;");

        var info =
            await connection.QueryAsync<InformationSchema>("SELECT TABLE_CATALOG AS CATALOG, TABLE_SCHEMA AS 'SCHEMA', TABLE_NAME AS NAME, TABLE_TYPE AS TYPE FROM INFORMATION_SCHEMA.TABLES order by TABLE_TYPE,TABLE_SCHEMA");
        return info;
    })
    .WithName("GetInformationSchema")
    .WithOpenApi();

app.Run();
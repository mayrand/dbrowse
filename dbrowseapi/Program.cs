using System.Data;
using System.Data.SqlClient;
using Dapper;
using dbrowseModels;
using Microsoft.AspNetCore.Mvc;

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
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
using IDbConnection connection =
    new SqlConnection(connectionString);

app.MapGet("/InformationSchemaTables", async () =>
    {
        var info =
            await connection.QueryAsync<InformationSchema>(
                "SELECT TABLE_CATALOG AS CATALOG, TABLE_SCHEMA AS 'SCHEMA', TABLE_NAME AS NAME, TABLE_TYPE AS TYPE FROM INFORMATION_SCHEMA.TABLES order by TABLE_TYPE,TABLE_SCHEMA");
        return info;
    })
    .WithName("GetInformationSchema")
    .WithOpenApi();

app.MapGet("/InformationSchemaColumns/{tableName}", async ([FromRoute] string tableName) =>
    {
        var info =
            await connection.QueryAsync<string>(
                @"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tableName", new { tableName });
        return info;
    })
    .WithName("GetInformationSchemaColumns")
    .WithOpenApi();

app.Run();
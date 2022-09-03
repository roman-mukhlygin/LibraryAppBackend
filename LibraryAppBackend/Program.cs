using LibraryAppBackend.Infrastructure.Data;
using LibraryAppBackend.Infrastructure.Data.AuthorModel;
using LibraryAppBackend.Infrastructure.Data.BookModel;
using LibraryAppBackend.Infrastructure.Data.GenreModel;
using LibraryAppBackend.Infrastructure.UoW;
using LibraryAppBackend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder( args );

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<LibraryContext>( c =>
{
    try
    {
        string connectionString = builder.Configuration.GetValue<string>( "DefaultConnection" );
        c.UseSqlServer( connectionString );
    }
    catch ( Exception ex )
    {
        var message = ex.Message;
    }
} );

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<IBookService, BookService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( app.Environment.IsDevelopment() )
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

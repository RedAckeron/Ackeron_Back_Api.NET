using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using DAL.Repositories;
using System.Data;
using System.Data.SqlClient;
var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IDbConnection>(service =>
{
    return new SqlConnection(builder.Configuration["default"]);
});

builder.Services.AddCors(options =>{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.AllowAnyHeader();
            policy.AllowAnyMethod();
            policy.WithOrigins("https://localhost:4200", "http://localhost:4200");
        });
});

builder.Services.AddScoped<IItemService,ItemService>();
builder.Services.AddScoped<IItemRepo, ItemRepo>();
builder.Services.AddScoped<IMapService, MapService>();
builder.Services.AddScoped<IMapRepo, MapRepo>();
builder.Services.AddScoped<IQuestService, QuestService>();
builder.Services.AddScoped<IQuestRepo, QuestRepo>();
builder.Services.AddScoped<ILocalisatorService, LocalisatorService>();
builder.Services.AddScoped<ILocalisatorRepo , LocalisatorRepo>();
builder.Services.AddScoped<IMobService, MobService>();
builder.Services.AddScoped<IMobrepo, MobRepo>();
builder.Services.AddScoped<IInfoRepo, InfoRepo>();
builder.Services.AddScoped<IStatRepo, StatRepo>();
builder.Services.AddScoped<IPowerRepo, PowerRepo>();
builder.Services.AddScoped<IResistRepo, ResistRepo>();
builder.Services.AddScoped<IInventoryService, InventoryService>();
builder.Services.AddScoped<IInventoryRepo, InventoryRepo>();
builder.Services.AddScoped<IHeroService, HeroService>();
builder.Services.AddScoped<ICharacterRepo, CharacterRepo>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors(MyAllowSpecificOrigins);
app.Run();

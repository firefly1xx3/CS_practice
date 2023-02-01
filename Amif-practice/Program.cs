using MySql.Data.MySqlClient;
using Amif_practice.Models;

//String cs = @"server=localhost;userid=root;password=hygxaa784;database=cs_prac";

//var builder = WebApplication.CreateBuilder(args);

//// connecting sql server.
//using var con = new MySqlConnection(cs);
//con.Open();

//using var cmd = new MySqlCommand();
//cmd.Connection = con;

//cmd.CommandText = "select * from users";

//using MySqlDataReader reader = cmd.ExecuteReader();
//while (reader.Read())
//{
//    Console.WriteLine("{0}, {1}, {2}",
//        reader["id"].ToString(),
//        reader["name"].ToString(),
//        reader["mail"].ToString()
//    );
//}

//Console.WriteLine($"MySQL version : {con.ServerVersion}");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HelloWorld}/{action=welcome}/{id?}");

string conString = app.Configuration.GetConnectionString("db");
database.DB = new MySqlConnection(conString);

app.Run();


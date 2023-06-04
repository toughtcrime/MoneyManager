using Infrastructure;

internal class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddInfrastructureServices(builder.Configuration);
        var app = builder.Build();
        
        if (app.Environment.IsDevelopment())
        {
           
        }
        else
        {
            app.UseHsts();
        }
        
        app.UseHttpsRedirection();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
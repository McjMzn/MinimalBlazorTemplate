namespace MinimalBlazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            var app = builder.Build();

            app.MapRazorPages();
            app.MapBlazorHub();

            app.Run();
        }
    }
}
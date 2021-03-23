using Serilog;
using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .WriteTo.File("log.txt",
                rollingInterval: RollingInterval.Hour,
                rollOnFileSizeLimit: true)
            .CreateLogger();

            Log.Information("-------Program was sccesfuly started-------");

            Admin admin = new();

            admin.db.CreateMotorcycle(new Motorcycle { Id = 888005553535, Model = "1.0", Name = "Buran", Year = 2008, Odometer = 123456 });
            admin.db.UpdateMotorcycle(888005553535);
            Motorcycle temp = admin.db.GetMotorcycle(888005553535);
            admin.db.DeleteMotorcycle(888005553535);

            Log.Information("-------Program was sccesfuly stoped-------");
        }
    }
}

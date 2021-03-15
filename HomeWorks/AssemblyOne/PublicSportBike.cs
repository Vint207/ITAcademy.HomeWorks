using System;
using static System.Console;

namespace AssemblyOne
{
    public class PublicSportBike : PublicMotorcycle
    {
        public static void Assembly()
        {
            PublicSportBike sBike = new PublicSportBike();

            //Приватные поля доступны только внутри класса  
            //WriteLine(PublicMotorcycle.MaxSpeedPrivate);
            //sBike.VinNumberPrivate = "2CC841-69BB3-A3C7-7DBCH234586";
            //sBike.OdometerPrivate = 20000;
            //sBike.StartEnginePrivate();

            WriteLine(PublicMotorcycle.MaxSpeedPublic);
            sBike.VinNumberPublic = "2CC841-69BB3-A3C7-7DBCH234586";
            sBike.OdometerPublic = 20000;
            sBike.StartEnginePublic();

            WriteLine(PublicMotorcycle.MaxSpeedProtected);
            sBike.VinNumberProtected = "2CC841-69BB3-A3C7-7DBCH234586";
            sBike.OdometerProtected = 20000;
            sBike.StartEngineProtected();

            WriteLine(PublicMotorcycle.MaxSpeedInternal);
            sBike.VinNumberInternal = "2CC841-69BB3-A3C7-7DBCH234586";
            sBike.OdometerInternal = 20000;
            sBike.StartEngineInternal();

            WriteLine(PublicMotorcycle.MaxSpeedProtectInternal);
            sBike.VinNumberProtectInternal = "2CC841-69BB3-A3C7-7DBCH234586";
            sBike.OdometerProtectInternal = 20000;
            sBike.StartEngineProtectInternal();

            WriteLine(PublicMotorcycle.MaxSpeedProtectPrivate);
            sBike.VinNumberProtectPrivate = "2CC841-69BB3-A3C7-7DBCH234586";
            sBike.OdometerProtectPrivate = 20000;
            sBike.StartEngineProtectPrivate();
        }
    }
}

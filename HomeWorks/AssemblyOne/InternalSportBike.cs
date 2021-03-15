using System;
using static System.Console;

namespace AssemblyOne
{
    class InternalSportBike : InternalMotorcycle
    {
        public static void Assembly()
        {
            InternalSportBike sBike = new InternalSportBike();

            //Приватные поля доступны только внутри класса  
            //WriteLine(InternalMotorcycle.MaxSpeedPrivate);
            //sBike.VinNumberPrivate = "2CC841-69BB3-A3C7-7DBCH234586";
            //sBike.OdometerPrivate = 20000;
            //sBike.StartEnginePrivate();

            WriteLine(InternalMotorcycle.MaxSpeedPublic);
            sBike.VinNumberPublic = "2CC841-69BB3-A3C7-7DBCH234586";
            sBike.OdometerPublic = 20000;
            sBike.StartEnginePublic();

            WriteLine(InternalMotorcycle.MaxSpeedProtected);
            sBike.VinNumberProtected = "2CC841-69BB3-A3C7-7DBCH234586";
            sBike.OdometerProtected = 20000;
            sBike.StartEngineProtected();

            WriteLine(InternalMotorcycle.MaxSpeedInternal);
            sBike.VinNumberInternal = "2CC841-69BB3-A3C7-7DBCH234586";
            sBike.OdometerInternal = 20000;
            sBike.StartEngineInternal();

            WriteLine(InternalMotorcycle.MaxSpeedProtectInternal);
            sBike.VinNumberProtectInternal = "2CC841-69BB3-A3C7-7DBCH234586";
            sBike.OdometerProtectInternal = 20000;
            sBike.StartEngineProtectInternal();

            WriteLine(InternalMotorcycle.MaxSpeedProtectPrivate);
            sBike.VinNumberProtectPrivate = "2CC841-69BB3-A3C7-7DBCH234586";
            sBike.OdometerProtectPrivate = 20000;
            sBike.StartEngineProtectPrivate();
        }
    }
}

using System;
using AssemblyOne;
using static System.Console;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyOne.PublicMotorcycle mCycle = new AssemblyOne.PublicMotorcycle();

            //Private call from another PUBLIC class in ANOTHER assembly
            //It's inaccessible due to its protection level (only accessible from code in the same class or context)

            //WriteLine(InternalMotorcycle.MaxSpeedPrivate);
            //mCycle.VinNumberPrivate = "VinNumberPrivate";
            //mCycle.OdometerPrivate = 20000;
            //mCycle.StartEnginePrivate();

            WriteLine(AssemblyOne.PublicMotorcycle.MaxSpeedPublic);
            mCycle.VinNumberPublic = "VinNumberPublic";
            mCycle.OdometerPublic = 20000;
            mCycle.StartEnginePublic();

            //Protected call from another PUBLIC class in ANOTHER assembly
            //It's inaccessible due to its protection level (cause the class is not inherited)           
            //WriteLine(InternalMotorcycle.MaxSpeedProtected);
            //mCycle.VinNumberProtected = "VinNumberProtected";
            //mCycle.OdometerProtected = 20000;
            //mCycle.StartEngineProtected();         

            //Internal call from another PUBLIC class in ANOTHER assembly
            //It's inaccessible due to its protection level (cause it's called from another assembly)      
            //WriteLine(InternalMotorcycle.MaxSpeedInternal);
            //mCycle.VinNumberInternal = "VinNumberInternal";
            //mCycle.OdometerInternal = 20000;
            //mCycle.StartEngineInternal();     

            //Protected-Internal call from another PUBLIC class in ANOTHER assembly
            //It's inaccessible due to its protection level (cause it's called from another assembly and doesn't inherited)       
            //WriteLine(InternalMotorcycle.MaxSpeedProtectInternal);
            //mCycle.VinNumberProtectInternal = "VinNumberProtectInternal";
            //mCycle.OdometerProtectInternal = 20000;
            //mCycle.StartEngineProtectInternal();       

            //Protected-Private call from another PUBLIC class in ANOTHER assembly
            //It's inaccessible due to its protection level (cause it's called from another assembly)         
            //WriteLine(InternalMotorcycle.MaxSpeedProtectPrivate);
            //mCycle.VinNumberProtectPrivate = "VinNumberProtectPrivate";
            //mCycle.OdometerProtectPrivate = 20000;
            //mCycle.StartEngineProtectPrivate();       

            //It's inaccessible due to its protection level
            //Because INTEGRAL class available only in the assembly in which it's defined        
            //InternalMotorcycleInternal mCyclei = new InternalMotorcycleInternal();       
        }
    }
}

using System;

namespace AssemblyOne
{
   public class PublicMotorcycle
    {
        //Internal
        internal const ushort MaxSpeedInternal = 300;
        internal string VinNumberInternal = "2CC841-69BB3-A3C7-7DBCH234586";
        internal int OdometerInternal = 20000;

        //Private
        const ushort MaxSpeedPrivate = 300;
        string VinNumberPrivate = "2CC841-69BB3-A3C7-7DBCH234586";
        int OdometerPrivate = 20000;

        //Public
        public const ushort MaxSpeedPublic = 300;
        public string VinNumberPublic = "2CC841-69BB3-A3C7-7DBCH234586";
        public int OdometerPublic = 20000;

        //Protected-Internal
        protected internal const ushort MaxSpeedProtectInternal = 300;
        protected internal string VinNumberProtectInternal = "2CC841-69BB3-A3C7-7DBCH234586";
        protected internal int OdometerProtectInternal = 20000;
      
        //Protected-Private
        protected private const ushort MaxSpeedProtectPrivate = 300;
        protected private string VinNumberProtectPrivate = "2CC841-69BB3-A3C7-7DBCH234586";
        protected private int OdometerProtectPrivate = 20000;
      
        //Protected
        protected const ushort MaxSpeedProtected = 300;
        protected string VinNumberProtected = "2CC841-69BB3-A3C7-7DBCH234586";
        protected int OdometerProtected = 20000;


        void StartEnginePrivate() { }

        internal void StartEngineInternal() { }

        public void StartEnginePublic() { }

        protected void StartEngineProtected() { }

        protected internal void StartEngineProtectInternal() { }

        protected private void StartEngineProtectPrivate() { }
    }
}

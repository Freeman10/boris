using System;

namespace boris
{
    public class Stanice
    {
        public Stanice(string název, DateTime příjezd, DateTime odjezd)
        {
            Název = název;
            PravidelnýPříjezd = příjezd;
            PravidelnýOdjezd = odjezd;
        }

        public string Název
        {
            get;
        }

        public DateTime PravidelnýPříjezd
        {
            get;
            set;
        }
        public DateTime PravidelnýOdjezd
        {
            get;
            set;
        }
        public JízdníŘád<Vlak> Spoje
        {
            get;
            set;
        }
    }
}


﻿using System;
using System.Collections.Generic;

namespace boris
{
    public class JízdníŘád<T>
    {
        public JízdníŘád()
        {
            Příjezd = new Dictionary<T, DateTime>();
            Odjezd = new Dictionary<T, DateTime>();
            StavíZde = new Dictionary<T, bool>();
        }

        public Dictionary<T, DateTime> Příjezd
        {
            get;
            set;
        }

        public Dictionary<T, DateTime> Odjezd
        {
            get;
            set;
        }

        public Dictionary<T, bool> StavíZde
        {
            get;
            set;
        }

        public void PřidejPrvek(T klíč, DateTime příjezd, DateTime odjezd, bool stavíZde)
        {
            if (příjezd <= odjezd)
            {
                Příjezd.Add(klíč, příjezd);
                Odjezd.Add(klíč, odjezd);
                StavíZde.Add(klíč, stavíZde);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void OdstraňPrvek(T klíč)
        {
            if (Příjezd.ContainsKey(klíč))
            {
                Příjezd.Remove(klíč);
                Odjezd.Remove(klíč);
                StavíZde.Remove(klíč);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}


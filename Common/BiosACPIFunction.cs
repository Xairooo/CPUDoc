﻿using System.Collections;

namespace CPUDoc
{
    public class BiosACPIFunction : IEnumerable
    {
        public string IDString;
        public uint ID;

        public BiosACPIFunction(string idString, uint id)
        {
            IDString = idString;
            ID = id;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)IDString).GetEnumerator();
        }
    }
}
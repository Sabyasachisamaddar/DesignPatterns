using System;
using System.Collections.Generic;

namespace PatternsGuide.BuilderPattern
{
    public class Menu
    {
        private Dictionary<string, string> _parts = new Dictionary<string, string>();
        internal void Add(string v)
        {
            _parts.Add(v, v);
        }

        public override string ToString()
        {
            return String.Join(", ", _parts.Values);
        }

    }
}
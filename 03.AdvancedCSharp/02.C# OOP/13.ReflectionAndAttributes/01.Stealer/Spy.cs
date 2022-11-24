using System;
using System.Collections.Generic;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string name, string[] fieldsNames)
        {
            Type type = Type.GetType(name);

            return $"Class under investigation: {type.Name}";
        }
    }
}

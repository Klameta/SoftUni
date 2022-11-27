using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string name, string[] fieldsNames)
        {
            Type type = Type.GetType(name);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Class under investigation: {type.Name}");

            object instance = Activator.CreateInstance(type, new object[] { });

            var classFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);

            foreach (var classField in classFields.Where(f => fieldsNames.Contains(f.Name)))
            {
                stringBuilder.AppendLine($"{classField.Name} = {classField.GetValue(instance)}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}

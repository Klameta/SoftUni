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

        public void AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            var publicMembers = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            var privateMembers = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var field in fields)
            {
                Console.WriteLine($"{field.Name} must be private!");
            }

            foreach (var setter in privateMembers.Where(f => f.Name.StartsWith("get")))
            {
                Console.WriteLine($"{setter.Name} have to be public");
            }

            foreach (var getter in publicMembers.Where(f => f.Name.StartsWith("set")))
            {
                Console.WriteLine($"{getter.Name} have to be public");
            }

        }

        public string RevealPrivateMethods(string className)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Type classType = Type.GetType(className);

            var privateMembers = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            stringBuilder.AppendLine($"All Private Methods of Class: {className}");
            stringBuilder.AppendLine($"Base Class: {classType.BaseType.Name}");
            stringBuilder.AppendLine(String.Join(Environment.NewLine, privateMembers.Select(f => f.Name)));

            return stringBuilder.ToString().TrimEnd();
        }

        public string CollectGettersAndSetters(string className)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Type classType = Type.GetType(className);

            var methods = classType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);

            foreach (var method in methods.Where(f => f.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} will return {method.ReturnType}");

            }

            foreach (var method in methods.Where(f => f.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}

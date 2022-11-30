using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            spy.AnalyzeAccessModifiers("Stealer.Hacker");
        }
    }
}

﻿using System;

namespace Stealer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.StealFieldInfo("Stealer.Hacker", new string[] { "" });
            Console.WriteLine(result);
        }
    }
}

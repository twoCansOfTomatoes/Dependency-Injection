﻿using System;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageWriter writer = new ConsoleMessageWriter();
            var salutation = new Salutation(writer);
            salutation.Exclaim();
        }
    }
}

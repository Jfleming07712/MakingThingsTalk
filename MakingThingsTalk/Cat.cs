﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MakingThingsTalk
{
    public class Cat : SmartThings, ISpeak
    {
        public void SaySomething()
        {
            Console.WriteLine("Meow Meow Meow");
        }
    }
}
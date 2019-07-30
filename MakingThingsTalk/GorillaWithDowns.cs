using System;
using System.Collections.Generic;
using System.Text;

namespace MakingThingsTalk
{
    public class GorillaWithDowns : SmartThings, ISpeak
    {
        public void SaySomething()
        {
            Console.WriteLine("I can haz babY tRumP?!");
        }
    }
}

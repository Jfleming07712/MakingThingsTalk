using System;
using System.Collections.Generic;
using System.Text;

namespace MakingThingsTalk
{
    public class GorillaWithDowns : SmartThings, ISpeak
    {
        public void SaySomething(List<string> phrases)
        {
            foreach(phrase in phrases)

            Console.WriteLine("I can haz babY tRumP?!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MakingThingsTalk
{
    public class GorillaWithDowns : SmartThings, ISpeak
    {
        public void SaySomething(List<string> gwdPhrases)
        {
            foreach (var phrase in gwdPhrases)
                Console.WriteLine(phrase);
        }
    }
}

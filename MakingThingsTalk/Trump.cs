using System;
using System.Collections.Generic;
using System.Text;

namespace MakingThingsTalk
{
    public class Trump : ISpeak
    {
        public void SaySomething(List<string> trumpPhrases)
        {
            foreach (var phrase in trumpPhrases)
                Console.WriteLine(phrase);
        }
    }
    
    

}

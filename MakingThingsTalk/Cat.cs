using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MakingThingsTalk
{
    public class Cat : SmartThings, ISpeak
    {
        public void SaySomething(List<string> catPhrases)
        {
            foreach (var phrase in catPhrases)
                Console.WriteLine(phrase);
        }
    }


}

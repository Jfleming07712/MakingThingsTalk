using System;
using System.Collections.Generic;


namespace MakingThingsTalk
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Trump trump = new Trump();
            GorillaWithDowns gwd = new GorillaWithDowns();
            var phrases = new Phrase();
            var catPhrases = new List<string>();
            var gwdPhrases = new List<string>();
            var trumpPhrases = new List<string>();


            string bannana = "Can I have a bannana?";
            string child = "Please drop your child in my cage";
            string canHazTrump = "I can haz babY tRumP?!";

            string racist = "I am a stupid racist";
            string tradeWar = "Trade wars are easy to win";
            string dictator = "Maybe I just wont leave";


            string meow = "MeowMeowMeow";
            string purr = "Purrrrr";
            string hiss = "Hiss";


            gwdPhrases.Add(bannana);
            gwdPhrases.Add(child);
            gwdPhrases.Add(canHazTrump);


            trumpPhrases.Add(racist);
            trumpPhrases.Add(tradeWar);
            trumpPhrases.Add(dictator);


            catPhrases.Add(meow);
            catPhrases.Add(purr);
            catPhrases.Add(hiss);




            

            ISpeak[] speakers = new ISpeak[3];
            speakers[0] = cat;
            speakers[1] = gwd;
            speakers[2] = trump;

            
            cat.SaySomething(catPhrases);

            trump.SaySomething(trumpPhrases);

            gwd.SaySomething(gwdPhrases);
        }
    }
}

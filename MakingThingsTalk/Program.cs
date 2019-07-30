using System;

namespace MakingThingsTalk
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Trump trump = new Trump();
            GorillaWithDowns gwd = new GorillaWithDowns();

            ISpeak[] speakers = new ISpeak[3];
            speakers[0] = cat;
            speakers[1] = gwd;
            speakers[2] = trump;

            foreach (var speaker in speakers)
            {
                speaker.SaySomething();
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Sweepstakesgame
{
    class MainClass
    {
       public static void Main(string[] args)
        {
            Contestant smurf = new Contestant("Emily", "Katie", "emkat@gmail.com", 1);
            Contestant smurfette = new Contestant("Spounge", "Bob", "sbob@gmail", 2);
            Contestant smurfkid = new Contestant("Erin", "Smith", "ersm@gmail", 3);
            Contestant gargamel = new Contestant("Smurf", "Smurfette", "Smurf@gmail", 4);
            Sweepstakes BlueSmurf = new Sweepstakes("The Lottery");
            BlueSmurf.RegisterContestant(smurf);
            BlueSmurf.RegisterContestant(smurfette);
            BlueSmurf.RegisterContestant(smurfkid);
            BlueSmurf.RegisterContestant(gargamel);

            Console.WriteLine(BlueSmurf.WinnerWinnerChickenDinner());
        }
        
                    
    }
}

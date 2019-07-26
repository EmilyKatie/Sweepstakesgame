using System;
using System.Collections.Generic;
namespace Sweepstakesgame 
{
    public class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        private List<int> RegistrationKeys;

        Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            RegistrationKeys = new List<int>();
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
    }
}

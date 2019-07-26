using System;
using System.Collections.Generic;
namespace Sweepstakesgame
{
    public class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        private List<int> RegistrationKeys;

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            RegistrationKeys = new List<int>();
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
            RegistrationKeys.Add(contestant.RegistrationNumber);
        }
        public string WinnerWinnerChickenDinner()
        {
            Random rnd = new Random();

            int registrationNum = RegistrationKeys[rnd.Next(0, RegistrationKeys.Count - 1)];
            Contestant Winner = contestants[registrationNum];

            return Winner.firstName + " " + Winner.lastName;

        }
        public void PrintContestantInfo(Contestant contestant)
        {

            //string email = email[];
            //Contestant Info = contestants[email];
        }
    }
}
using System;
using System.Collections.Generic;
namespace Sweepstakesgame
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int RegistrationNumber;

        public Contestant(string firstname, string lastname, string email, int regNum)
        {

            this.firstName = firstname;
            this.lastName = lastname;
            this.email = email;
            this.RegistrationNumber = regNum;


        }
    }
}

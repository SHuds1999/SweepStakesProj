using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    public static class UserInterface
    {
        

        

        public static string ChooseFirstName()
        {
            string firstName;
            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();
            return firstName;
        }

        

        public static string ChooseLastName()
        {
            string lastName;
            Console.WriteLine("Please enter your last name.");
            lastName = Console.ReadLine();
            return lastName;
        }

        

        public static void ChooseEmailAddress()
        {
            Console.WriteLine("Please enter your email address.");
            emailAddress = Console.ReadLine();
        }

        

        public static void ChooseRegistrationNumber()
        {
            Console.WriteLine("Please enter your registration number.");
            registrationNumber =  Convert.ToInt32(Console.ReadLine();
        }













    }

}

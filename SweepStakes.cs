using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class SweepStakes
    {
        private Dictionary<int, Contestant> Contestants;
        private string name;
        public string Name;



        public SweepStakes()
        {

            Contestants = new Dictionary<int, Contestant>();




        }



        public void RegisterContestant(Contestant contestant)
        {
            Contestants.Add(contestant);
            Console.WriteLine(Contestants[0]);
        }


        public void PickWinner()
        {
            
        }


        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant);
            Console.ReadLine();
        }









    }
}

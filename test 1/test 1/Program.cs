using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    class User
    {
        public string Name{ get; set; } //Getters and setters which make up the string and also its accessible from anywhere
        public string Species { get; set; }
        public string Sex { get; set; }
        public string Wegiht{ get; set; }
        public string Banno { get; set; }

        public User(string _name , string _species, string _sex, string _wigiht, string _bandno) //Importing and outputting of case sensitive variables
        {
            Name = _name; //To lower case
            Species = _species;
            Sex = _sex;
            Wegiht = _wigiht;
            Banno = _bandno;               
        }

        public string DisplayBird()
        {
            Console.WriteLine("\n***********************************************");
            Console.WriteLine("BIRD OF PREY DATA OUTPUT \n Bird Name: {0} \n Species: {1} \n Sex: {2} \n Weight: {3} \n BandNumber: {4}", Name, Sex, Sex, Wegiht, Banno);
            Console.WriteLine("***********************************************");
            Console.ReadLine();

           // return " Bird Name" + Name + " Species " + Species + " Sex " + Sex + "Weight " + Wegiht + "BandNumber " + Banno; //Returning string to the user 
            return DisplayBird(); //Returning string to the user 
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bird object created amd data loaded...\n"); 
            Console.WriteLine("PLEASE UPDATE THE BIRD DATA\n");
            Console.Write("Enter Bird name: "); //Enter in users imput
            string nameunknown = Console.ReadLine();

            Console.Write("Enter Species: ");
            string speciesunknown = Console.ReadLine();

            Console.Write("Enter sex of Bird: ");
            string sexunknown = Console.ReadLine();

            Console.Write("Enter weight of Bird: ");
            string wightunknown = Console.ReadLine();

            Console.Write("Enter Band number: ");
            string bandnounknown = Console.ReadLine();

            User say = new User(nameunknown, speciesunknown, sexunknown, wightunknown, bandnounknown);
            Console.WriteLine(say.DisplayBird()); //Printing user imput 
            

        }
    }
}

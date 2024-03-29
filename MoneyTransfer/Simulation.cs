﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        public Simulation()
        {
            
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.

            Person personOne = new Person("Andrea", 2300);
            Person personTwo = new Person("Megan", 3800);


            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.

            personOne.DisplayInfo();
            personTwo.DisplayInfo();

            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.

            personTwo.TransferMoney(personOne, 200);

            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.

            personOne.DisplayInfo();
            personTwo.DisplayInfo();

            Console.WriteLine("Simulation complete.");
        }
    }
}

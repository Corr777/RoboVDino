using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_VS.Dinosaurs
{
    class Fleet
    {
        public List<Robot> robot = new List<Robot>();

        public Fleet()
        {
            Robot D4LGA = new Robot("D4LGA", 50);
            robot.Add(D4LGA);


            Robot R8D8 = new Robot("R8D8", 10);
            robot.Add(R8D8);


            Robot goober = new Robot("goober", 5);
            robot.Add(goober);


            Robot aeiou = new Robot("aeiou", 30);
            robot.Add(aeiou);


            Robot bama = new Robot("bama", 20);
            robot.Add(bama);


            Robot DC = new Robot("DC", 40);
            robot.Add(DC);


        }







    }
}

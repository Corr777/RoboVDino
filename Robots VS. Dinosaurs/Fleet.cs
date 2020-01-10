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


            Robot Goober = new Robot("Goober", 5);
            robot.Add(Goober);


            Robot AeIoU = new Robot("AeIoU", 30);
            robot.Add(AeIoU);


            Robot Bama = new Robot("Bama", 20);
            robot.Add(Bama);


            Robot DC = new Robot("DC", 40);
            robot.Add(DC);

        }







    }
}

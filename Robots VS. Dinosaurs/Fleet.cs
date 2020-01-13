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
            Robot D4LGA = new Robot("D4LGA", 100, 100, 50);
            robot.Add(D4LGA);


            Robot R8D8 = new Robot("R8D8", 100, 100, 10);
            robot.Add(R8D8);


            Robot AeIoU = new Robot("AeIoU", 100, 100, 30);
            robot.Add(AeIoU);


        }







    }
}

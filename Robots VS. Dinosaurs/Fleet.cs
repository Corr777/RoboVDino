using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    public class Fleet 
    {
        public List<Robot> Robots = new List<Robot>();

        public Fleet()
        {
             


        }

        public void AddFleet() 
        {
            Robot D4LGA = new Robot("D4LGA", 100, 100, 50);
            robots.Add(D4LGA);


            Robot R8D8 = new Robot("R8D8", 100, 100, 10);
            robots.Add(R8D8);


            Robot AeIoU = new Robot("AeIoU", 100, 100, 30);
            robots.Add(AeIoU);


        }






    }
}

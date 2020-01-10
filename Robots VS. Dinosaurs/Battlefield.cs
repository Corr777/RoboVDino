using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_VS.Dinosaurs
{
    class Battlefield
    {

        //Member variable (Has A)
        public Herd herdOfDinosaurs;
        public Fleet fleetOfRobots;
        
       


        //Constructor (Spawn)

        public Battlefield()
        {
            herdOfDinosaurs = new Herd();
            fleetOfRobots = new Fleet();


        }

        public void DoBattle()
        {
            // write down the steps for the game/battle



            // example attack
             herdOfDinosaurs.dinosaurs[0].Attack();
        }










    }
}

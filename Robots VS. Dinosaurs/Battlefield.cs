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


            for (int i = 0; i < fleetOfRobots.robot.Count; i++)
            {
                Dinosaur dinosaur = herdOfDinosaurs.dinosaurs[i];
                fleetOfRobots.robot[i].Attack(dinosaur);
            }

            for (int i = 0; i < herdOfDinosaurs.dinosaurs.Count; i++)
            {

                Robot robot = fleetOfRobots.robot[i];
                herdOfDinosaurs.dinosaurs[i].Attack(robot);
         
            }
}   }   }

         
        











           
            // example attack
            

            
            //herdOfDinosaurs.dinosaurs[0].attackPower();














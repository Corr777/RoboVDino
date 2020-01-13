using System;

namespace Robots_VS.Dinosaurs
{

    class Battlefield
    {

        //Member variable (Has A)
        public Herd herdOfDinosaurs;
        public Fleet fleetOfRobots;
        public double RoboHealth;
        public double DinoHealth;

        public void Greeting() 
        {
            Console.WriteLine("Robots Vs. Dinosaurs 2020");
        }

        //Constructor (Spawn)

        public Battlefield()
        {
            herdOfDinosaurs = new Herd();
            fleetOfRobots = new Fleet();
           
        }



        public void DoBattle()
        {
            

            // CAN Do


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
            Console.ReadLine();
            









        }



















    }
}















// example attack



//herdOfDinosaurs.dinosaurs[0].attackPower();














using System;

namespace Robots_VS.Dinosaurs
{

    public class Battlefield
    {

        //Member variable (Has A)
        public Herd herdOfDinosaurs;
        public string fleetOfRobots;
        public double RoboHealth;
        public double DinoHealth;


        //Constructor (Spawn)
        public void BattleField() 
        {
            this.RoboHealth = 100;
            this.DinoHealth = 100;
        }

       

        public void StaffingBattlefield()
        {
            herdOfDinosaurs = new Herd();
            fleetOfRobots = new Fleet();
           

        }

        // CAN Do

        public void DoBattle()
        {
            
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
            
            
        }


        public void Calc()
        {
            



        }
















    }
}





























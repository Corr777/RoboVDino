using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_VS.Dinosaurs
{
    public class Robot
    {
        public string name;
        public string type;
        public double energy;
        public double health;
        public double attackPower;
        public string Robots;
        //Constructor 

        public Robot(string Type, double AttackPower, double energy, double health)
        {
            this.type = Type;
            this.energy = energy;
            this.health = health;
            this.attackPower = AttackPower;
        }


        //Member methods (Can Do)

        public string Attack(Dinosaurs dinosaurs)
        {

            dinosaurs.Health -= attackPower;



        }
















    }
}

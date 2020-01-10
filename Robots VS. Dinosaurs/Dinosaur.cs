using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_VS.Dinosaurs
{
    class Dinosaur
   
                //Member variable (Has A)
    {                           
       public string type;
       public double energy;
       public double health;
       public double attackPower;


        //Constructor (Spawn)

        public Dinosaur(string Dinotype, double AttackPower) 
        {
            this.type = Dinotype;
            this.energy = 100;
            this.health = 100;
            this.attackPower = AttackPower;
        }


        //Member methods (Can Do)

        public void AttackRobot(Robot robot) 
        {

            robot.health -= attackPower;
        
        
        }

        

        public void UsedEnergy()
        {






        }


        public void AmountOfHealth()
        {




        }

























    


































    }


























}


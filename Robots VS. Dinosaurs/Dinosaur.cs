namespace Robots_VS.Dinosaurs
{
    public class Dinosaur

    //Member variable (Has A)
    {
        public string type;
        public double energy;
        public double health;
        public double attackPower;


        //Constructor 

        public  Dinosaur(string Type, double AttackPower, double energy, double health)
        {
            this.type = Type;
            this.energy = energy;
            this.health = health;
            this.attackPower = AttackPower;
        }


        //Member methods (Can Do)

        public void Attack(Robot robot)
        {

            robot.RoboHealth -= attackPower;



        }



       




























































    }


























}


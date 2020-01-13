using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Robot_Vs_Dino
{
    class Dinosaur
    {
        //member variables   (HAS A)
        public int health;
        public int energyLevel;
        public int powerLevel;
        public int attackPower;
        public string type;
        public DinoAttack dinoAttack;

        //constructor        (SPAWN)
        public Dinosaur(string type, int powerLevel)
        {
            health = 100;
            energyLevel = 100;
            this.powerLevel = powerLevel;
            attackPower = 10;
            this.type = type;
        }

        //member methods     (CAN DO)
        public void Attack(Robot robot)
        {
            robot.health -= dinoAttack.attackPower;
        }
        public void ChooseAttack()
        {
            Console.WriteLine("Choose your Dinosaur's attack by choosing number 1,2,3: \n1)Tail \n2)Bite \n3)Scrape");
            int input = Convert.ToInt32(Console.ReadLine()); //converting a string into an int 

            {
                switch (input)
                {
                    case 1:
                        dinoAttack = new DinoAttack("Tail");
                        break;
                    case 2:
                        dinoAttack = new DinoAttack("Bite");
                        break;
                    case 3:
                        dinoAttack = new DinoAttack("Scrape");
                        break;
                    default:
                        ChooseAttack();
                        break;

                }

            }

        }
    }
}

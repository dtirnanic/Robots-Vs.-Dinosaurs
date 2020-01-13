using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Robot_Vs_Dino
{
    class Robot
    {
        //member variables   (HAS A)
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;

        //constructor        (SPAWN)
        public Robot(string name, int powerLevel)
        {
          
            this.name = name;
            health = 100;
            this.powerLevel = powerLevel;
            

        }

        //member methods     (CAN DO)
        public void ChooseWeapon()
        {
            Console.WriteLine("Choose your Robot's weapon by choosing number 1,2,3: \n1)Sword \n2)War Hammer \n3)Battle Axe");
            //weapon = new Weapon();
            int input = Convert.ToInt32(Console.ReadLine()); //converting a string into an int 

            {
                switch (input)
                {   case 1:
                        weapon = new Weapon ("Sword");
                        break;
                    case 2:
                        weapon = new Weapon("War Hammer");
                        break;
                    case 3:
                        weapon = new Weapon("Battle Axe");
                        break;
                    default:
                        ChooseWeapon();
                        break;

                }
                    
            }

        }
        public void Attack(Dinosaur dino)
        {
            dino.health -= weapon.attackPower; //same as: dino.health = dino.health - weapon.attackPower
        }


    }
}

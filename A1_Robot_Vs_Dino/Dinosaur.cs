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

        //constructor        (SPAWN)
        public Dinosaur(int powerLevel, int attackPower)
        {
            health = 100;
            energyLevel = 100;
            this.powerLevel = powerLevel;
            this.attackPower = attackPower;
        }

        //member methods     (CAN DO)
        public void Attack()
        {

        }
    }
}

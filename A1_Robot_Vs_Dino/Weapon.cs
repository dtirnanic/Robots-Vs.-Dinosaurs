using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Robot_Vs_Dino
{
    class Weapon
    {
        //member variables   (HAS A)
        public string type; 
        public int attackPower; 

        //constructor        (SPAWN)
        public Weapon(string type)
        {
            this.type = type;
            attackPower = 80;
        }

        //member methods     (CAN DO)
    }
}

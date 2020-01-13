using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Robot_Vs_Dino
{
    class DinoAttack
    {
        public string type;
        public int attackPower;

        public DinoAttack(string type)
        {
            this.type = type;
            attackPower = 10;
        }
    }
}

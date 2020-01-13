using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Robot_Vs_Dino
{
    class Herd
    {
        //potential refactor 

        public List<Dinosaur> dinosaurList = new List<Dinosaur>() {new Dinosaur("Type1",80), new Dinosaur("Type2",80),new Dinosaur("Type3",80)};

        public bool DinoHealth()
        {
            for (int counter = 0; counter < dinosaurList.Count; counter++)
            {
                if (dinosaurList[counter].health > 0)
                    return true;
            }    
            return false;
        }
        


        public void DinoAttackType()  
        {
            for (int counter = 0; counter < dinosaurList.Count; counter++)  
            {
                dinosaurList[counter].ChooseAttack();  
            }

        }

        //member variables   (HAS A)

        //constructor        (SPAWN)

        //member methods     (CAN DO)
    }
}

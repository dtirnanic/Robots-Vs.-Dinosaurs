using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Robot_Vs_Dino
{
    class Fleet
    {
        public List<Robot> robotList = new List<Robot>() {new Robot("Rob",80), new Robot("Rob1",80), new Robot("Rob2",80)};

        public bool RobotHealth()
        {
            for (int counter = 0; counter < robotList.Count; counter++)
            {
                if (robotList[counter].health > 0)
                    return true;
            }
            return false;
        }
        //member variables   (HAS A)

        //constructor        (SPAWN)

        //member methods     (CAN DO)
        public void EquipWeapon()
        {
            for (int counter = 0; counter < robotList.Count; counter++)
            {
                robotList[counter].ChooseWeapon();
            }
        }
    }
}

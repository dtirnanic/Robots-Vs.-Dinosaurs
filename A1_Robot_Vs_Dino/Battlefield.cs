using System;

namespace A1_Robot_Vs_Dino
{
    class Battlefield
    {
        //try some for loops in the different member variables in this class
        //try to be creative, try putting different things in a loop
        //runbattle in do while loop and see what it asks me for
        //member variables   (HAS A)
        public Robot chosenRobot;
        public Dinosaur chosenDino;
        public Fleet robots;
        public Herd dinos;
        //constructor        (SPAWN)
        public Battlefield()
        {
            robots = new Fleet();
            dinos = new Herd();
        }

        //member methods     (CAN DO)
        public void RunBattle() //master method
        {
            //display welcome message
            Console.WriteLine("Welcome to Robots Vs. Dinosaurs");

            

            BattleSequence();
            
    
        }    
        //create robots
        public void ChooseRobot()
        {
           
            Console.WriteLine("Please choose a robot by choosing robot number: \n1) \n2) \n3)");
            string input = Console.ReadLine();

            for (int counter = 0; counter < robots.robotList.Count; counter++)
            {
                Console.WriteLine(robots.robotList[counter].name);
            }


            switch (input)
            {
                case "1":
                    chosenRobot = robots.robotList[0];
                    break;
                case "2":
                    chosenRobot = robots.robotList[1];
                    break;
                case "3":
                    chosenRobot = robots.robotList[2];
                    break;
                default:
                    break;
            }

        }
        //create dinos
        public void ChooseDinosaur()
        {
            Console.WriteLine("Please choose a Dinosaur by choosing dinosaur number \n1) \n2) \n3)"); 
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    chosenDino = dinos.dinosaurList[0];
                    break;
                case "2":
                    chosenDino = dinos.dinosaurList[1];
                    break;
                case "3":
                    chosenDino = dinos.dinosaurList[2];
                    break;
                default:
                    break;

            }
                
        }

        public void BattleSequence()
        {
            do
            {
                ChooseRobot();
                chosenRobot.ChooseWeapon();

                ChooseDinosaur();
                chosenDino.ChooseAttack();

                chosenRobot.Attack(chosenDino);
                chosenDino.Attack(chosenRobot);
            }
            while (dinos.DinoHealth() && robots.RobotHealth());
            if (dinos.DinoHealth() == false )   // !true = false, !false = true
            {
                Console.WriteLine("Robots win");
            }
            else
            {
                Console.WriteLine("Dinos win");
            }
        }
    }
}


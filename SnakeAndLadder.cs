using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public  class SnakeAndLadder
    {
        public static void  CheckPosition()
        {
            int position = 0;
            int count = 0;

            Random random = new Random();

            Console.WriteLine("position of player is:" + position);

            while(position != 100)
            {
                count++;

                int dieNum = random.Next(6) + 1;

                Console.WriteLine("Dice rolled:" + dieNum);

                int checkoption = random.Next(3);

                switch(checkoption)
                {
                    case 0:
                        Console.WriteLine("No paly");
                        break;

                    case 1:
                        Console.WriteLine("Play ladder");
                        position += dieNum;
                        if (position > 100)
                            position -= dieNum;
                        break;

                    default:
                        Console.WriteLine("play snake");
                        position -= dieNum;
                        break;

                     
                }
                if(position < 0)
                {
                    position = 0;
                }
                Console.WriteLine("user palyed " + count + "times till now");
                Console.WriteLine("New position is: " + position + "\n");
            }
            Console.WriteLine("Total " + count + "time dice player won the game!!");
        }
    }
}

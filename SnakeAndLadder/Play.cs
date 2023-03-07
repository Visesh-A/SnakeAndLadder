using System;
namespace SnakeAndLader
{
    public class Game
    {
        int PlayerPosition = 0;
        Random random = new Random();
        public void DieRoll()
        {
            int die = random.Next(1, 7);
            Console.WriteLine(die);
        }
    }
}
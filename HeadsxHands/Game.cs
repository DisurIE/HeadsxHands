using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsxHands
{
    internal class Game
    {


        private int GetIntInput(int min, int max)
        {
            int value;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Некорректный ввод. Попробуйте снова. " +
                                      $"Число должно быть в диапазоне ({min}, {max})");
                }
            }
        }
    }



}

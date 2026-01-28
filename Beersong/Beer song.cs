using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beersong
{
    internal class Beersong
    {
        public void Sing()
        {
            for (int i = 99; i >= 1; i--)
            {
                string bottleWord = i == 1 ? "bottle" : "bottles";
                Console.WriteLine($"{i} {bottleWord} of beer on the wall, {i} {bottleWord} of beer. Take one down and pass it around.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Name ="Jimmy", Height = 76};
        }
    }
    class TallGuy
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }
    }
}

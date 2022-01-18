using System;
namespace Типове_Данни
{
    class Stork : Bird
    {   
        private bool EatsAnimalsOrNo {get; set;}
        private string color;

        public Stork(string color, bool eats) : base(eats)
        {
            this.color = color;
            this.EatsAnimalsOrNo = eats;
        }
        public override void makeSound()
        {
            Console.WriteLine("Stork sounds");
        }

    }
}
using System;
namespace Типове_Данни
{
    public abstract class Bird
    {
        private bool EatsAnimalsOrNo {get; set;}

        public Bird(bool eats)
        {
            this.EatsAnimalsOrNo = eats;
        }

        public abstract void makeSound();
    }
}

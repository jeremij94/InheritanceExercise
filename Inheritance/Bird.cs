using System;
namespace Inheritance
{
    public class Bird : Animal 
    {
        public Bird()
        {
        }

        public bool Feathered { get; set; }
        public bool CanFly { get; set; }
        public string EggColor { get; set; }
        public string Habitat { get; set; }

    }
}


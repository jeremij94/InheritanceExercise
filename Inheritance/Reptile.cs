using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }

        public bool ColdBlooded { get; set; }
        public bool Amphibious { get; set; }
        public string Venomous { get; set; }
        public string Scales { get; set; }
    }
}


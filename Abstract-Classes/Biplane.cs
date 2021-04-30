using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes
{
    public class Biplane : Plane
    {
        public override string Type
        {
            get
            {
                return "Bilane";
            }
        }
 
        public override int Speed
        {
            get
            {
                return 400;
            }
        }
 
        public void LandWithEngineOff()
        {
            Console.WriteLine("Biplane has landed with engine off!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes
{
    public class Fighter : JetPlane
    {
        public override string Type
        {
            get
            {
                return "Fighter";
            }
        }

        public override int Speed
        {
            get
            {
                return 1200;
            }
        }
        public override void RunAutopilot()
        {
            base.RunAutopilot();
            Console.WriteLine("Searching for targets...");
        }
        public void EjectThePilot()
        {
            Console.WriteLine("Pilot is ejected!");
        }
    }
}

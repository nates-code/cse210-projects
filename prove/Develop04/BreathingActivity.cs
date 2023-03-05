using System;
using System.Collections.Generic;
using System.Threading;


namespace Develop04 
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description, List<string> messageList) 
            : base(name, description, messageList)
        {
        }

        private void RunBreathInOut(int duration)
        {
            while (duration > 0)
            {
                Console.Write("Breath in... " );
                for (int i = 4; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine();
                
                Console.Write("Breath out... " );
                for (int i = 6; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine();
                Console.WriteLine();
                duration -= 10;
            }
            
        }
        public override void ActivityLoop(int duration)
        {
            Ready();
            RunBreathInOut(duration);
            Console.WriteLine();
        }
    }
}



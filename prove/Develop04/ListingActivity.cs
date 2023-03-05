using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04 
{
    public class ListingActivity : Activity

    {
        public ListingActivity(string name, string description, List<string> messageList) : base(name,
            description, messageList)
        {
        }
        
        private void RunListMaker(int duration)
        {
            string prompt = RandomChoice(_messageList);
            Console.WriteLine("List as many responses as you can to the following prompt: ");
            Console.WriteLine($"--- {prompt} ---");;
            
            Pause(5);
            
            // As part of the stretch challenge I made it wait for you to be at a good stopping point.  
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            bool hasTime = true;
            int responses = 0;
            
            while (hasTime)
            {
                Console.Write("> ");
                Console.ReadLine();
                responses++;
                hasTime = DateTime.Now <= endTime;
            }

            string things = responses != 1 ? "things" : "thing";
            Console.WriteLine($"You listed {responses} {things}!");

        }
        public override void ActivityLoop(int duration)
        {
            Ready();
            RunListMaker(duration);
            Console.WriteLine();
        }
        
        
    }
}





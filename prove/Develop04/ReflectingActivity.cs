using System;
using System.Collections.Generic;

namespace Develop04 
{
    public class ReflectingActivity : Activity 


    {
        private readonly List<string> _refList = new List<string>();
        private readonly List<string> _usedPrompts = new List<string>();
        
        public ReflectingActivity(string name, string description, List<string> messageList, List<string> refList) : base(
            name, description, messageList)
        {
            _refList = refList;
        }
        
        private void RunReflect(int duration)
        {
            string prompt = RandomChoice(_messageList);
            Console.WriteLine("List as many responses as you can to the following prompt: ");
            Console.WriteLine();
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue. ");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            
            Pause(3);

            while (duration > 0)
            {
                int waitTime = 5;
                Console.Write($"> {GetUniquePrompt()} ");
                DisplayAnimation(waitTime);
                Console.WriteLine();
                duration -= waitTime;
                if (_refList.Count == _usedPrompts.Count)
                {
                    Console.WriteLine("You have answered all the questions. ");
                    duration = 0;
                }
            }
        }

        // For the stretch challenge I also made it so no duplicate prompts would be selected.
        private string GetUniquePrompt()
        {
            while (true)
            {
                string prompt = RandomChoice(_refList);
                if (!_usedPrompts.Contains(prompt))
                {
                    _usedPrompts.Add(prompt);
                    return prompt;
                }
            }
        }
        public override void ActivityLoop(int duration)
        {
            Ready();
            RunReflect(duration);
            Console.WriteLine();
        }
    }
}






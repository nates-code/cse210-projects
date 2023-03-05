using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04 
{
    public class Activity

    {
        private string _name;
        private string _description;
        protected List<string> _messageList = new List<string>();


        protected Activity(string name, string description, List<string> messageList)
        {
            _name = name;
            _description = description;
            _messageList = messageList;
        } 
        

        public void Run()
        {
            Console.WriteLine($"Welcome to the {_name}");
            Console.WriteLine(_description);
            int duration = GetIntInput("How long, in seconds, would you like for your session: ");
            
            ActivityLoop(duration);
            End(duration);
        }
        
        public virtual void ActivityLoop(int duration)
        {
            // This will be overridden by the other classes.
            Console.WriteLine("Error you need to define this in your class.");
        }
         
        private void End(int duration)
        {
            Console.WriteLine("Well done!");
            DisplayAnimation(3);
            Console.WriteLine($"You have completed another {duration} of {_name}");
            DisplayAnimation(3);
        }
        
        protected void DisplayAnimation(int duration)
        {
            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            int i = 0;
            
            while (DateTime.Now <= endTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
                
                i++;

                if (i >= animationStrings.Count)
                {
                    i = 0; 
                }
            }
            Console.WriteLine();
        }

        private string GetInput(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        
        private int GetIntInput(string msg)
        {
            string input = GetInput(msg);
            return int.Parse(input);
        }
        
        protected string RandomChoice(List<string> inList)
        {
            var random = new Random();
            var index = random.Next(inList.Count);
            return inList[index];
        }

        protected void Ready()
        {
            Console.WriteLine("Get ready... ");
            DisplayAnimation(3);
        }
        
        protected void Pause(int duration) //, int pauseType
        {
            while (duration > 0)
            {
                Console.Write("You may begin in: ");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine();
                duration -= 5;
            }
        }
        
        // get / set
        public string GetName()
        {
            return _name;
        }
        
        public string GetDescription()
        {
            return _description;
        }
        
        public List<string> GetMessageList()
        {
            return _messageList;
        }

        public void SetName(string name)
        {
            _name = name;
        }
        
        public void SetDescription(string description)
        {
            _description = description;
        }
        
        public void SetMessageList(List<string> messageList)
        {
            _messageList = messageList;
        }
    }
}






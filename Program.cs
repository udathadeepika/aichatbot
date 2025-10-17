using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hey Iam ur ai chatbot, Welcome! ");
        Console.WriteLine("Enter 'exit' to close ur response");
        Dictionary<string, string> response = new Dictionary<string, string>()
        {
            { "hi", "Hello welcome, how can I help you?" },
    { "namaste", "Hey, are you Telugu?" },
    { "how are you", "I’m doing great, thanks for asking!" },
    { "your name", "I’m an AI chatbot created in C#." },
    { "bye", "Goodbye! Have a nice day!" }

        };
        while (true)
        {
            Console.Write("You: ");
            string UserInput = Console.ReadLine().ToLower();

            if (UserInput == "exit")
                break;
            bool replied = false;
            foreach( var pair in response)
            {
                if (UserInput.Contains(pair.Key))
                {
                    Console.WriteLine("Bot: "+ pair.Value);
                    replied = true;
                    break;
                }
                
            }
            if (!replied)
            {
                Console.WriteLine("bot:  sorryyy i did not understand");
            }

        }
    }
}
using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        { 
            bool shutdown = false;
            bool foundresponse; 
            string inputvalue;
            string outputvalue = "";
            

            Console.WriteLine("Computer: What would you like to say?");

            while (!shutdown)
            {
                foundresponse = false;

                Console.Write("User: ");
                inputvalue = Console.ReadLine().ToLower();

                Console.Write("Computer: ");
                switch (inputvalue)
                {
                    case "hello":
                        outputvalue = "Hi good to see you, what else would you like to say?";
                        foundresponse = true;
                        break;

                    case "sup":
                        outputvalue = "I am good, what else would you like to say?";
                        foundresponse = true;
                        break;

                    case "hello there":
                        outputvalue = "General Kenobi, what else would you like to say?";
                        foundresponse = true;
                        break;

                    case "bye":
                        outputvalue = "Good bye!";
                        foundresponse = true;
                        shutdown = true;
                        break;

                }

                if (foundresponse)
                {
                    Console.WriteLine(outputvalue);
                }
                else
                {
                    Console.WriteLine("found no response");
                }
            }
            }
        }
    }


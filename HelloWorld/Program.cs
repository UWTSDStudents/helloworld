using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBuilder builder = new MessageBuilder();
            string message;

            message = builder.BuildHelloMessage();
            Console.WriteLine(message);

            message = builder.BuildMessage("Hello {0}", "Fred");
            Console.WriteLine(message);

            Console.ReadKey();  // Pause waiting for key to be pressed
        }
    }
}

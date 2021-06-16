using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class MessageBuilder
    {
        public string BuildHelloMessage()
        {
            return "Hello World Again2";
        }

        public string BuildMessage(string format, params object[] args)
        {
            return string.Format(format, args);
        }
    }
}

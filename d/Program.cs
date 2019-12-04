using System;
using System.Collections.Generic;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Inversion Principle");

            SMS messenger = new SMS();
            //Text messenger = new Text();
            MessageSender sender = new MessageSender(messenger); // Inject type here
            sender.Send("Hello World!");
        }
    }

    interface IMessage
    {
        void SendMessage(string message);
    }

    class SMS : IMessage
    {
        public void SendMessage(string message)
        {
            // Send message via SMS
        }
    }

    class Text : IMessage
    {
        public void SendMessage(string message)
        {
            // Send message via Text
        }
    }

    class MessageSender
    {
        IMessage _messager;

        public MessageSender(IMessage messager)
        {
            this._messager = messager;
        }

        public void Send(string message)
        {
            this._messager.SendMessage(message);
        }
    }
}

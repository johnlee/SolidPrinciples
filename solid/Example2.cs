using System;
namespace solid
{
    public class Example2
    {
        public Example2()
        {
        }
    }


    public abstract class Message
    {
        public abstract void Send();
    }

    public abstract class Mail
    {
        public abstract void Send();
    }

    public class Fax
    {
        public void Send()
        {
            throw new NotImplementedException();
        }
    }

    interface IMessage
    {
        void Content();
    }

    interface IRoute
    {
        void Path();
    }

    public class Sender : Message, IMessage, IRoute
    {
        public void Content()
        {
            throw new NotImplementedException();
        }

        public void Path()
        {
            throw new NotImplementedException();
        }

        public override void Send()
        {
            throw new NotImplementedException();
        }
    }
}

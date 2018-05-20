using System;
using Akka.Actor;
using Akka.Dispatch;
using Akka.Util;

namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = ActorSystem.Create("TestSystem");
            var actor = t.ActorOf(Props.Create<TestActor>());
            actor.Tell(new LogMessage());
            Console.ReadKey();
        }
    }

    class TestActor : ReceiveActor
    {
        public TestActor()
        {
            Receive<LogMessage>(m => Console.WriteLine("Test"));
        }
    }

    class LogMessage { }
}

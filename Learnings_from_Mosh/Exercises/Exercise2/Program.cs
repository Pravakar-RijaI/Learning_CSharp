using Classes;
using StackOverPost;
using System;
using System.Threading;

namespace Exercise2
{
    internal class Program
    {
        static void Main()
        {
            /*//Exercise 1
            StopWatch stopWatch = new StopWatch();
            stopWatch.Start();
            Thread.Sleep(1000);
            stopWatch.Stop();
            Console.WriteLine("Duration: " + stopWatch.Duration());*/

            /*//Exercise 2
            Post P1 = new Post();
            P1.UpVote();
            P1.DownVote();
            Console.WriteLine(P1.VoteValue);*/

            /*//Exercise 3
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Push(null);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            for (int i = 0; i <= 5; i++)
                stack.Push(i);

            for(int i = 0; i <= 5; i++)
                Console.WriteLine(stack.Pop());*/

            /*//Exercise 4
            SQLConnection Conn = new SQLConnection("New");
            Conn.Timeout = new TimeSpan(1, 0, 0);
            Conn.OpenConnection();
            Conn.CloseConnection();

            OracleConnection Connection = new OracleConnection("DbConnection");
            Connection.Timeout = new TimeSpan(23);
            Connection.OpenConnection();
            Connection.CloseConnection();

            DbCommand command = new DbCommand(new SQLConnection("DbConn"), "SELECT * FROM TABLE");
            command.Execute();*/

            /*//Exercise 5
            //WorkFlow Engine
            WorkFlow workFlow = new WorkFlow();
            workFlow.AddActivity(new UploadVideo());
            workFlow.AddActivity(new VideoEncode());
            workFlow.AddActivity(new SendEmail());
            workFlow.AddActivity(new VideoStatus());
            WorkFlowEngine workFlowEngine = new WorkFlowEngine();
            workFlowEngine.Run(workFlow);*/
        }
    }
}

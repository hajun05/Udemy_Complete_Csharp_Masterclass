namespace Delegate_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            EmailTask emailTask = new EmailTask();
            emailTask.Recipient = "112233";
            emailTask.Message = "Test";

            ReportTask reportTask = new ReportTask();
            reportTask.ReportName = "Report";
            reportTask.Message = "message";

            TaskProcessor<EmailTask, string> taskEmailProcessor = new TaskProcessor<EmailTask, string>(emailTask);
            Console.WriteLine(taskEmailProcessor.Excute());
            TaskProcessor<ReportTask, string> taskReportProcessor = new TaskProcessor<ReportTask, string>(reportTask);
            Console.WriteLine(taskReportProcessor.Excute());
        }
    }

    public interface ITask<T>
    {
        T Perform();
    }

    public class EmailTask : ITask<string>
    {
        public string Recipient { get; set; }
        public string Message { get; set; }

        public string Perform()
        {
            return $"Email sent to {Recipient} with message {Message}";
        }
    }
    public class ReportTask : ITask<string>
    {
        public string ReportName { get; set; }
        public string Message { get; set; }

        public string Perform()
        {
            return $"{ReportName} report with message {Message}";
        }
    }
    public class TaskProcessor<TTask, TResult> where TTask : ITask<TResult>
    {
        public TTask Task { get; set; }

        public TaskProcessor(TTask task) : base()
        {
            Task = task;
        }

        public TResult Excute()
        {
            return Task.Perform();
        }
    }
}

namespace Logger.Models.Appenders
{
    using System;

    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string formmatedLog = this.GetFormatedLog(dateTime, reportLevel, message);
                Console.Write(formmatedLog);
            }
        }
    }
}

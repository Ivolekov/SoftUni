namespace Logger.Models
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>(appenders);
        }

        public ICollection<IAppender> Appenders { get; set; }

        public void Info(string message)
        {
            this.LogMessage(ReportLevel.Info, message);
        }

        public void Error(string message)
        {
            this.LogMessage(ReportLevel.Error, message);
        }

        public void Warn(string message)
        {
            this.LogMessage(ReportLevel.Warn, message);
        }

        public void Fatal(string message)
        {
            this.LogMessage(ReportLevel.Fatal, message);
        }

        public void Critical(string message)
        {
            this.LogMessage(ReportLevel.Critical, message);
        }

        private void LogMessage(ReportLevel reportLevel, string message)
        {
            DateTime dateTime = DateTime.Now;

            foreach (var appender in this.Appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }
    }
}

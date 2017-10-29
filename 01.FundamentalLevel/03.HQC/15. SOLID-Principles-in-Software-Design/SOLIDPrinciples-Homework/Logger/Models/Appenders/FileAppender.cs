namespace Logger.Models.Appenders
{
    using System;

    using global::Logger.Interfaces;

    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout)
            : base(layout)
        {
        }

        public string File { get; set; }

        public override void Append(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string formmatedLog = this.GetFormatedLog(dateTime, reportLevel, message);
                System.IO.File.AppendAllText(this.File, formmatedLog);
            }
        }
    }
}

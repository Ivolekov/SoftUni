namespace Logger.Models.Appenders
{
    using System;

    using Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel.Info;
        }

        public ReportLevel ReportLevel { get; set; }

        public ILayout Layout { get; set; }

        public abstract void Append(DateTime dateTime, ReportLevel reportLevel, string message);

        public string GetFormatedLog(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            return this.Layout.FormatLog(dateTime, reportLevel, message);
        }
    }
}

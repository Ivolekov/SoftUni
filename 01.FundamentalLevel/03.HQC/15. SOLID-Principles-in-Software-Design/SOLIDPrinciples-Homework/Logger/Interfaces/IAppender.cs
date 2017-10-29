namespace Logger.Interfaces
{
    using System;

    using Logger.Models;

    public interface IAppender
    {
        void Append(DateTime dateTime, ReportLevel reportLevel, string message);
    }
}

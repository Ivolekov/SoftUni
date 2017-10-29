namespace Logger.Interfaces
{
    using System;

    using Logger.Models;

    public interface ILayout
    {
        string FormatLog(DateTime dateTime, ReportLevel reportingLevel, string message);
    }
}

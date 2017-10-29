namespace Logger.Models.Layouts
{
    using System;

    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string FormatLog(DateTime dateTime, ReportLevel reportingLevel, string massage)
        {
            string formatedLog = string.Format("{0} - {1} - {2}", dateTime, reportingLevel, massage + Environment.NewLine);

            return formatedLog;
        }
    }
}

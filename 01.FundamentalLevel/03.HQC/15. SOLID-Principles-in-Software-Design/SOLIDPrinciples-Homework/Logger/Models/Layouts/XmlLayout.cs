namespace Logger.Models.Layouts
{
    using System;
    using System.Text;

    using global::Logger.Interfaces;

    public class XmlLayout : ILayout
    {
        public string FormatLog(DateTime dateTime, ReportLevel reportingLevel, string message)
        {
            StringBuilder formatedXmlLog = new StringBuilder();

            formatedXmlLog.AppendLine("<log>");
            formatedXmlLog.AppendLine(string.Format("\t<data>{0}</date>", dateTime));
            formatedXmlLog.AppendLine(string.Format("\t<level>{0}</level>", reportingLevel));
            formatedXmlLog.AppendLine(string.Format("\t<message>{0}</mesage>", message));
            formatedXmlLog.AppendLine("</log>");

            return formatedXmlLog.ToString();
        }
    }
}

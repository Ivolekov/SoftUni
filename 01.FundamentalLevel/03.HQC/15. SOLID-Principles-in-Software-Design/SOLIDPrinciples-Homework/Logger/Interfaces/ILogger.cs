namespace Logger.Interfaces
{
    using System.Collections.Generic;

    public interface ILogger
    {
        ICollection<IAppender> Appenders { get; } 

        void Info(string message);

        void Error(string message);

        void Warn(string message);

        void Fatal(string message);

        void Critical(string message);
    }
}

using System;
namespace ShareFile.Api.Client.Logging
{
    public class DefaultLoggingProvider : ILogger
    {
        // Default to Error loglevel
        private LogLevel _logLevel = LogLevel.Error;

#if !NO_CALLERMEMBER
        public bool LogCallerMember
        {
            get { return false; }
        }
#endif

        public LogLevel LogLevel
        {
            get { return _logLevel; }
            set { _logLevel = value; }
        }

        public void Trace(string message)
        {
            System.Diagnostics.Debug.WriteLine("TRACE: {0}", message);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Trace;
            args.message = message;
            OnTraceCalled(args);
        }

        public void Trace(Exception exception, string message)
        {
            System.Diagnostics.Debug.WriteLine("TRACE: {0} : {1}", message, exception);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Trace;
            args.message = message;
            OnTraceCalled(args);
        }

        protected virtual void OnTraceCalled(LogEventArgs e)
        {
            EventHandler<LogEventArgs> handler = TraceCalled;
            handler(this, e);
        }

        public void Debug(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }

        public void Debug(Exception exception, string message)
        {
            System.Diagnostics.Debug.WriteLine("{0} : {1}", message, exception);
        }

        public void Info(string message)
        {
            System.Diagnostics.Debug.WriteLine("INFO: {0}", message);
        }

        public void Info(Exception exception, string message)
        {
            System.Diagnostics.Debug.WriteLine("INFO: {0} : {1}", message, exception);
        }

        public void Warn(string message)
        {
            System.Diagnostics.Debug.WriteLine("WARN: {0}", message);
        }

        public void Warn(Exception exception, string message)
        {
            System.Diagnostics.Debug.WriteLine("TRACE: {0} : {1}", message, exception);
        }

        public void Error(string message)
        {
            System.Diagnostics.Debug.WriteLine("ERROR: {0}", message);
        }

        public void Error(Exception exception, string message)
        {
            System.Diagnostics.Debug.WriteLine("ERROR: {0} : {1}", message, exception);
        }

        public void Fatal(string message)
        {
            System.Diagnostics.Debug.WriteLine("FATAL: {0}", message);
        }

        public void Fatal(Exception exception, string message)
        {
            System.Diagnostics.Debug.WriteLine("FATAL: {0} : {1}", message, exception);
        }

        public event EventHandler<LogEventArgs> TraceCalled;
        public event EventHandler<LogEventArgs> DebugCalled;
        public event EventHandler<LogEventArgs> InfoCalled;
        public event EventHandler<LogEventArgs> WarnCalled;
        public event EventHandler<LogEventArgs> ErrorCalled;
        public event EventHandler<LogEventArgs> FatalCalled;
    }
}

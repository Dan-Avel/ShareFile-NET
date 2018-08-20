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
            TraceCalled?.Invoke(this, e);
        }

        public void Debug(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Debug;
            args.message = message;
            OnDebugCalled(args);
        }

        public void Debug(Exception exception, string message)
        {
            System.Diagnostics.Debug.WriteLine("{0} : {1}", message, exception);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Debug;
            args.message = message;
            OnDebugCalled(args);
        }

        protected virtual void OnDebugCalled(LogEventArgs e)
        {
            DebugCalled?.Invoke(this, e);
        }

        public void Info(string message)
        {
            System.Diagnostics.Debug.WriteLine("INFO: {0}", message);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Info;
            args.message = message;
            OnInfoCalled(args);
        }

        public void Info(Exception exception, string message)
        {
            System.Diagnostics.Debug.WriteLine("INFO: {0} : {1}", message, exception);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Info;
            args.message = message;
            OnInfoCalled(args);
        }

        protected virtual void OnInfoCalled(LogEventArgs e)
        {
            InfoCalled?.Invoke(this, e);
        }

        public void Warn(string message)
        {
            System.Diagnostics.Debug.WriteLine("WARN: {0}", message);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Warn;
            args.message = message;
            OnWarnCalled(args);
        }

        public void Warn(Exception exception, string message)
        {
            System.Diagnostics.Debug.WriteLine("TRACE: {0} : {1}", message, exception);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Warn;
            args.message = message;
            OnWarnCalled(args);
        }

        protected virtual void OnWarnCalled(LogEventArgs e)
        {
            WarnCalled?.Invoke(this, e);
        }

        public void Error(string message)
        {
            System.Diagnostics.Debug.WriteLine("ERROR: {0}", message);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Error;
            args.message = message;
            OnErrorCalled(args);
        }

        public void Error(Exception exception, string message)
        {
            System.Diagnostics.Debug.WriteLine("ERROR: {0} : {1}", message, exception);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Error;
            args.message = message;
            OnErrorCalled(args);
        }

        protected virtual void OnErrorCalled(LogEventArgs e)
        {
            ErrorCalled?.Invoke(this, e);
        }

        public void Fatal(string message)
        {
            System.Diagnostics.Debug.WriteLine("FATAL: {0}", message);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Fatal;
            args.message = message;
            OnFatalCalled(args);
        }

        public void Fatal(Exception exception, string message)
        {
            System.Diagnostics.Debug.WriteLine("FATAL: {0} : {1}", message, exception);
            LogEventArgs args = new LogEventArgs();
            args.logType = LogType.Fatal;
            args.message = message;
            OnFatalCalled(args);
        }

        protected virtual void OnFatalCalled(LogEventArgs e)
        {
            FatalCalled?.Invoke(this, e);
        }

        public event EventHandler<LogEventArgs> TraceCalled;
        public event EventHandler<LogEventArgs> DebugCalled;
        public event EventHandler<LogEventArgs> InfoCalled;
        public event EventHandler<LogEventArgs> WarnCalled;
        public event EventHandler<LogEventArgs> ErrorCalled;
        public event EventHandler<LogEventArgs> FatalCalled;
    }
}

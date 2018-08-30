using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class BasicLog
{

    private string _datetimeFormat; // date
    private string _logFileName;   // log 
    private int _errorCount;   // errors 
    private int _failureCount; // fatal errors
    private int _warningCount; // warnings
    private int _writtenLoglines;
    private int _logType;
    private readonly string[] _strngLevels;

    /// <summary>
    /// Supported log level
    /// </summary>
    [Flags]
    private enum LogLevel
    {
        TRACE, INFO, DEBUG, WARNING, ERROR, FATAL, BRIEF_REPORT
    };

    /// <summary>
    /// [Enum] Log type (text, xml, no log)
    /// </summary>
    [Flags]
    public enum LogType
    {
        NoLog, LogInTextFormat
    };

    /// <summary>
    /// Parameter construct
    /// </summary>
    /// <param name="datetimeFormat"></param>
    /// <param name="logFileName"></param>
    /// <param name="errorCount"></param>
    /// <param name="failureCount"></param>
    /// <param name="warningCount"></param>
    /// <param name="strgLevels"></param>
    public BasicLog(string datetimeFormat, string logFileName, int errorCount, int failureCount, int warningCount, string[] strgLevels)
    {
        _datetimeFormat = datetimeFormat;
        _logFileName = logFileName;
        this._errorCount = errorCount;
        this._failureCount = failureCount;
        this._warningCount = warningCount;
        _strngLevels = strgLevels;
    }

    /// <summary>
    /// Initialize a new instance of SimpleLogger class.
    /// Log file will be created automatically if not yet exists, else it can be either a fresh new file or append to the existing file.
    /// Default is create a fresh new log file.
    /// </summary>
    /// <param name="append">True to append to existing log file, False to overwrite and create new log file</param>
    /// <param name="filename">Optional : set a different name of the log if desired </param>
    public BasicLog(string filename = "", bool append = false)
    {
        _datetimeFormat = "yyyy-MM-dd HH:mm:ss.fff";
        _strngLevels = new string[] { " [TRACE] ", " [INFO] ", " [DEBUG] ", " [WARNING] ", " [ERROR] ", " [FATAL] ", " [REPORT] " };

        // If not defined filename use the application default one
        if (filename == string.Empty)
            _logFileName = Assembly.GetExecutingAssembly().GetName().Name + ".log";
        else
            _logFileName = filename + ".log";

        // Log file header line
        string logHeader = _logFileName + " is created.";
        if (!File.Exists( _logFileName ))
        {
            WriteLine( DateTime.Now.ToString( _datetimeFormat ) + " " + logHeader, false );
        }
        else
        {
            if (append == false)
                WriteLine( DateTime.Now.ToString( _datetimeFormat ) + " " + logHeader, false );
        }
    }

    /// <summary>
    /// Log a debug message
    /// </summary>
    /// <param name="text">Message</param>
    public void Debug(string text)
    {
        WriteFormattedLog( LogLevel.DEBUG, text );
    }

    /// <summary>
    /// Log an error message
    /// </summary>
    /// <param name="text">Message</param>
    public void Error(string text)
    {
        WriteFormattedLog( LogLevel.ERROR, text );
        _errorCount++;
    }

    /// <summary>
    /// Log a fatal error message
    /// </summary>
    /// <param name="text">Message</param>
    public void Fatal(string text)
    {
        WriteFormattedLog( LogLevel.FATAL, text );
        _failureCount++;
    }

    /// <summary>
    /// Log an info message
    /// </summary>
    /// <param name="text">Message</param>
    public void Info(string text)
    {
        WriteFormattedLog( LogLevel.INFO, text );
    }

    /// <summary>
    /// Log a trace message
    /// </summary>
    /// <param name="text">Message</param>
    public void Trace(string text)
    {
        WriteFormattedLog( LogLevel.TRACE, text );
    }

    /// <summary>
    /// Log a waning message
    /// </summary>
    /// <param name="text">Message</param>
    public void Warning(string text)
    {
        WriteFormattedLog( LogLevel.WARNING, text );
        _warningCount++;
    }

    public void Report(string text = "")
    {
        WriteFormattedLog( LogLevel.BRIEF_REPORT, text );
    }

    /// <summary>
    /// Format a log message based on log level
    /// </summary>
    /// <param name="level">Log level</param>
    /// <param name="text">Log message</param>
    private void WriteFormattedLog(LogLevel level, string text)
    {
        string pretext = string.Empty;

        switch (level)
        {
            case LogLevel.TRACE:
                pretext = DateTime.Now.ToString( _datetimeFormat ) + _strngLevels[(int) LogLevel.TRACE];
                break;
            case LogLevel.INFO:
                pretext = DateTime.Now.ToString( _datetimeFormat ) + _strngLevels[(int) LogLevel.INFO];
                break;
            case LogLevel.DEBUG:
                pretext = DateTime.Now.ToString( _datetimeFormat ) + _strngLevels[(int) LogLevel.DEBUG];
                break;
            case LogLevel.WARNING:
                pretext = DateTime.Now.ToString( _datetimeFormat ) + _strngLevels[(int) LogLevel.WARNING];
                break;
            case LogLevel.ERROR:
                pretext = DateTime.Now.ToString( _datetimeFormat ) + _strngLevels[(int) LogLevel.ERROR];
                break;
            case LogLevel.FATAL:
                pretext = DateTime.Now.ToString( _datetimeFormat ) + _strngLevels[(int) LogLevel.FATAL];
                break;
            case LogLevel.BRIEF_REPORT:
                pretext = DateTime.Now.ToString( _datetimeFormat ) + _strngLevels[(int) LogLevel.BRIEF_REPORT];
                break;

            default:
                pretext = string.Empty;
                break;
        }
        WriteLine( pretext + text );
    }

    /// <summary>
    /// Write a line of formatted log message into a log file
    /// </summary>
    /// <param name="text">Formatted log message</param>
    /// <param name="append">True to append, False to overwrite the file</param>
    /// <exception cref="System.IO.IOException"></exception>
    private void WriteLine(string text, bool append = true)
    {
        try
        {
            using (StreamWriter Writer = new StreamWriter( _logFileName, append, Encoding.UTF8 ))
            {
                if (text != "")
                    Writer.WriteLine( text );
            }
        }
        catch
        {
            throw;
        }
    }

    /// <summary>
    /// Returns the total errors logged.
    /// </summary>
    public int TotalErrors
    {
        get { return _errorCount; }
    }

    /// <summary>
    /// Returns the total Fatal Errors encountered
    /// </summary>
    public int TotalFatalErrors
    {
        get { return _failureCount; }
    }

    /// <summary>
    /// Returns the total number of warnings issued
    /// </summary>
    public int TotalWarnings
    {
        get { return _warningCount; }
    }


    public int TotalLines
    {
        get { return _writtenLoglines; }
    }

    public int Logtype
    {
        get { return _logType; }
        set { _logType = value; }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ColintoLine
{
    private string _singleLine;
    private string[] _multiLine;
    private int _totalLines;
    private List<string> _tempList;
    private bool _isLineSingle;


    /// <summary>
    /// Class constructor
    /// </summary>
    public ColintoLine()
    {
        _singleLine = string.Empty;
        _totalLines = 0;
        _tempList = new List<string>();
    }

    /// <summary>
    /// Convert a multi line to a single line of text
    /// </summary>
    public void ConvertLinesToSingle()
    {
        if (_tempList == null)
            _tempList = new List<string>();

        _tempList.Clear();

        _totalLines = 0;
        foreach (var s in _multiLine)
        {
            if (string.IsNullOrEmpty( s ) == false)
            {
                _tempList.Add( s );
                _totalLines++;
            }

        }
        _multiLine = _tempList.ToArray();

        _singleLine = string.Join( " ", _multiLine );
        _isLineSingle = true;

    }

    public void ConvertSingleLinetoMultiple()
    {
        if (_singleLine != string.Empty)
        {
            _multiLine = _singleLine.Split( ' ' );
            _isLineSingle = false;
        }
    }

    /// <summary>
    /// Accesor for the single line
    /// </summary>
    public string singleLine
    {
        get { return _singleLine; }
        set { _singleLine = value; }
    }

    /// <summary>
    /// Accesor for the multiline value
    /// </summary>
    public string[] multiLines
    {
        set { _multiLine = value; }
        get { return _multiLine; }
    }

    /// <summary>
    /// Total amount of lines
    /// </summary>
    public int totalLines
    {
        get { return _totalLines; }
    }

    /// <summary>
    /// Checks if the line to convert is single line or not
    /// </summary>
    public bool isLineSingle
    {
        get { return _isLineSingle; }
    }
}


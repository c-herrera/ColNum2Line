using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Col2Line
{
    class Col2Line
    {
        private string _theLine;
        private string[] _theLines;
        private int _totalLines;

        /// <summary>
        /// Class constructor
        /// </summary>
        public Col2Line()
        {
            _theLine = string.Empty;
            _totalLines = 0;
        }

        /// <summary>
        /// Convert a multi line to a single line of text
        /// </summary>
        public void ConvertLinesToSingle()
        {
            var temp = new List<string>();
            temp.Clear();
            _totalLines = 0;
            foreach (var s in _theLines)
            {
                if (string.IsNullOrEmpty(s) == false)
                {
                    temp.Add(s);
                    _totalLines++;
                }
                    
            }
            _theLines = temp.ToArray();

            _theLine = string.Join( " ", _theLines );
        }

        /// <summary>
        /// Accesor for the single line, read only
        /// </summary>
        public string singleLine
        {
            get { return _theLine; }
        }

        /// <summary>
        /// Accesor for the multiline value, write only
        /// </summary>
        public string [] multiLines
        {
            set { _theLines = value; }
        }

        /// <summary>
        /// Total amount of lines
        /// </summary>
        public int totalLines
        {
            get { return _totalLines; }
        }

    }
}

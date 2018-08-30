using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class About
{
    private readonly string _theText;

    public About()
    {
        _theText = " MultiLine 2 line : " + Environment.NewLine +
            "Tool developed to convert single lines to multiple lines and viceversa" + Environment.NewLine +
            "Developed by C. Herrera. ";
    }

    public string TheText => _theText;
}


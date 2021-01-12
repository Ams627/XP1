using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Threading.Tasks;

namespace XP1
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var doc = XDocument.Parse("<Root><a><b>Fred</b></a></Root>");
                var v = doc.XPathSelectElement("//Root/a/b").Value;
                Console.WriteLine(v);
            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine($"{progname} Error: {ex.Message}");
            }

        }
    }
}

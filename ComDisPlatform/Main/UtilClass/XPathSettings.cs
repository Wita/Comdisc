using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProcess.UtilClass
{
    class XPathSettings
    {
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        private string rules;

        public string Rules
        {
            get { return rules; }
            set { rules = value; }
        }
    }
}

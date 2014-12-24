using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProcess.UtilClass
{
    class LxmlSettings
    {
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        private string remove_tags;

        public string Remove_tags
        {
            get { return remove_tags; }
            set { remove_tags = value; }
        }
        private string kill_tags;

        public string Kill_tags
        {
            get { return kill_tags; }
            set { kill_tags = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProcess.UtilClass
{
    class SegmentSettings
    {
        private string url_get_base;

        public string Url_get_base
        {
            get { return url_get_base; }
            set { url_get_base = value; }
        }
        private string api_key;

        public string Api_key
        {
            get { return api_key; }
            set { api_key = value; }
        }
        private string format;

        public string Format
        {
            get { return format; }
            set { format = value; }
        }
        private string pattern;

        public string Pattern
        {
            get { return pattern; }
            set { pattern = value; }
        }
        private string xml_input;

        public string Xml_input
        {
            get { return xml_input; }
            set { xml_input = value; }
        }
        private string has_key;

        public string Has_key
        {
            get { return has_key; }
            set { has_key = value; }
        }
        private string only_ner;

        public string Only_ner
        {
            get { return only_ner; }
            set { only_ner = value; }
        }
        private string callback;

        public string Callback
        {
            get { return callback; }
            set { callback = value; }
        }
        private string filterFileName;

        public string FilterFileName
        {
            get { return filterFileName; }
            set { filterFileName = value; }
        }
        private string savePath;

        public string SavePath
        {
            get { return savePath; }
            set { savePath = value; }
        }
        private string sourcePath;

        public string SourcePath
        {
            get { return sourcePath; }
            set { sourcePath = value; }
        }
    }
}

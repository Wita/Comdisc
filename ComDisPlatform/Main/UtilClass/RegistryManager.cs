using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using MainProcess.FuncAreaWindow;

namespace MainProcess.UtilClass
{
    class RegistryManager
    {
        public static readonly string subKey = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment";
        private static CDMessageBox mbox = new CDMessageBox();
        public static string ReadPath()
        {
            string path = "";
            string keyName = "path";

            RegistryKey baseRegistryKey = Registry.LocalMachine;
            RegistryKey handle = baseRegistryKey.OpenSubKey(subKey);
            if (handle != null)
            {
                path = handle.GetValue(keyName.ToUpper()).ToString();
            }
            return path;
        }

        public static bool IsProcPathExist()
        {
            string keyWords = System.Environment.CurrentDirectory;
            List<string> pathList = ReadPath().Split(';').ToList();
            bool isContains = false;

            foreach (string path in pathList)
            {
                if (path.Contains(keyWords))
                {
                    isContains = true;
                    break;
                }
            }
            return isContains;
        }

        public static void SetProcPath()
        {
            if (IsProcPathExist())
            {
                return;
            }
            RegistryKey baseRegistryKey = Registry.LocalMachine;
            string newPath = System.Environment.CurrentDirectory + ";" + ReadPath();
            try
            {
                RegistryKey handle = baseRegistryKey.OpenSubKey(subKey, true);
                handle.SetValue("Path", newPath);
            }
            catch (Exception)
            {
                mbox.Show("请关闭程序后重新以管理员身份运行！");
            }
        }
    }
}

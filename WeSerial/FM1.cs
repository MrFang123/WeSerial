using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeSerial
{
    class FM1
    {
        private static StreamReader _rstream = null;
        private static StreamWriter _wstream = null;
        public static void WriteLstToTxt(ArrayList lst, string spath) //listbox 写入
        {
            int count = lst.Count;
            _wstream = new StreamWriter(spath);
            for (int i = 0; i < count; i++)
            {
                string data = lst[i].ToString();
                _wstream.Write(data);
                _wstream.WriteLine();
            }
            _wstream.Flush();
            _wstream.Close();
        }

        public static void WriteLstToTxt(ListBox lst, string spath) //listbox 写入
        {
            int count = lst.Items.Count;
            _wstream = new StreamWriter(spath);
            for (int i = 0; i < count; i++)
            {
                string data = lst.Items[i].ToString();
                _wstream.Write(data);
                _wstream.WriteLine();
            }
            _wstream.Flush();
            _wstream.Close();
        }

        public static ArrayList ReadTxtToLst(string spath) //listbox 读取
        {
            ArrayList lst = new ArrayList();
            _rstream = new StreamReader(spath, System.Text.Encoding.Default);
            string line;
            while ((line = _rstream.ReadLine()) != null)
            {
                lst.Add(line);
            }
            _rstream.Close();
            return lst;
        }
    }
}
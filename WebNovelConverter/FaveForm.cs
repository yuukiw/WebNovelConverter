using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebNovelConverter
{
    public partial class FaveForm : Form
    {

        string mdir = Application.StartupPath + "\\";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
    string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                         string key, string def, StringBuilder retVal,
                    int size, string filePath);


        public void IniWriteValue(string Section, string Key, string Value, string Path)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }


        /// <summary>
        /// Read Data Value From the Ini File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// <PARAM name="Key"></PARAM>
        /// <PARAM name="Path"></PARAM>
        /// <returns></returns>
        public string IniReadValue(string Section, string Key, string Path)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp,
                                            255, Path);
            return temp.ToString();

        }


        public FaveForm()
        {
            InitializeComponent();
 GetKeys(mdir + "Faves.ini", "Favorites");
       }


        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpszReturnBuffer, int nSize, string lpFileName);

        private List<string> GetKeys(string iniFile, string category)
        {

            byte[] buffer = new byte[2048];

            GetPrivateProfileSection(category, buffer, 2048, iniFile);
            String[] tmp = Encoding.ASCII.GetString(buffer).Trim('\0').Split('\0');

            List<string> result = new List<string>();

            foreach (String entry in tmp)
            {
                result.Add(entry.Substring(0, entry.IndexOf("=")));
                listBox1.Items.Add(entry.Substring(0, entry.IndexOf("=")));

            }

            return result;
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ret_Click(object sender, EventArgs e)
        {
            string mtext = listBox1.Text;
            MainForm.Faveurl = IniReadValue("Favorites", mtext, mdir + "Faves.ini");
            Close();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            string mtext = listBox1.Text;
            IniWriteValue("Favorites", mtext, null, mdir + "Faves.ini");
            listBox1.Items.Remove(mtext);
        }
    }
}

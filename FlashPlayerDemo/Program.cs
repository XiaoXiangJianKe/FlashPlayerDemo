using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace FlashPlayerDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] str)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            string fileName = null;
            if (str.Length > 0 && str.Length < 2)
            {
                fileName = str[0];
                form1.SetFlashMovie(fileName);
            }
            else if (str.Length > 1)
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                {
                    stringBuilder.Append(str[i]);
                    if (i < str.Length - 1)
                    {
                        stringBuilder.Append(" ");
                    }
                }
                fileName = stringBuilder.ToString();
                form1.SetFlashMovie(fileName);
            }
            Application.Run(form1);
        }
    }
}

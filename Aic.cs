using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIC_ERROR_Analysis
{
    static class Aic
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// 打开文件浏览对话框，返回选择的文本路径
        /// </summary>
        /// <returns>返回选择的文件路径</returns>
        public static string openFileFunction()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath + @"\File\Images";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "请选择AIC_ERROR数据记录文件";
            openFileDialog1.DefaultExt = "*.csv";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "CSV files(*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    return openFileDialog1.FileName;
                }
                catch (Exception err)
                {
                    MessageBox.Show("文件错误，请重试!" + err.Message);
                    return "";
                }
            }
            else
                return "";

        }
    }
}

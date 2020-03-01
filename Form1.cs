using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIC_ERROR_Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string databasePath = Application.StartupPath + @"\aic_error.csv";  //文件路径


        bool isValidHex(ref string hex)
        {
            if (hex.Length > 2)
            {
                if (hex[0] == '0' && (hex[1] == 'x' || hex[1] == 'X'))
                {
                  hex = hex.Substring(2);
                }

            }
            if (hex.Length > 16 || hex.Length < 1)
            {
                return false;
            }
            const string PATTERN = @"([^A-Fa-f0-9]|\s+?)+";
            return !(System.Text.RegularExpressions.Regex.IsMatch(hex, PATTERN));
        }

        string splitBin(string hex)
        {
            return System.Text.RegularExpressions.Regex.Replace(hex, @"(\d{4}(?!$))", "$1 ");
        }

        private void analisys_button_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(databasePath))
            {
                databasePath = Aic.openFileFunction();
                if (databasePath == "")
                {
                    MessageBox.Show("Database file open error!");
                    res.Text = "Database file open error!";
                    return;
                }
            }

            String csvStr = "";
            if (databasePath != "")
            {
                try
                {
                    csvStr = System.IO.File.ReadAllText(databasePath, Encoding.Default);
                }
                catch (Exception err)
                {
                    MessageBox.Show("AIC ERROR Database Path Read Error!\n" + err.Message + "\n" + databasePath);
                    res.Text = "AIC ERROR Database Read Error!";
                    return;
                }
            }

            Dictionary<int, string> errDict = new Dictionary<int, string>();
            string[] strLine = csvStr.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            strLine = strLine.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            for (int i = 1; i < strLine.Length; i++)
            {
                string tempLine = strLine[i];
                string[] str = new string[3];
                bool isValidLine = true;
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        str[j] = tempLine;
                        break;
                    }
                    int corIndex = tempLine.IndexOf(',');
                    if (corIndex == -1 && j < 2)
                    {
                        MessageBox.Show("AIC ERROR Database was damaged!");
                        res.Text = "AIC ERROR Database Parse failed!";
                        return;
                    }
                    str[j] = tempLine.Substring(0, corIndex);
                    if (j == 0 && !System.Text.RegularExpressions.Regex.IsMatch(str[j], @"^\d+$"))
                    {
                        isValidLine = false;
                        break;
                    }
                    tempLine = tempLine.Substring(corIndex + 1);
                }
                if (!isValidLine)
                {
                    continue;
                }
                try
                {
                    errDict.Add(int.Parse(str[0]), str[1] + " : " + str[2]);
                }
                catch (Exception err)
                {
                    MessageBox.Show("AIC ERROR Database maybe damaged: " + err.Message);
                    res.Text = "AIC ERROR Database Parse failed!";
                    return;
                }
            }

            string aicErrorCode = aic_error.Text.Trim();
            if (!isValidHex(ref aicErrorCode))
            {
                res.Text = "Invalid AIC Error Code!";
                return;
            }

            UInt64 errCode = UInt64.Parse(aicErrorCode, System.Globalization.NumberStyles.HexNumber);
            string strBin = Convert.ToString((long)errCode, 2);
            string tempZero = "";
            for (int i = 0; i < 64 - strBin.Length; i++)
            {
                tempZero += "0";
            }
            strBin = tempZero + strBin;

            res_bin1.Text = splitBin(strBin.Substring(0, 32));
            res_bin2.Text = splitBin(strBin.Substring(32, 32));

            List<int> errList = new List<int>();
            for (int i = 0; i < strBin.Length; i++)
            {
                if (strBin[i] == '1')
                {
                    errList.Add(63 - i);
                }
            }
            if (errList.Count == 0)
            {
                errList.Add(0);
            }
            string errTips = "";
            foreach (int i in errList)
            {
                if (i > errDict.Count())
                {
                    res.Text = "Can not recognize the error code, or AIC Error database is not valid!";
                    return;
                }
                errTips += i.ToString() + ": " + errDict[i] + "\r\n\r\n";
            }
            res.Text = "Default csv file path: " + databasePath + "\r\nAIC Error Decode Result:" + "\r\n\r\n" + errTips;
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            string hexStr = hex_txt.Text.Trim();
            if (!isValidHex(ref hexStr) || hexStr.Length % 4 != 0)
            {
                fp16_res.Text = "Invalid hex!";
                return;
            }

            UInt64 hex = UInt64.Parse(hexStr, System.Globalization.NumberStyles.HexNumber);
            SystemHalf.Half half = new SystemHalf.Half(hex);
            fp16_res.Text = half.ToString();
        }
    }
}

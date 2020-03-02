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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string databasePath = Application.StartupPath + @"\aic_error.csv";  //文件路径


        bool isValidHex(ref string hex, int minLen = 1, int maxLen = 65504)
        {
            hex = System.Text.RegularExpressions.Regex.Replace(hex.ToLower(), "0x", "");
            char[] all_whitespaces = new char[] {
                   // SpaceSeparator category
                   '\u0020', '\u1680', '\u180E', '\u2000', '\u2001', '\u2002', '\u2003',
                   '\u2004', '\u2005', '\u2006', '\u2007', '\u2008', '\u2009', '\u200A',
                   '\u202F', '\u205F', '\u3000',
                   // LineSeparator category
                   '\u2028',
                   // ParagraphSeparator category
                   '\u2029',
                   // Latin1 characters
                   '\u0009', '\u000A', '\u000B', '\u000C', '\u000D', '\u0085', '\u00A0',
                   // ZERO WIDTH SPACE (U+200B) & ZERO WIDTH NO-BREAK SPACE (U+FEFF)
                   '\u200B', '\uFEFF'};
            hex = hex.Trim(all_whitespaces);
            byte[] array = System.Text.Encoding.ASCII.GetBytes(hex);  //数组array为对应的ASCII数组     
            string tmpStr = null;
            for (int i = 0; i < array.Length; i++)
            {
                int asciiCode = (int)(array[i]);
                if (asciiCode == 63)
                {
                    continue;
                }
                tmpStr += hex[i];
            }
            hex = tmpStr;
            if (hex.Length > maxLen || hex.Length < minLen)
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
            if (!isValidHex(ref aicErrorCode, 1, 16))
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
            res.Text = "Default csv name is aic_error.csv, file path: " + databasePath + "\r\nAIC Error Decode Result:" + "\r\n\r\n" + errTips;
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            string hexStr = hex_txt.Text.Trim();
            if (!isValidHex(ref hexStr) || hexStr.Length % 4 != 0)
            {
                convert_res.Text = "Invalid hex!";
                return;
            }

            string halfStr = "";
            for (int i = 0; i < hexStr.Length; i += 4)
            {
                string tmpStr = hexStr.Substring(i, 4);
                UInt16 hex = UInt16.Parse(tmpStr, System.Globalization.NumberStyles.HexNumber);
                byte[] halfBytes = BitConverter.GetBytes(hex);
                SystemHalf.Half half = SystemHalf.Half.ToHalf(hex);
                halfStr += half.ToString() + "\r\n";
            }

            convert_res.Text = halfStr;
        }

        private void tofp32_button_Click(object sender, EventArgs e)
        {
            string hexStr = hex_txt.Text.Trim();
            if (!isValidHex(ref hexStr) || hexStr.Length % 8 != 0)
            {
                convert_res.Text = "Invalid hex!";
                return;
            }

            string fp32Str = "";
            for (int i = 0; i < hexStr.Length; i += 8)
            {
                string tmpStr = hexStr.Substring(i, 8);
                UInt32 hex = UInt32.Parse(tmpStr, System.Globalization.NumberStyles.HexNumber);
                byte[] bytes = BitConverter.GetBytes(hex);
                if (BitConverter.IsLittleEndian)
                {
                    bytes = bytes.Reverse().ToArray();
                }
                float myFloat = BitConverter.ToSingle(bytes, 0);
                fp32Str += myFloat.ToString() + "\r\n";
            }

            convert_res.Text = fp32Str;
        }

        private void UpperBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UpperBox.Checked)
            {
                hex_txt.CharacterCasing = CharacterCasing.Upper;
                aic_error.CharacterCasing = CharacterCasing.Upper;
            }
            else
            {
                hex_txt.CharacterCasing = CharacterCasing.Lower;
                aic_error.CharacterCasing = CharacterCasing.Lower;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadFile(AppDomain.CurrentDomain.BaseDirectory + "book1.txt");
        }

        private void btnFindNumber_Click(object sender, EventArgs e)
        {
            lblResultNumber.Text = FindNumber().ToString();
        }

        private void btnShowName_Click(object sender, EventArgs e)
        {
            rtbResult.Text = GetAllPoemName();
        }

        private void btnShowContent_Click(object sender, EventArgs e)
        {

            rtbResult.Text = GetPoemContent();
        }

        // Tìm số thứ 42 có tổng các chữ số bằng 42
        private long FindNumber()
        {
            // Số có tổng các chữ số = 42 bé nhất là số có ít chữ số nhất: 69999
            // Số có tổng các chữ số = 42 lớn nhất là số có nhiều chữ số nhất: 42 chữ số 1
            try
            {
                long min = FindMinNumber(42);
                long resultNumber = 0;
                int index = 1;
                while (index <= 42)
                {
                    char[] lstCharNumber = min.ToString().ToCharArray();
                    int sum = 0;
                    foreach (var charNumber in lstCharNumber)
                    {
                        sum += int.Parse(charNumber.ToString());
                    }
                    if (sum == 42)
                    {
                        resultNumber = min;
                        index++;
                    }
                    min++;
                }
                return resultNumber;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        // Tìm số bé nhất có tổng bằng 42: là số 69999
        private long FindMinNumber(long sumNumber)
        {
            try
            {
                long tempNumber = 9;
                while (true)
                {
                    int sum = 0;
                    char[] lstCharNumber = tempNumber.ToString().ToCharArray();
                    foreach (var charNumber in lstCharNumber)
                    {
                        sum += int.Parse(charNumber.ToString());
                    }
                    if (sum > sumNumber)
                    {
                        long resultNumber = long.Parse((9 - (sum - sumNumber)).ToString() + tempNumber.ToString().Substring(1, tempNumber.ToString().Length - 1));
                        tempNumber = resultNumber;
                        break;
                    }
                    tempNumber = long.Parse("9" + tempNumber.ToString());
                }
                return tempNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        // Đổ dữ liệu từ file text lên richTextBox
        private void ReadFile(string file)
        {
            try
            {
                StreamReader reader = new StreamReader(file, Encoding.UTF8);
                richTextBox.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Lấy toàn bộ tên bài thơ
        private string GetAllPoemName()
        {
            try
            {
                string strAllName = "";
                string pattern_1 = @"^[A-ZẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴ]";
                IEnumerable<string> lstLine = richTextBox.Lines.Where(
                                                    t => t.ToString() == t.ToUpper()
                                                    && t.Trim() != string.Empty
                                                    && Regex.IsMatch(t, pattern_1)
                                              );
                foreach (string item in lstLine)
                {
                    strAllName += item.Trim() + "\n";
                }
                return strAllName.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return string.Empty;
            }
        }

        // Lấy nội dung bài thơ từ tên bài
        private string GetPoemContent()
        {
            try
            {
                // Lấy danh sách tên bài thơ
                RichTextBox richtext = new RichTextBox { Text = GetAllPoemName() };
                IEnumerable<string> lstPoemName = richtext.Lines;

                // Lấy thứ tự của tên bài thơ sau tên bài nhập vào
                string strInput = txtName.Text.Trim().ToUpper();
                int indexInput = lstPoemName.ToList().IndexOf(strInput);
                string poemNameNext = "";
                string[] lstLine = richTextBox.Lines;
                int firstIndex = lstLine.ToList().IndexOf(lstLine.Where(t => t.StartsWith(strInput)).FirstOrDefault());
                int lastIndex = 0;
                if (indexInput < lstPoemName.Count() - 1)
                {
                    poemNameNext = lstPoemName.ElementAt(indexInput + 1);
                    lastIndex = lstLine.ToList().IndexOf(lstLine.Where(t => t.StartsWith(poemNameNext)).FirstOrDefault());
                }
                else
                {
                    lastIndex = lstLine.Count();
                }

                // Lấy đoạn văn bản theo chỉ số dòng đầu và cuối
                string result = "";
                for (int u = firstIndex + 1; u < lastIndex; u++)
                {
                    result += lstLine[u] + "\n";
                }
                return result.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return string.Empty;
            }
        }

    }
}

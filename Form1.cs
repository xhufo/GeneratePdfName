using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
/*-----------------------------------------*/
// 2017-07-14 18:18:23 upper the first letter in author,journal,title name
namespace _20170713_GeneratePdfName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pdfName.Text = year.Text + name.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GeneratePdfName();
            //MessageBox.Show(year.Text+name.Text);
            string strTmp;
            string nameTmp;
            string journalTmp;
            string titleTmp;

            nameTmp = name.Text.ToLower(); 
            journalTmp = journal.Text.ToLower();
            titleTmp = title.Text.ToLower();

            nameTmp = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(nameTmp);
            journalTmp = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(journalTmp);
            titleTmp = GetFirstUpperStr(titleTmp);
            
            strTmp = year.Text + "-" + nameTmp + "-" + journalTmp + "-" + titleTmp;
            pdfName.Text = strTmp;

        }

        private string GetFirstUpperStr(string s)
        {
            //if (!string.IsNullOrEmpty(s))
            //{
            //    if (s.Length > 1)
            //    {
            //        return char.ToUpper(s[0]) + s.Substring(1);
            //    }
            //    return char.ToUpper(s[0]).ToString();
            //}
            //
            //str = str.Substring(0, 1).ToUpper() + str.Substring(1);
            //return null;
            bool IsNewSentense = true;
            var result = new StringBuilder(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (IsNewSentense && char.IsLetter(s[i]))
                {
                    result.Append(char.ToUpper(s[i]));
                    IsNewSentense = false;
                }
                else
                    result.Append(s[i]);

                if (s[i] == '!' || s[i] == '?' || s[i] == '.')
                {
                    IsNewSentense = true;
                }
                if (s[i] == '-' || s[i] == ' ')
                {
                    IsNewSentense = false;
                }
            }

            return result.ToString();


            //string Input = s;
            //if (String.IsNullOrEmpty(Input))
            //    return Input;

            //if (Input.Length == 1)
            //    return Input.ToUpper();


            //Input = Regex.Replace(Input, @"\s+", " ");

            //Input = Input.Trim().ToLower();
            //Input = Char.ToUpper(Input[0]) + Input.Substring(1);


            //var objDelimiters = new string[] { ". ", "! ", "? " };
            //foreach (var objDelimiter in objDelimiters)
            //{
            //    var varDelimiterLength = objDelimiter.Length;

            //    var varIndexStart = Input.IndexOf(objDelimiter, 0);
            //    while (varIndexStart > -1)
            //    {
            //        Input = Input.Substring(0, varIndexStart + varDelimiterLength) + (Input[varIndexStart + varDelimiterLength]).ToString().ToUpper() + Input.Substring((varIndexStart + varDelimiterLength) + 1);

            //        varIndexStart = Input.IndexOf(objDelimiter, varIndexStart + 1);
            //    }
            //}


            //return Input;
        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void journal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

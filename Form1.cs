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
        RadioButton form;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            //pdfName.Text = year.Text + name.Text;
            /* default setting */
            //form.Text = "Geophysics";
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
            //string strTmp;
            //string nameTmp;
            //string journalTmp;
            //string titleTmp;

            //nameTmp = name.Text.ToLower(); 
            //journalTmp = journal.Text.ToLower();
            //titleTmp = title.Text.ToLower();

            //nameTmp = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(nameTmp);
            //journalTmp = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(journalTmp);
            //titleTmp = GetFirstUpperStr(titleTmp);
            
            //strTmp = year.Text + "-" + nameTmp + "-" + journalTmp + "-" + titleTmp;
            //pdfName.Text = strTmp;

            //richTextBox2 = richTextBox1;
            string Input;
            string title,year,author;
            Input = richTextBox1.Text;
            
            if(form.Text=="Geophysics")
            {
                Match match = Regex.Match(Input, @"\”[^”]*\”");
                // find title
                title = match.Groups[0].Value;
                title = Regex.Replace(title, @"\”+", "");
                title = Regex.Replace(title, @"\.", "");
                title = Regex.Replace(title, @"[^0-9A-Za-z\s-]", "");
                richTextBox2.Text = title;
                // find year
                match = Regex.Match(Input, @"\([0-9]{4}\)");
                year = match.Groups[0].Value;
                year = Regex.Replace(year, @"\(", "");
                year = Regex.Replace(year, @"\)", "");
                // find author 
                match = Regex.Match(Input, @"(.*)(\([0-9]{4}\))");
                author = match.Groups[1].Value;
                //Console.WriteLine("%s",author);
                match = Regex.Match(author, @"(\w*)(?=\,)|(\w*)(\s)(?=and)");//(\w*)(\s)(and)
                author = match.Groups[0].Value;
                author = Regex.Replace(author, @" ", "");
                author = Regex.Replace(author, @"[^A-Za-z]", "");
                //richTextBox2.Text = "1"+match.Groups[0].Value + "2"+match.Groups[1].Value +"3"+match.Groups[2].Value;
                richTextBox2.Text = year + "-" + author + "-" + "Geophysics" + "-" + title;
            }
            else if (form.Text == "SEG meeting")
            {
                Match match = Regex.Match(Input, @"(\([0-9]{4}\)\s)(.*)(?=\.\sSEG)");
                //richTextBox2.Text = "1" + match.Groups[0].Value + "2" + match.Groups[1].Value + "3" + match.Groups[2].Value;
                // find title
                title = match.Groups[2].Value;
                title = Regex.Replace(title, @"\”+", "");
                title = Regex.Replace(title, @"\.", "");
                title = Regex.Replace(title, @"[^0-9A-Za-z\s-]", "");
                richTextBox2.Text = title;
                // find year
                match = Regex.Match(Input, @"\([0-9]{4}\)");
                year = match.Groups[0].Value;
                year = Regex.Replace(year, @"\(", "");
                year = Regex.Replace(year, @"\)", "");
                // find author 
                match = Regex.Match(Input, @"(.*)(\([0-9]{4}\))");
                author = match.Groups[1].Value;
                //Console.WriteLine("%s",author);
                match = Regex.Match(author, @"(\w*)(?=\,)|(\w*)(\s)(?=and)");//(\w*)(\s)(and)
                author = match.Groups[0].Value;
                author = Regex.Replace(author, @" ", "");
                author = Regex.Replace(author, @"[^A-Za-z]", "");

                richTextBox2.Text = year + "-" + author + "-" + "SEG" + "-" + title;
            }
            else if (form.Text == "石油地球物理勘探")
            {
                Match match = Regex.Match(Input, @"(\.\s)(.*)(?=\[J\])");
                
                // find title
                title = match.Groups[2].Value;
                //title = Regex.Replace(title, @"\”+", "");
                //title = Regex.Replace(title, @"\.", "");
                //title = Regex.Replace(title, @"[^0-9A-Za-z\s-]", "");
                //richTextBox2.Text = title;
                // find year
                match = Regex.Match(Input, @"[0-9]{4}");
                year = match.Groups[0].Value;
                year = Regex.Replace(year, @"\(", "");
                year = Regex.Replace(year, @"\)", "");
                //// find author 
                match = Regex.Match(Input, @"[\u4e00-\u9fa5]*(?=\,)");
                author = match.Groups[0].Value;
                //author = Regex.Replace(author, @" ", "");
                //author = Regex.Replace(author, @"[^A-Za-z]", "");
                //richTextBox2.Text = "1" + match.Groups[0].Value + "2" + match.Groups[1].Value + "3" + match.Groups[2].Value+author;
                richTextBox2.Text = year + "-" + author + "-" + "石油地球物理勘探" + "-" + title;
            }
            else if (form.Text == "地球物理学报")
            {
                Match match = Regex.Match(Input, @"([0-9]{4})(\.)(.*)(\.\s)");
                //richTextBox2.Text = "1" + match.Groups[0].Value + "2" + match.Groups[1].Value + "3" + match.Groups[2].Value +"4" + match.Groups[3].Value;
                // find title
                title = match.Groups[3].Value;
                //title = Regex.Replace(title, @"\”+", "");
                //title = Regex.Replace(title, @"\.", "");
                //title = Regex.Replace(title, @"[^0-9A-Za-z\s-]", "");
                //richTextBox2.Text = title;
                // find year
                match = Regex.Match(Input, @"[0-9]{4}");
                year = match.Groups[0].Value;
                year = Regex.Replace(year, @"\(", "");
                year = Regex.Replace(year, @"\)", "");
                //// find author 
                match = Regex.Match(Input, @"[\u4e00-\u9fa5]*(?=\,)");
                author = match.Groups[0].Value;
                //author = Regex.Replace(author, @" ", "");
                //author = Regex.Replace(author, @"[^A-Za-z]", "");
                //
                richTextBox2.Text = year + "-" + author + "-" + "地球物理学报" + "-" + title;
            }
            else if (form.Text == "地球物理学进展")
            {
                Match match = Regex.Match(Input, @"([0-9]{4})(\.)(.*)(\.\s)");
                //richTextBox2.Text = "1" + match.Groups[0].Value + "2" + match.Groups[1].Value + "3" + match.Groups[2].Value +"4" + match.Groups[3].Value;
                // find title
                title = match.Groups[3].Value;
                //title = Regex.Replace(title, @"\”+", "");
                //title = Regex.Replace(title, @"\.", "");
                //title = Regex.Replace(title, @"[^0-9A-Za-z\s-]", "");
                //richTextBox2.Text = title;
                // find year
                match = Regex.Match(Input, @"[0-9]{4}");
                year = match.Groups[0].Value;
                year = Regex.Replace(year, @"\(", "");
                year = Regex.Replace(year, @"\)", "");
                //// find author 
                match = Regex.Match(Input, @"[\u4e00-\u9fa5]*(?=\,)");
                author = match.Groups[0].Value;
                //author = Regex.Replace(author, @" ", "");
                //author = Regex.Replace(author, @"[^A-Za-z]", "");
                //
                richTextBox2.Text = year + "-" + author + "-" + "地球物理学进展" + "-" + title;
            }
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {
            
                //pdfName.Text = 
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) form = radioButton1;
        }
 

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) form = radioButton4;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) form = radioButton2;
        }

 
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked) form = radioButton6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked) form = radioButton7;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked) form = radioButton8;
        }
    }
}

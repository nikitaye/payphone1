using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace payphone
{
    public partial class SpeachCall : Form
    {
        public SpeachCall()
        {
            
            InitializeComponent();
        }
       // Word.Application w = new Word.Application(); //создаем COM-объект Word
       // private Word.Paragraphs wordparagraphs;
       // private Word.Paragraph wordparagraph;


        public int i = -1;
        public int j = 0;
        string[] str = System.IO.File.ReadAllLines(Environment.CurrentDirectory.ToString() + "/911.txt");
        private void AnswerClick(object sender, EventArgs e)
        {
            

            richTextBox2.Text = "";
            if(i>8)
            {
                i = -1;
            }
            i++;
            j++;
       //     w.Visible = true;
         //   wordparagraph = (Word.Paragraph)wordparagraphs;
         //   wordparagraph.Range.Text ="AAA";
            rtb_Answer.Text = str[i];
        
        }
    }
}

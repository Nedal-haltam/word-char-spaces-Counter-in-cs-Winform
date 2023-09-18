using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Project_Word_Counter_Desktop_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Number_of_spaces(string s)
        {
            return s.Split(' ').Length - 1;
        }

        private int Number_of_words(ref string[] lines)
        {

            int w = 0;
            foreach (string line in lines)
            {
                string[] l = line.Split(' ');
                foreach (string word in l)
                {
                    if (word != "" && word != " ")
                        w++;
                }
            }

            return w;
        }

        private int Number_of_char_in_textbox()
        {
            if(tbfield.Lines.Length == 0) return 0;

            if(tbfield.Lines.Length == 1) return tbfield.TextLength;

            else
                return tbfield.TextLength - 2*(tbfield.Lines.Length - 1);

        }

        private int Number_of_sentences(ref string[] lines)
        {
            int c = 0;
            foreach (string line in lines)
                if (line.Length != 0)
                    c++;
            return c;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string[] lines = tbfield.Lines;

            lblword.Text = Number_of_words(ref lines).ToString();

            lblspace.Text = Number_of_spaces(tbfield.Text).ToString();

            lblsentence.Text = Number_of_sentences(ref lines).ToString();

            lblchar.Text = Number_of_char_in_textbox().ToString();


        }
    }
}

using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            pnscrol.Height = button1.Height;
            pnscrol.Top = button1.Top;
            Form2 FR = new Form2();
            FR.Show();
            string n = textBox1.Text;
            string[] line = File.ReadAllLines(textBox1.Text);
            string[] lines = File.ReadAllLines(textBox1.Text);
            for (int i = 0; i < lines.Length; i++)
            {
                FR.textBox3.Text = lines[i];
            }
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i].StartsWith("//"))
                {
                    line[i] = " ";
                }
                if (line[i].StartsWith("/*"))
                {
                    line[i] = " ";
                }
                if (line[i].StartsWith("#define"))
                {
                    line[i] = " ";
                }
                if (line[i].EndsWith("*/"))
                {
                    line[i] = " ";
                }
            }
            for (int i = 0; i < line.Length; i++)
            {
                FR.textBox2.Text = line[i];
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            pnscrol.Height = button2.Height;
            pnscrol.Top = button2.Top;
            Token tk = new Token();
            tk.Show();
            string line = File.ReadAllText(textBox1.Text);
            char[] num = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] logic = { '{', '}', '<', '>', '=', '!' };
            char[] op = { '+', '-', '*', '/', '%', '^' };
            // Convert String File To Char Array 
            char[] token = new char[line.Length];
            token = line.ToCharArray();

            for (int j = 0; j < token.Length; j++) // NIMBER TOKEN
            {
                for (int k = 0; k < num.Length; k++)
                    if (token[j] == num[k])
                    {
                        tk.textBox1.Text = num[k].ToString();
                    }
            }

            for (int j = 0; j < token.Length; j++)// LOGIC TOKEN
            {
                for (int k = 0; k < logic.Length; k++)
                    if (token[j] == logic[k])
                    {
                        tk.textBox2.Text = logic[k].ToString();
                    }
            }

            for (int j = 0; j < token.Length; j++)// operator TOKEN
            {
                for (int k = 0; k < op.Length; k++)
                    if (token[j] == op[k])
                    {
                        tk.textBox3.Text = op[k].ToString();
                    }
            }
			/*string[] keyword = { "for", "int", "main", "include", "using", "namespace", "return", "cout", "cin", "endl", "iostream", "float" };
			string[] lines = File.ReadAllLines(textBox1.Text);

			for (int i = 0; i < line.Length; i++)
			{
				if (lines[i].Contains("for"))
				{
                    tk.textBox3.Text = lines[i].ToString();
 				}
			}
            the two commit
            */
		}
		private void button3_Click(object sender, EventArgs e)
        {
            pnscrol.Height = button3.Height;
            pnscrol.Top = button3.Top;
        }

        private void pnscrol_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}


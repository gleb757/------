using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace braces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {            
            string text = richTextBox1.Text;                        
            List<string> braces = new List<string>();
            List<int> braces_pos = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '{')
                {
                    braces.Add(text[i].ToString());
                    braces_pos.Add(i);
                }
                if (text[i] == '}')
                {
                    braces.Add(text[i].ToString());
                    braces_pos.Add(i);
                }
            }
            int length = length = braces.Count;
            int j = 0;            
            try
            {
                while (j != length)
                {
                    if (braces[j].Contains("{") == true && braces[j + 1].Contains("}") == true)
                    {
                        braces.RemoveAt(j + 1);
                        braces.RemoveAt(j);
                        braces_pos.RemoveAt(j + 1);
                        braces_pos.RemoveAt(j);
                        j = 0;
                        length = braces.Count;
                    }
                    else { j++; }

                }
            }
            catch (ArgumentOutOfRangeException)
            { }
                if (braces_pos.Count > 0)
                {
                    for (int i = 0; i < braces_pos.Count; i++)
                    {
                        richTextBox1.Select(braces_pos[i], 1);
                        richTextBox1.SelectionColor = Color.Red;
                        richTextBox1.SelectionFont= new Font("Arial",12,FontStyle.Bold);
                    }
                }
            
            
        }
    }
}

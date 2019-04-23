using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_1
{
    public partial class Form1 : Form
    {
        Brain brain;
        public Form1()
        {
            InitializeComponent();
            brain = new Brain(new MyDelegate(ChangeDisplay));
        }


        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            brain.Process(button.Text);
                if (button.Text == "C")
                {
                    textBox1.Text = "0";
                }
        }

        public void ChangeDisplay(string text)
        {
            textBox1.Text = text;
        }

        
    }
}

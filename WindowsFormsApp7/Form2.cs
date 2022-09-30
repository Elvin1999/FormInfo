using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {

        /////by constructor version 1
        //public Form2(string data)
        //{
        //    InitializeComponent();
        //    label1.Text = data; 
        //}
        public EventHandler<EventArgs> MyHandler { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        
        public string Data
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public DialogResult ShowDialog(User user)
        {
            label1.Text = $"{user.Username} - {user.Password}";
            return ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MyHandler.Invoke(sender, e);
        }
    }
}

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
    public partial class Form1 : Form
    {

        EventHandler<EventArgs> handler;
        public string Data
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }


        public Form1()
        {
            InitializeComponent();
            handler = new EventHandler<EventArgs>((o, e) =>
              {
                  label1.Text=(o as TextBox).Text;
              });

            // 2 qayda var
            // from parent to child
            // by constructor
            // by property
            // showdialog overriding
            // from child to parent

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var data = textBox1.Text;
            //Form2 form2 = new Form2(data);
            //this.Hide();
            //if (form2.ShowDialog() == DialogResult.Cancel)
            //{
            //    this.Show();
            //}

            form2.Data = textBox1.Text;

        }

       ////Form2 form2 = new Form2();
       ////private void button2_Click(object sender, EventArgs e)
       ////{
       ////    form2.Show();
       ////}



        Form2 form2 = new Form2();
        private void button2_Click(object sender, EventArgs e)
        {
            //form2.ShowDialog(new User
            //{
            //     Username="Elvin123",
            //     Password="Elvin123"
            //});
            form2.MyHandler = handler;
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data = form2.Data;
        }
    }
}

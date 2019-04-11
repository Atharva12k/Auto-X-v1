using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace GSMCommDemo
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cust.Items.Clear();

            string[] lines = File.ReadAllLines("d:\\Example.txt");
            foreach (string line in lines)
            {
                cust.Items.Add(line);
            }
        }
    }
}

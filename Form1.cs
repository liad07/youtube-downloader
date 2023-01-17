using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security;
namespace youtube_downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"video.txt" , textBox1.Text);
            if (comboBox1.Text == "mp3")
            {
                Process.Start("mp3.py");
            }
              if (comboBox1.Text == "mp4")
            {
                Process.Start("mp4.py");
            }
               if (comboBox1.Text == "both")
            {
                Process.Start("mp4.py");
                Process.Start("mp3.py");

            }

        }
    }
}

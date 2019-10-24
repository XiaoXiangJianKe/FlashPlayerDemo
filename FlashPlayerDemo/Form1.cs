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

namespace FlashPlayerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //axShockwaveFlash1.Movie = Directory.GetCurrentDirectory() + "/csq.swf";
            this.SwitchPlayer(filePath);
            this.Text = "播放的是-" + filePath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Stop();
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.SwitchPlayer(this.openFileDialog1.FileName);
                this.Text = "播放的是-" + this.openFileDialog1.FileName;
            }
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("广州超远播放器（v1.01）", "广州超远播放器");
        }

        public void SetFlashMovie(string fileName)
        {
            filePath = fileName;
        }

        public void SwitchPlayer(string fileName)
        {
            if (Path.GetExtension(fileName) == ".swf")
            {
                this.axShockwaveFlash1.Movie = fileName;
                this.axShockwaveFlash1.Visible = true;
                this.axWindowsMediaPlayer1.Visible = false;
            }
            else
            {
                this.axWindowsMediaPlayer1.URL = fileName;
                this.axShockwaveFlash1.Visible = false;
                this.axWindowsMediaPlayer1.Visible = true;
            }
        }
    }
}

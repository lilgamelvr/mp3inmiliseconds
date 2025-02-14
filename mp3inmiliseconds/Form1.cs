﻿using TagLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp3inmiliseconds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string filePath = "insert\path\here";
            InitializeComponent();

            
            double durationInMilliseconds = GetAudioFileDurationInMilliseconds(filePath);
            label1.Text = $"Duration: {durationInMilliseconds} milliseconds";

        }

        static double GetAudioFileDurationInMilliseconds(string filePath)
        {
            var file = TagLib.File.Create(filePath);
            return file.Properties.Duration.TotalMilliseconds;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

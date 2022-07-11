using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Launch_Epic_Games_with_Steam
{
    public partial class ImageViewer : Form
    {
        Image[] images = new Image[5];
        public bool inTutorial = true;
        public ImageViewer()
        {
            InitializeComponent();
        }

        public void SetTutorialImage(int number = 0)
        {
            if (number == 0) return;

            switch (number)
            {
                case 1: pictureBox1.Image = Properties.Resources._1_; break;
                case 2: pictureBox1.Image = Properties.Resources._2_; break;
                case 3: pictureBox1.Image = Properties.Resources._3_; break;
                case 4: pictureBox1.Image = Properties.Resources._4_; break;
                case 5: pictureBox1.Image = Properties.Resources._5_; break;
            }

            pictureBox1.Update();
        }       
    }
}

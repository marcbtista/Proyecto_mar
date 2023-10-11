using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formas
{
    public partial class FormaVideo : Form
    {
        public FormaVideo()
        {
            InitializeComponent();
        }

        private void menuVideo01_Click(object sender, EventArgs e)
        {
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {


        }

        private void FormaVideo_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\ximena\video.mp4";
        }
    }
}

using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\Epic\TetrisEffect\TetrisEffect.exe");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\Blizz\Overwatch\_retail_\Overwatch.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\UPlay\Tom Clancy's Rainbow Six Siege\RainbowSix_Vulkan.exe");
        }

        private void AddLibraryButton_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\SteamLibrary\steamapps\common\rocketleague\Binaries\Win64\RocketLeague.exe");
        }
    }
}
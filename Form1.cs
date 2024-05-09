using System.Diagnostics;

namespace CreateVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string audioPath = txtFolderPath.Text + "\\music.mp3";
            string command = $"ffmpeg -framerate 1/3 -pattern_type glob -i \"" + txtFolderPath.Text + "\\%d.jpg\" -i \"" + audioPath + "\" -c:v libx264 -r 30 -pix_fmt yuv420p \"" + txtFolderPath.Text + "\"";
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process pr = Process.Start(psi);
            pr.StandardInput.WriteLine(command);
            pr.StandardInput.Flush();
            pr.StandardInput.Close();
            pr.WaitForExit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    txtFolderPath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
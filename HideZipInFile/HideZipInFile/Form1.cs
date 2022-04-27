using System.Diagnostics;

namespace HideZipInFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ChooseZipLabel.Location = new Point(((Size.Width / 4) - ChooseZipLabel.Width / 2), ((Size.Height / 10) * 3) - ChooseZipLabel.Size.Height / 2);
            fileHideInLabel.Location = new Point((((Size.Width / 4) * 3) - fileHideInLabel.Width / 2), ((Size.Height / 10) * 3) - fileHideInLabel.Size.Height / 2);
            MinimumSize = new Size(ChooseZipLabel.Width + fileHideInLabel.Width, Math.Max(ChooseZipLabel.Height, fileHideInLabel.Height)+100);
        }

        private void ChooseZipLabel_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "archives (*.zip)|*.zip|Winrar Archive (*.rar)|*.rar|7 Zip archive (*.7zip)|*.7zip|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 5;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                }
            }

            if (filePath != null)
            {
                ChooseZipLabel.ForeColor = Color.Green;
            }
        }
        private void fileHideInLabel_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                }
            }

            if (filePath != null)
            {
                fileHideInLabel.ForeColor = Color.Green;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Debug.WriteLine(Size);
            ChooseZipLabel.Location = new Point(((Size.Width / 4)- ChooseZipLabel.Width/2), ((Size.Height / 10)*3)-ChooseZipLabel.Size.Height/2);
            fileHideInLabel.Location = new Point((((Size.Width / 4)*3)- fileHideInLabel.Width/2), ((Size.Height / 10)*3)-fileHideInLabel.Size.Height/2);
        }
    }
}
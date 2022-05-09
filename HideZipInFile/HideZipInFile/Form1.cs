using System.Diagnostics;
using WindowsInput;
using WindowsInput.Native;

namespace HideZipInFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        private void Form1_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if ((file[^4..] == ".zip"))
                {
                    HideFilePath = file;
                }
                else if ((file[^4..] == ".jpg") || (file[^4..] == ".png"))
                {
                    PathToHideIn = file;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChooseZipLabel.Location = new Point(((Size.Width / 4) - ChooseZipLabel.Width / 2), ((Size.Height / 10) * 3) - ChooseZipLabel.Size.Height / 2);
            fileHideInLabel.Location = new Point((((Size.Width / 4) * 3) - fileHideInLabel.Width / 2), ((Size.Height / 10) * 3) - fileHideInLabel.Size.Height / 2);
            CombineButton.Location = new Point(((Size.Width / 2)) - CombineButton.Width / 2, (Size.Height / 10) * 6 - CombineButton.Height / 2);
            MinimumSize = new Size(ChooseZipLabel.Width + fileHideInLabel.Width, Math.Max(ChooseZipLabel.Height, fileHideInLabel.Height) + CombineButton.Height + 100);
            if (PathToHideIn != "")
            {
                fileHideInLabel.ForeColor = Color.Green;
                var splittet = PathToHideIn.Split(@"\");
                fileHideInLabel.Text = splittet[splittet.Count() - 1];
            }

            if (HideFilePath != "")
            {
                ChooseZipLabel.ForeColor = Color.Green;
                var splittet = HideFilePath.Split(@"\");
                ChooseZipLabel.Text = splittet[splittet.Count() - 1];
            }
        }
        string pathToHideIn = @"";
        string PathToHideIn
        {
            get {
                return pathToHideIn;
            }
            set
            {
                pathToHideIn = value;
                fileHideInLabel.Text = pathToHideIn;
                fileHideInLabel.ForeColor = Color.Green;
                var splittet = PathToHideIn.Split(@"\");
                fileHideInLabel.Text = splittet[splittet.Count() - 1];
            }
        }
        string hideFilePath = @"";
        string HideFilePath { get { return hideFilePath; }
        set
        {
                hideFilePath = value;
                fileHideInLabel.Text = hideFilePath;
                ChooseZipLabel.ForeColor = Color.Green;
                var splittet = HideFilePath.Split(@"\");
                ChooseZipLabel.Text = splittet[splittet.Count() - 1];
            }
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

            if (filePath != "")
            {
                HideFilePath = filePath;
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
            if (filePath != "")
            {
                PathToHideIn = filePath;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Debug.WriteLine(Size);
            CombineButton.Location = new Point(((Size.Width / 2)) - CombineButton.Width / 2, (Size.Height / 10) * 6 - CombineButton.Height / 2);
            ChooseZipLabel.Location = new Point(((Size.Width / 4) - ChooseZipLabel.Width / 2), ((Size.Height / 10) * 3) - ChooseZipLabel.Size.Height / 2);
            fileHideInLabel.Location = new Point((((Size.Width / 4) * 3) - fileHideInLabel.Width / 2), ((Size.Height / 10) * 3) - fileHideInLabel.Size.Height / 2);
        }

        private void CombineButton_Click(object sender, EventArgs e)
        {
            if (PathToHideIn != "" && HideFilePath != "")
            {
                var simu = new InputSimulator();
                simu.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.VK_R);
                System.Threading.Thread.Sleep(250);
                simu.Keyboard.TextEntry("cmd");
                simu.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                System.Threading.Thread.Sleep(250);
                var splittet = HideFilePath.Split(@"\");
                var pfad = "";
                for (int i = 0; i < splittet.Length - 1; i++)
                {
                    pfad += splittet[i] + @"\";
                }
                simu.Keyboard.TextEntry(@"cd " + pfad);
                simu.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                var name = PathToHideIn[^5..];
                simu.Keyboard.TextEntry(@$"copy /b {PathToHideIn}+{HideFilePath} output{name}");
                simu.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            }
        }
    }
}
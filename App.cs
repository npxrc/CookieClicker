namespace GameApp
{
    public partial class App : Form
    {
        private string appDataFolder = "CookieClicker";
        private int cookieCount;

        public App()
        {
            InitializeComponent();
            cookieImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cookieImage.SendToBack();
            this.Resize += MainForm_Resize;
            try
            {
                cookieCount = int.Parse(ReadFromFile("cookies"));
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                WriteToFile("cookies", "0");
            }
            timesClicked.Text = "Cookies: " + cookieCount.ToString();
            runButton.Click += (sender, e) => IncreaseCount();
            runButton.MouseDown += (sender, e) => ScaleMoreButton(sender, e);
            runButton.MouseUp += (sender, e) => ScaleMoreButton(sender, e);
        }

        private void ScaleMoreButton(object sender, MouseEventArgs e)
        {
            Console.WriteLine(runButton.Location);
            if (runButton.Size.Width == 250)
            {
                runButton.Location = new Point(18, 64);
                runButton.Size = new Size(225, 25);
            }
            else
            {
                runButton.Location = new Point(12, 58);
                runButton.Size = new Size(250, 30);
            }
        }
        private void IncreaseCount()
        {
            cookieCount++;
            timesClicked.Text = "Cookies: " + cookieCount.ToString();
            WriteToFile("cookies", cookieCount.ToString());
        }
        private string ReadFromFile(string filename)
        {
            try
            {
                string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                string gameFolderPath = Path.Combine(localAppDataPath, appDataFolder);

                string cookiesFilePath = Path.Combine(gameFolderPath, filename);

                if (File.Exists(cookiesFilePath))
                {
                    string textFromFile = File.ReadAllText(cookiesFilePath);
                    return textFromFile;
                }
                else
                {
                    Console.Error.WriteLine("File does not exist.");
                    throw new Exception("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        private void WriteToFile(string filePath, string toWrite)
        {
            try
            {
                string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                string gameFolderPath = Path.Combine(localAppDataPath, appDataFolder);

                if (!Directory.Exists(gameFolderPath))
                {
                    Directory.CreateDirectory(gameFolderPath);
                }

                string cookiesFilePath = Path.Combine(gameFolderPath, filePath);

                string textToWrite = toWrite;
                File.WriteAllText(cookiesFilePath, textToWrite);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Adjust the position of the picture box when the form is resized
            cookieImage.Location = new Point(this.ClientSize.Width - cookieImage.Width,
                                            this.ClientSize.Height - cookieImage.Height);
        }
    }
}

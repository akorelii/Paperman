namespace Paperman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            // SAVE DIALOG
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All Files (*.*)|*.*";
            saveFileDialog.ShowDialog();

            // CREATE FILE
            File.Create(saveFileDialog.FileName).Close();
        }

        private void removeFileButton_Click(object sender, EventArgs e)
        {
            // OPEN DIALOG
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.ShowDialog();

            // REMOVE FILE
            File.Delete(openFileDialog.FileName);
        }

        private void listFilesButton_Click(object sender, EventArgs e)
        {
            // OPEN DIALOG
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.ShowDialog();
        }

        private void htmlButton_Click(object sender, EventArgs e)
        {
            // SAVE DIALOG
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All Files (*.*)|*.*";
            saveFileDialog.FileName = ".html";
            saveFileDialog.ShowDialog();

            // CREATE FILE
            File.Create(saveFileDialog.FileName).Close();
        }

        private void cssButton_Click(object sender, EventArgs e)
        {
            // SAVE DIALOG
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All Files (*.*)|*.*";
            saveFileDialog.FileName = ".css";
            saveFileDialog.ShowDialog();

            // CREATE FILE
            File.Create(saveFileDialog.FileName).Close();
        }

        private void jsButton_Click(object sender, EventArgs e)
        {
            // SAVE DIALOG
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All Files (*.*)|*.*";
            saveFileDialog.FileName = ".js";
            saveFileDialog.ShowDialog();

            // CREATE FILE
            File.Create(saveFileDialog.FileName).Close();
        }

        private void phpButton_Click(object sender, EventArgs e)
        {
            // SAVE DIALOG
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All Files (*.*)|*.*";
            saveFileDialog.FileName = ".php";
            saveFileDialog.ShowDialog();

            // CREATE FILE
            File.Create(saveFileDialog.FileName).Close();
        }
    }
}

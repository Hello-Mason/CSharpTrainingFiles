namespace FileDialogTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open Image";

            openFileDialog.Filter = "Text|.txt|PNG Image|*.png|BIK|*.bik";

            //检查是否用户确实打开了一个文件
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show(openFileDialog.FileName);//Get the full path name of the file
                MessageBox.Show(openFileDialog.SafeFileName);//Only get the file name itself
            }
        }
    }
}
using System.Windows.Forms;

namespace PKLConverter;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonOpenMGDBPath_Click(object sender, EventArgs e)
    {
        using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxMGDBOpenPath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }

    private void buttonSaveMGDBPath_Click(object sender, EventArgs e)
    {
        using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxMGDBSavePath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }

    private void buttonOpenPKLPath_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Text files (*.pkl)|*.pkl|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPKLOpenPath.Text = openFileDialog.FileName;
            }
        }
    }

    private void buttonSavePKLPath_Click(object sender, EventArgs e)
    {
        using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPKLSavePath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }



    private void buttonConvertPKL_Click(object sender, EventArgs e)
    {
        string pklType = comboBoxPKLType.Text;
        string mgdbOpenPath = textBoxMGDBOpenPath.Text;
        string mgdbSavePath = textBoxMGDBSavePath.Text;
        string pklOpenPath = textBoxPKLOpenPath.Text;
        string pklSavePath = textBoxPKLSavePath.Text;

        var Converter = new PKLConverter(mgdbOpenPath, mgdbSavePath, pklOpenPath, pklSavePath);
        Converter.ToPKL(pklType);

        MessageBox.Show("PKL打包完成！");
    }

    private void buttonConvertMGDB_Click(object sender, EventArgs e)
    {
        string pklType = comboBoxPKLType.Text;
        string mgdbOpenPath = textBoxMGDBOpenPath.Text;
        string mgdbSavePath = textBoxMGDBSavePath.Text;
        string pklOpenPath = textBoxPKLOpenPath.Text;
        string pklSavePath = textBoxPKLSavePath.Text;

        var Converter = new PKLConverter(mgdbOpenPath, mgdbSavePath, pklOpenPath, pklSavePath);
        Converter.ToMGDB(pklType);

        MessageBox.Show("MGDB解包完毕！");
    }

    private void textBoxPKLOpenPath_TextChanged(object sender, EventArgs e)
    {

    }
}


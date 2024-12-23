using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PKLConverter;

public partial class Form : System.Windows.Forms.Form
{
    public Form()
    {
        InitializeComponent();
    }

    private void buttonOpenPackWcs_Click(object sender, EventArgs e)
    {
        string wcType = comboBoxWCType.Text;
        
        // 收集当前选中wc类型
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Title = "选择文件";
            openFileDialog.Filter = $"文件类型 (*.{wcType})|*.{wcType}|All files (*.*)|*.*";
            openFileDialog.Multiselect = true; // 允许多选文件

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取所选的文件路径
                string[] filePaths = openFileDialog.FileNames;

                // 显示文件路径到文本框
                textPackWcs.Clear(); // 清空文本框
                foreach (var filePath in filePaths)
                {
                    textPackWcs.AppendText(filePath + Environment.NewLine); // 将每个路径添加到文本框
                }
            }
        }
    }

    private void buttonSaveWcsPath_Click(object sender, EventArgs e)
    {
        using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxWcsSavePath.Text = folderBrowserDialog.SelectedPath;
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

    private void textBox_DragEnter(object sender, DragEventArgs e)
    {
        // 检查拖放的内容是否为文件
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.Copy; // 设置为复制效果
        }
        else
        {
            e.Effect = DragDropEffects.None; // 禁止拖放
        }
    }

    private void textPackWcs_DragDrop(object sender, DragEventArgs e)
    {
        // 获取拖放的文件路径数组
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        if (files.Length > 0)
        {
            // 将第一个文件路径显示在文本框中
            textPackWcs.Text = files[0];
        }
    }


    private void textBoxPKLSavePath_DragDrop(object sender, DragEventArgs e)
    {
        // 获取拖放的文件路径数组
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        if (files.Length > 0)
        {
            // 将第一个文件路径显示在文本框中
            textBoxPKLSavePath.Text = files[0];
        }
    }

    private void textBoxPKLOpenPath_DragDrop(object sender, DragEventArgs e)
    {
        // 获取拖放的文件路径数组
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        if (files.Length > 0)
        {
            // 将第一个文件路径显示在文本框中
            textBoxPKLOpenPath.Text = files[0];
        }
    }

    private void textBoxWcsSavePath_DragDrop(object sender, DragEventArgs e)
    {
        // 获取拖放的文件路径数组
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        if (files.Length > 0)
        {
            // 将第一个文件路径显示在文本框中
            textBoxWcsSavePath.Text = files[0];
        }
    }

    private void buttonPKLPack_Click(object sender, EventArgs e)
    {
        string wcType = comboBoxWCType.Text;
        string [] WCOpenPaths = textPackWcs.Text.Split(Environment.NewLine).Where(x => x != "").ToArray();
        string pklSavePath = textBoxPKLSavePath.Text;

        var Converter = new PKLConverter(wcType);
        Converter.Pack(WCOpenPaths, pklSavePath);

        
    }

    private void buttonPKLUnpack_Click(object sender, EventArgs e)
    {
        string wcType = comboBoxWCType.Text;
        string pklOpenPath = textBoxPKLOpenPath.Text;
        string wcsSavePath = textBoxWcsSavePath.Text;

        var Converter = new PKLConverter(wcType);
        Converter.UnPack(pklOpenPath, wcsSavePath);

        
    }


}


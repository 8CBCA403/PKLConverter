namespace PKLConverter
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            buttonConvertPKL = new Button();
            comboBoxWCType = new ComboBox();
            buttonOpenPackWcs = new Button();
            openFileDialog1 = new OpenFileDialog();
            textPackWcs = new TextBox();
            textBoxPKLOpenPath = new TextBox();
            buttonOpenPKLPath = new Button();
            labelPackWcs = new Label();
            labelUnpackPKL = new Label();
            LabelWCType = new Label();
            buttonConvertMGDB = new Button();
            label1 = new Label();
            buttonSavePKLPath = new Button();
            textBoxPKLSavePath = new TextBox();
            label2 = new Label();
            textBoxWcsSavePath = new TextBox();
            buttonSaveWcsPath = new Button();
            tabControl1 = new TabControl();
            tabPackPKL = new TabPage();
            tabUnpackPKL = new TabPage();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPackPKL.SuspendLayout();
            tabUnpackPKL.SuspendLayout();
            SuspendLayout();
            // 
            // buttonConvertPKL
            // 
            buttonConvertPKL.Location = new Point(6, 135);
            buttonConvertPKL.Name = "buttonConvertPKL";
            buttonConvertPKL.Size = new Size(320, 75);
            buttonConvertPKL.TabIndex = 0;
            buttonConvertPKL.Text = "生成PKL";
            buttonConvertPKL.UseVisualStyleBackColor = true;
            buttonConvertPKL.Click += buttonPKLPack_Click;
            // 
            // comboBoxWCType
            // 
            comboBoxWCType.FormattingEnabled = true;
            comboBoxWCType.Items.AddRange(new object[] { "WC9", "WB8", "WA8", "WC8", "WB7", "WC7", "WC6", "PGF", "PCD" });
            comboBoxWCType.Location = new Point(12, 34);
            comboBoxWCType.Name = "comboBoxWCType";
            comboBoxWCType.Size = new Size(347, 25);
            comboBoxWCType.TabIndex = 2;
            comboBoxWCType.Text = "WC9";
            // 
            // buttonOpenPackWcs
            // 
            buttonOpenPackWcs.Location = new Point(251, 40);
            buttonOpenPackWcs.Name = "buttonOpenPackWcs";
            buttonOpenPackWcs.Size = new Size(75, 23);
            buttonOpenPackWcs.TabIndex = 3;
            buttonOpenPackWcs.Text = "选择";
            buttonOpenPackWcs.UseVisualStyleBackColor = true;
            buttonOpenPackWcs.Click += buttonOpenPackWcs_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textPackWcs
            // 
            textPackWcs.AllowDrop = true;
            textPackWcs.Location = new Point(6, 40);
            textPackWcs.Name = "textPackWcs";
            textPackWcs.Size = new Size(241, 23);
            textPackWcs.TabIndex = 4;
            textPackWcs.DragDrop += textPackWcs_DragDrop;
            textPackWcs.DragEnter += textBox_DragEnter;
            // 
            // textBoxPKLOpenPath
            // 
            textBoxPKLOpenPath.AllowDrop = true;
            textBoxPKLOpenPath.Location = new Point(6, 34);
            textBoxPKLOpenPath.Name = "textBoxPKLOpenPath";
            textBoxPKLOpenPath.Size = new Size(239, 23);
            textBoxPKLOpenPath.TabIndex = 5;
            textBoxPKLOpenPath.DragDrop += textBoxPKLOpenPath_DragDrop;
            textBoxPKLOpenPath.DragEnter += textBox_DragEnter;
            // 
            // buttonOpenPKLPath
            // 
            buttonOpenPKLPath.Location = new Point(251, 34);
            buttonOpenPKLPath.Name = "buttonOpenPKLPath";
            buttonOpenPKLPath.Size = new Size(75, 23);
            buttonOpenPKLPath.TabIndex = 6;
            buttonOpenPKLPath.Text = "选择";
            buttonOpenPKLPath.UseVisualStyleBackColor = true;
            buttonOpenPKLPath.Click += buttonOpenPKLPath_Click;
            // 
            // labelPackWcs
            // 
            labelPackWcs.AutoSize = true;
            labelPackWcs.Location = new Point(6, 15);
            labelPackWcs.Name = "labelPackWcs";
            labelPackWcs.Size = new Size(136, 17);
            labelPackWcs.TabIndex = 7;
            labelPackWcs.Text = "选择需要打包的WC文件";
            // 
            // labelUnpackPKL
            // 
            labelUnpackPKL.AutoSize = true;
            labelUnpackPKL.Location = new Point(6, 12);
            labelUnpackPKL.Name = "labelUnpackPKL";
            labelUnpackPKL.Size = new Size(113, 17);
            labelUnpackPKL.TabIndex = 8;
            labelUnpackPKL.Text = "选择需要解包的PKL";
            // 
            // LabelWCType
            // 
            LabelWCType.AutoSize = true;
            LabelWCType.Location = new Point(12, 14);
            LabelWCType.Name = "LabelWCType";
            LabelWCType.Size = new Size(160, 17);
            LabelWCType.TabIndex = 9;
            LabelWCType.Text = "选择需要处理的WC文件类型";
            // 
            // buttonConvertMGDB
            // 
            buttonConvertMGDB.Location = new Point(6, 132);
            buttonConvertMGDB.Name = "buttonConvertMGDB";
            buttonConvertMGDB.Size = new Size(320, 75);
            buttonConvertMGDB.TabIndex = 10;
            buttonConvertMGDB.Text = "解包PKL";
            buttonConvertMGDB.UseVisualStyleBackColor = true;
            buttonConvertMGDB.Click += buttonPKLUnpack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 71);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 13;
            label1.Text = "设置PKL保存路径";
            // 
            // buttonSavePKLPath
            // 
            buttonSavePKLPath.Location = new Point(251, 93);
            buttonSavePKLPath.Name = "buttonSavePKLPath";
            buttonSavePKLPath.Size = new Size(75, 23);
            buttonSavePKLPath.TabIndex = 12;
            buttonSavePKLPath.Text = "选择";
            buttonSavePKLPath.UseVisualStyleBackColor = true;
            buttonSavePKLPath.Click += buttonSavePKLPath_Click;
            // 
            // textBoxPKLSavePath
            // 
            textBoxPKLSavePath.AllowDrop = true;
            textBoxPKLSavePath.Location = new Point(6, 93);
            textBoxPKLSavePath.Name = "textBoxPKLSavePath";
            textBoxPKLSavePath.Size = new Size(241, 23);
            textBoxPKLSavePath.TabIndex = 11;
            textBoxPKLSavePath.DragDrop += textBoxPKLSavePath_DragDrop;
            textBoxPKLSavePath.DragEnter += textBox_DragEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(172, 17);
            label2.TabIndex = 16;
            label2.Text = "设置解包后的WC文件保存路径";
            // 
            // textBoxWcsSavePath
            // 
            textBoxWcsSavePath.AllowDrop = true;
            textBoxWcsSavePath.Location = new Point(6, 85);
            textBoxWcsSavePath.Name = "textBoxWcsSavePath";
            textBoxWcsSavePath.Size = new Size(239, 23);
            textBoxWcsSavePath.TabIndex = 15;
            textBoxWcsSavePath.DragDrop += textBoxWcsSavePath_DragDrop;
            textBoxWcsSavePath.DragEnter += textBox_DragEnter;
            // 
            // buttonSaveWcsPath
            // 
            buttonSaveWcsPath.Location = new Point(251, 85);
            buttonSaveWcsPath.Name = "buttonSaveWcsPath";
            buttonSaveWcsPath.Size = new Size(75, 23);
            buttonSaveWcsPath.TabIndex = 14;
            buttonSaveWcsPath.Text = "选择";
            buttonSaveWcsPath.UseVisualStyleBackColor = true;
            buttonSaveWcsPath.Click += buttonSaveWcsPath_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPackPKL);
            tabControl1.Controls.Add(tabUnpackPKL);
            tabControl1.Location = new Point(12, 65);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(347, 253);
            tabControl1.TabIndex = 17;
            // 
            // tabPackPKL
            // 
            tabPackPKL.Controls.Add(textBoxPKLSavePath);
            tabPackPKL.Controls.Add(label1);
            tabPackPKL.Controls.Add(buttonSavePKLPath);
            tabPackPKL.Controls.Add(textPackWcs);
            tabPackPKL.Controls.Add(buttonConvertPKL);
            tabPackPKL.Controls.Add(buttonOpenPackWcs);
            tabPackPKL.Controls.Add(labelPackWcs);
            tabPackPKL.Location = new Point(4, 26);
            tabPackPKL.Name = "tabPackPKL";
            tabPackPKL.Padding = new Padding(3);
            tabPackPKL.Size = new Size(339, 223);
            tabPackPKL.TabIndex = 2;
            tabPackPKL.Text = "打包PKL";
            tabPackPKL.UseVisualStyleBackColor = true;
            // 
            // tabUnpackPKL
            // 
            tabUnpackPKL.Controls.Add(textBoxPKLOpenPath);
            tabUnpackPKL.Controls.Add(buttonConvertMGDB);
            tabUnpackPKL.Controls.Add(buttonOpenPKLPath);
            tabUnpackPKL.Controls.Add(textBoxWcsSavePath);
            tabUnpackPKL.Controls.Add(label2);
            tabUnpackPKL.Controls.Add(labelUnpackPKL);
            tabUnpackPKL.Controls.Add(buttonSaveWcsPath);
            tabUnpackPKL.Location = new Point(4, 26);
            tabUnpackPKL.Name = "tabUnpackPKL";
            tabUnpackPKL.Padding = new Padding(3);
            tabUnpackPKL.Size = new Size(339, 223);
            tabUnpackPKL.TabIndex = 1;
            tabUnpackPKL.Text = "解包PKL";
            tabUnpackPKL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 321);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 18;
            label3.Text = "传火宝可梦出品";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(369, 344);
            Controls.Add(label3);
            Controls.Add(tabControl1);
            Controls.Add(LabelWCType);
            Controls.Add(comboBoxWCType);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form";
            Text = "PKMConverter(传火宝可梦)";
            tabControl1.ResumeLayout(false);
            tabPackPKL.ResumeLayout(false);
            tabPackPKL.PerformLayout();
            tabUnpackPKL.ResumeLayout(false);
            tabUnpackPKL.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConvertPKL;
        private ComboBox comboBoxWCType;
        private Button buttonOpenPackWcs;
        private OpenFileDialog openFileDialog1;
        private TextBox textPackWcs;
        private TextBox textBoxPKLOpenPath;
        private Button buttonOpenPKLPath;
        private Label labelPackWcs;
        private Label labelUnpackPKL;
        private Label LabelWCType;
        private Button buttonConvertMGDB;
        private Label label1;
        private Button buttonSavePKLPath;
        private TextBox textBoxPKLSavePath;
        private Label label2;
        private TextBox textBoxWcsSavePath;
        private Button buttonSaveWcsPath;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabUnpackPKL;
        private TabPage tabPackPKL;
        private Label label3;
    }
}

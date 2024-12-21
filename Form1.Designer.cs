namespace PKLConverter
{
    partial class Form1
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
            buttonConvertPKL = new Button();
            comboBoxPKLType = new ComboBox();
            buttonOpenMGDBPath = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBoxMGDBOpenPath = new TextBox();
            textBoxPKLOpenPath = new TextBox();
            buttonOpenPKLPath = new Button();
            labelMGDB = new Label();
            labelPKL = new Label();
            LabelPKLType = new Label();
            buttonConvertMGDB = new Button();
            label1 = new Label();
            buttonSavePKLPath = new Button();
            textBoxPKLSavePath = new TextBox();
            label2 = new Label();
            textBoxMGDBSavePath = new TextBox();
            buttonSaveMGDBPath = new Button();
            SuspendLayout();
            // 
            // buttonConvertPKL
            // 
            buttonConvertPKL.Location = new Point(25, 319);
            buttonConvertPKL.Name = "buttonConvertPKL";
            buttonConvertPKL.Size = new Size(225, 75);
            buttonConvertPKL.TabIndex = 0;
            buttonConvertPKL.Text = "生成PKL";
            buttonConvertPKL.UseVisualStyleBackColor = true;
            buttonConvertPKL.Click += buttonConvertPKL_Click;
            // 
            // comboBoxPKLType
            // 
            comboBoxPKLType.FormattingEnabled = true;
            comboBoxPKLType.Items.AddRange(new object[] { "wc9" });
            comboBoxPKLType.Location = new Point(25, 267);
            comboBoxPKLType.Name = "comboBoxPKLType";
            comboBoxPKLType.Size = new Size(468, 25);
            comboBoxPKLType.TabIndex = 2;
            // 
            // buttonOpenMGDBPath
            // 
            buttonOpenMGDBPath.Location = new Point(418, 34);
            buttonOpenMGDBPath.Name = "buttonOpenMGDBPath";
            buttonOpenMGDBPath.Size = new Size(75, 23);
            buttonOpenMGDBPath.TabIndex = 3;
            buttonOpenMGDBPath.Text = "选择";
            buttonOpenMGDBPath.UseVisualStyleBackColor = true;
            buttonOpenMGDBPath.Click += buttonOpenMGDBPath_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxMGDBOpenPath
            // 
            textBoxMGDBOpenPath.Location = new Point(25, 34);
            textBoxMGDBOpenPath.Name = "textBoxMGDBOpenPath";
            textBoxMGDBOpenPath.Size = new Size(387, 23);
            textBoxMGDBOpenPath.TabIndex = 4;
            // 
            // textBoxPKLOpenPath
            // 
            textBoxPKLOpenPath.Location = new Point(25, 158);
            textBoxPKLOpenPath.Name = "textBoxPKLOpenPath";
            textBoxPKLOpenPath.Size = new Size(387, 23);
            textBoxPKLOpenPath.TabIndex = 5;
            textBoxPKLOpenPath.TextChanged += textBoxPKLOpenPath_TextChanged;
            // 
            // buttonOpenPKLPath
            // 
            buttonOpenPKLPath.Location = new Point(418, 158);
            buttonOpenPKLPath.Name = "buttonOpenPKLPath";
            buttonOpenPKLPath.Size = new Size(75, 23);
            buttonOpenPKLPath.TabIndex = 6;
            buttonOpenPKLPath.Text = "选择";
            buttonOpenPKLPath.UseVisualStyleBackColor = true;
            buttonOpenPKLPath.Click += buttonOpenPKLPath_Click;
            // 
            // labelMGDB
            // 
            labelMGDB.AutoSize = true;
            labelMGDB.Location = new Point(25, 9);
            labelMGDB.Name = "labelMGDB";
            labelMGDB.Size = new Size(118, 17);
            labelMGDB.TabIndex = 7;
            labelMGDB.Text = "设置MGDB打开路径";
            // 
            // labelPKL
            // 
            labelPKL.AutoSize = true;
            labelPKL.Location = new Point(25, 136);
            labelPKL.Name = "labelPKL";
            labelPKL.Size = new Size(101, 17);
            labelPKL.TabIndex = 8;
            labelPKL.Text = "设置PKL打开路径";
            // 
            // LabelPKLType
            // 
            LabelPKLType.AutoSize = true;
            LabelPKLType.Location = new Point(25, 247);
            LabelPKLType.Name = "LabelPKLType";
            LabelPKLType.Size = new Size(77, 17);
            LabelPKLType.TabIndex = 9;
            LabelPKLType.Text = "选择PKL类型";
            // 
            // buttonConvertMGDB
            // 
            buttonConvertMGDB.Location = new Point(268, 319);
            buttonConvertMGDB.Name = "buttonConvertMGDB";
            buttonConvertMGDB.Size = new Size(225, 75);
            buttonConvertMGDB.TabIndex = 10;
            buttonConvertMGDB.Text = "解包至MGDB";
            buttonConvertMGDB.UseVisualStyleBackColor = true;
            buttonConvertMGDB.Click += buttonConvertMGDB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 184);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 13;
            label1.Text = "设置PKL保存路径";
            // 
            // buttonSavePKLPath
            // 
            buttonSavePKLPath.Location = new Point(418, 206);
            buttonSavePKLPath.Name = "buttonSavePKLPath";
            buttonSavePKLPath.Size = new Size(75, 23);
            buttonSavePKLPath.TabIndex = 12;
            buttonSavePKLPath.Text = "选择";
            buttonSavePKLPath.UseVisualStyleBackColor = true;
            buttonSavePKLPath.Click += buttonSavePKLPath_Click;
            // 
            // textBoxPKLSavePath
            // 
            textBoxPKLSavePath.Location = new Point(25, 206);
            textBoxPKLSavePath.Name = "textBoxPKLSavePath";
            textBoxPKLSavePath.Size = new Size(387, 23);
            textBoxPKLSavePath.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(118, 17);
            label2.TabIndex = 16;
            label2.Text = "设置MGDB保存路径";
            // 
            // textBoxMGDBSavePath
            // 
            textBoxMGDBSavePath.Location = new Point(25, 89);
            textBoxMGDBSavePath.Name = "textBoxMGDBSavePath";
            textBoxMGDBSavePath.Size = new Size(387, 23);
            textBoxMGDBSavePath.TabIndex = 15;
            // 
            // buttonSaveMGDBPath
            // 
            buttonSaveMGDBPath.Location = new Point(418, 89);
            buttonSaveMGDBPath.Name = "buttonSaveMGDBPath";
            buttonSaveMGDBPath.Size = new Size(75, 23);
            buttonSaveMGDBPath.TabIndex = 14;
            buttonSaveMGDBPath.Text = "选择";
            buttonSaveMGDBPath.UseVisualStyleBackColor = true;
            buttonSaveMGDBPath.Click += buttonSaveMGDBPath_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 406);
            Controls.Add(label2);
            Controls.Add(textBoxMGDBSavePath);
            Controls.Add(buttonSaveMGDBPath);
            Controls.Add(label1);
            Controls.Add(buttonSavePKLPath);
            Controls.Add(textBoxPKLSavePath);
            Controls.Add(buttonConvertMGDB);
            Controls.Add(LabelPKLType);
            Controls.Add(labelPKL);
            Controls.Add(labelMGDB);
            Controls.Add(buttonOpenPKLPath);
            Controls.Add(textBoxPKLOpenPath);
            Controls.Add(textBoxMGDBOpenPath);
            Controls.Add(buttonOpenMGDBPath);
            Controls.Add(comboBoxPKLType);
            Controls.Add(buttonConvertPKL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConvertPKL;
        private ComboBox comboBoxPKLType;
        private Button buttonOpenMGDBPath;
        private OpenFileDialog openFileDialog1;
        private TextBox textBoxMGDBOpenPath;
        private TextBox textBoxPKLOpenPath;
        private Button buttonOpenPKLPath;
        private Label labelMGDB;
        private Label labelPKL;
        private Label LabelPKLType;
        private Button buttonConvertMGDB;
        private Label label1;
        private Button buttonSavePKLPath;
        private TextBox textBoxPKLSavePath;
        private Label label2;
        private TextBox textBoxMGDBSavePath;
        private Button buttonSaveMGDBPath;
    }
}

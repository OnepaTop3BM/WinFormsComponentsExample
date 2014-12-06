namespace WinFormsComponentsExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.cbVisible = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.valueWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.valueHeight = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.formulaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.valueX = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listViewProjectComponents = new System.Windows.Forms.ListView();
            this.listViewBaseComponents = new System.Windows.Forms.ListView();
            this.panelWorkArea = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.logBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueX)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logBox);
            this.groupBox1.Controls.Add(this.cbEnabled);
            this.groupBox1.Controls.Add(this.cbVisible);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.valueWidth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.valueHeight);
            this.groupBox1.Controls.Add(this.pictureBoxPreview);
            this.groupBox1.Controls.Add(this.formulaBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.valueY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.valueX);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(743, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 458);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства";
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Location = new System.Drawing.Point(20, 209);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(92, 17);
            this.cbEnabled.TabIndex = 12;
            this.cbEnabled.Text = "Доступность";
            this.cbEnabled.UseVisualStyleBackColor = true;
            this.cbEnabled.Click += new System.EventHandler(this.cbEnabled_Click_1);
            // 
            // cbVisible
            // 
            this.cbVisible.AutoSize = true;
            this.cbVisible.Location = new System.Drawing.Point(20, 186);
            this.cbVisible.Name = "cbVisible";
            this.cbVisible.Size = new System.Drawing.Size(82, 17);
            this.cbVisible.TabIndex = 11;
            this.cbVisible.Text = "Видимость";
            this.cbVisible.UseVisualStyleBackColor = true;
            this.cbVisible.Click += new System.EventHandler(this.cbVisible_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Высота";
            // 
            // valueWidth
            // 
            this.valueWidth.Location = new System.Drawing.Point(68, 91);
            this.valueWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valueWidth.Name = "valueWidth";
            this.valueWidth.Size = new System.Drawing.Size(59, 20);
            this.valueWidth.TabIndex = 9;
            this.valueWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.valueWidth.ValueChanged += new System.EventHandler(this.valueWidth_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ширина";
            // 
            // valueHeight
            // 
            this.valueHeight.Location = new System.Drawing.Point(68, 117);
            this.valueHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valueHeight.Name = "valueHeight";
            this.valueHeight.Size = new System.Drawing.Size(59, 20);
            this.valueHeight.TabIndex = 7;
            this.valueHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.valueHeight.ValueChanged += new System.EventHandler(this.valueHeight_ValueChanged);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(13, 244);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(139, 137);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 6;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.Click += new System.EventHandler(this.pictureBoxPreview_Click);
            // 
            // formulaBox
            // 
            this.formulaBox.Location = new System.Drawing.Point(6, 160);
            this.formulaBox.Name = "formulaBox";
            this.formulaBox.Size = new System.Drawing.Size(148, 20);
            this.formulaBox.TabIndex = 5;
            this.formulaBox.TextChanged += new System.EventHandler(this.formulaBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Формула";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // valueY
            // 
            this.valueY.Location = new System.Drawing.Point(68, 45);
            this.valueY.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.valueY.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.valueY.Name = "valueY";
            this.valueY.Size = new System.Drawing.Size(59, 20);
            this.valueY.TabIndex = 2;
            this.valueY.ValueChanged += new System.EventHandler(this.valueY_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // valueX
            // 
            this.valueX.Location = new System.Drawing.Point(68, 19);
            this.valueX.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.valueX.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.valueX.Name = "valueX";
            this.valueX.Size = new System.Drawing.Size(59, 20);
            this.valueX.TabIndex = 0;
            this.valueX.ValueChanged += new System.EventHandler(this.valueX_ValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(743, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "new";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel2.Text = "load";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel3.Text = "save";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel4.Text = "exit";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.listViewProjectComponents);
            this.panel1.Controls.Add(this.listViewBaseComponents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 433);
            this.panel1.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 199);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(217, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // listViewProjectComponents
            // 
            this.listViewProjectComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProjectComponents.Location = new System.Drawing.Point(0, 199);
            this.listViewProjectComponents.Name = "listViewProjectComponents";
            this.listViewProjectComponents.Size = new System.Drawing.Size(217, 234);
            this.listViewProjectComponents.TabIndex = 2;
            this.listViewProjectComponents.UseCompatibleStateImageBehavior = false;
            this.listViewProjectComponents.View = System.Windows.Forms.View.List;
            // 
            // listViewBaseComponents
            // 
            this.listViewBaseComponents.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewBaseComponents.Location = new System.Drawing.Point(0, 0);
            this.listViewBaseComponents.MultiSelect = false;
            this.listViewBaseComponents.Name = "listViewBaseComponents";
            this.listViewBaseComponents.Size = new System.Drawing.Size(217, 199);
            this.listViewBaseComponents.TabIndex = 0;
            this.listViewBaseComponents.UseCompatibleStateImageBehavior = false;
            this.listViewBaseComponents.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewBaseComponents_ItemDrag);
            // 
            // panelWorkArea
            // 
            this.panelWorkArea.AllowDrop = true;
            this.panelWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkArea.Location = new System.Drawing.Point(217, 25);
            this.panelWorkArea.Name = "panelWorkArea";
            this.panelWorkArea.Size = new System.Drawing.Size(526, 433);
            this.panelWorkArea.TabIndex = 9;
            this.panelWorkArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelWorkArea_DragDrop);
            this.panelWorkArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelWorkArea_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "a.png");
            this.imageList1.Images.SetKeyName(1, "b.png");
            this.imageList1.Images.SetKeyName(2, "c.png");
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logBox.Location = new System.Drawing.Point(3, 400);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(158, 55);
            this.logBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(907, 458);
            this.Controls.Add(this.panelWorkArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueX)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown valueY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown valueX;
        private System.Windows.Forms.TextBox formulaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewProjectComponents;
        private System.Windows.Forms.ListView listViewBaseComponents;
        private System.Windows.Forms.Panel panelWorkArea;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown valueWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown valueHeight;
        private System.Windows.Forms.CheckBox cbEnabled;
        private System.Windows.Forms.CheckBox cbVisible;
        private System.Windows.Forms.TextBox logBox;
    }
}


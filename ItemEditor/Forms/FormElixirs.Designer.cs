namespace ItemEditor
{
    partial class FormElixirs
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxElixirs = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBasic = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSecondType = new System.Windows.Forms.Label();
            this.comboBoxSecondType = new System.Windows.Forms.ComboBox();
            this.labelStep = new System.Windows.Forms.Label();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.textBoxMaxValue = new System.Windows.Forms.TextBox();
            this.labelMaxValue = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelIntox = new System.Windows.Forms.Label();
            this.textBoxIntox = new System.Windows.Forms.TextBox();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.textBoxMinValue = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.btnIcon = new System.Windows.Forms.Button();
            this.labelTxtLv = new System.Windows.Forms.Label();
            this.labelThirdType = new System.Windows.Forms.Label();
            this.comboBoxThirdType = new System.Windows.Forms.ComboBox();
            this.tabPageUnknown = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxXsdName = new System.Windows.Forms.TextBox();
            this.textBoxThirdType = new System.Windows.Forms.TextBox();
            this.textBoxModelIndex = new System.Windows.Forms.TextBox();
            this.textBoxIconIndex = new System.Windows.Forms.TextBox();
            this.textBoxItemRank = new System.Windows.Forms.TextBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.textBoxQuality = new System.Windows.Forms.TextBox();
            this.textBoxQuality2 = new System.Windows.Forms.TextBox();
            this.textBoxXsdInfo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxVisual = new System.Windows.Forms.TextBox();
            this.textBoxCooldown = new System.Windows.Forms.TextBox();
            this.textBoxSuccess = new System.Windows.Forms.TextBox();
            this.textBoxClan = new System.Windows.Forms.TextBox();
            this.textBoxContrib1 = new System.Windows.Forms.TextBox();
            this.textBoxContrib2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxStore = new System.Windows.Forms.CheckBox();
            this.checkBoxSell = new System.Windows.Forms.CheckBox();
            this.checkBoxTrade = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBasic.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxElixirs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(681, 310);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // listBoxElixirs
            // 
            this.listBoxElixirs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxElixirs.FormattingEnabled = true;
            this.listBoxElixirs.Location = new System.Drawing.Point(0, 0);
            this.listBoxElixirs.Name = "listBoxElixirs";
            this.listBoxElixirs.Size = new System.Drawing.Size(225, 310);
            this.listBoxElixirs.TabIndex = 0;
            this.listBoxElixirs.SelectedIndexChanged += new System.EventHandler(this.listBoxElixirs_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBasic);
            this.tabControl1.Controls.Add(this.tabPageUnknown);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 310);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBasic
            // 
            this.tabPageBasic.Controls.Add(this.tableLayoutPanel1);
            this.tabPageBasic.Location = new System.Drawing.Point(4, 22);
            this.tabPageBasic.Name = "tabPageBasic";
            this.tabPageBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBasic.Size = new System.Drawing.Size(444, 284);
            this.tabPageBasic.TabIndex = 0;
            this.tabPageBasic.Text = "Thông tin";
            this.tabPageBasic.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSecondType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSecondType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelStep, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxStep, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMaxValue, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelMaxValue, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPrice, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelPrice, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelIntox, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBoxIntox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelMinValue, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMinValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelLevel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLevel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnIcon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTxtLv, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelThirdType, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxThirdType, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 278);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 38);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(76, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelSecondType
            // 
            this.labelSecondType.AutoSize = true;
            this.labelSecondType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSecondType.Location = new System.Drawing.Point(3, 38);
            this.labelSecondType.Name = "labelSecondType";
            this.labelSecondType.Size = new System.Drawing.Size(67, 27);
            this.labelSecondType.TabIndex = 2;
            this.labelSecondType.Text = "Second type";
            this.labelSecondType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSecondType
            // 
            this.comboBoxSecondType.FormattingEnabled = true;
            this.comboBoxSecondType.Location = new System.Drawing.Point(76, 41);
            this.comboBoxSecondType.Name = "comboBoxSecondType";
            this.comboBoxSecondType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSecondType.TabIndex = 3;
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStep.Location = new System.Drawing.Point(3, 65);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(67, 26);
            this.labelStep.TabIndex = 4;
            this.labelStep.Text = "Step";
            this.labelStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(76, 68);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStep.TabIndex = 5;
            // 
            // textBoxMaxValue
            // 
            this.textBoxMaxValue.Location = new System.Drawing.Point(76, 146);
            this.textBoxMaxValue.Name = "textBoxMaxValue";
            this.textBoxMaxValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxValue.TabIndex = 6;
            // 
            // labelMaxValue
            // 
            this.labelMaxValue.AutoSize = true;
            this.labelMaxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxValue.Location = new System.Drawing.Point(3, 143);
            this.labelMaxValue.Name = "labelMaxValue";
            this.labelMaxValue.Size = new System.Drawing.Size(67, 26);
            this.labelMaxValue.TabIndex = 7;
            this.labelMaxValue.Text = "Max value";
            this.labelMaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(76, 172);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 8;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrice.Location = new System.Drawing.Point(3, 169);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(67, 26);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIntox
            // 
            this.labelIntox.AutoSize = true;
            this.labelIntox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIntox.Location = new System.Drawing.Point(3, 195);
            this.labelIntox.Name = "labelIntox";
            this.labelIntox.Size = new System.Drawing.Size(67, 26);
            this.labelIntox.TabIndex = 10;
            this.labelIntox.Text = "Intoxication";
            this.labelIntox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxIntox
            // 
            this.textBoxIntox.Location = new System.Drawing.Point(76, 198);
            this.textBoxIntox.Name = "textBoxIntox";
            this.textBoxIntox.Size = new System.Drawing.Size(100, 20);
            this.textBoxIntox.TabIndex = 11;
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinValue.Location = new System.Drawing.Point(3, 117);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(67, 26);
            this.labelMinValue.TabIndex = 12;
            this.labelMinValue.Text = "Min value";
            this.labelMinValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMinValue
            // 
            this.textBoxMinValue.Location = new System.Drawing.Point(76, 120);
            this.textBoxMinValue.Name = "textBoxMinValue";
            this.textBoxMinValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinValue.TabIndex = 13;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLevel.Location = new System.Drawing.Point(3, 91);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(67, 26);
            this.labelLevel.TabIndex = 14;
            this.labelLevel.Text = "Level";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(76, 94);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxLevel.TabIndex = 15;
            // 
            // btnIcon
            // 
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.Location = new System.Drawing.Point(182, 3);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(32, 32);
            this.btnIcon.TabIndex = 17;
            this.btnIcon.UseVisualStyleBackColor = true;
            // 
            // labelTxtLv
            // 
            this.labelTxtLv.AutoSize = true;
            this.labelTxtLv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTxtLv.Location = new System.Drawing.Point(182, 91);
            this.labelTxtLv.Name = "labelTxtLv";
            this.labelTxtLv.Size = new System.Drawing.Size(58, 26);
            this.labelTxtLv.TabIndex = 18;
            this.labelTxtLv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelThirdType
            // 
            this.labelThirdType.AutoSize = true;
            this.labelThirdType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelThirdType.Location = new System.Drawing.Point(182, 38);
            this.labelThirdType.Name = "labelThirdType";
            this.labelThirdType.Size = new System.Drawing.Size(58, 27);
            this.labelThirdType.TabIndex = 19;
            this.labelThirdType.Text = "Third Type";
            this.labelThirdType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxThirdType
            // 
            this.comboBoxThirdType.FormattingEnabled = true;
            this.comboBoxThirdType.Items.AddRange(new object[] {
            "Elixir",
            "Cannot drop under -X",
            "Minimum attribute bonus increase by X%",
            "Success increase by X%"});
            this.comboBoxThirdType.Location = new System.Drawing.Point(246, 41);
            this.comboBoxThirdType.Name = "comboBoxThirdType";
            this.comboBoxThirdType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxThirdType.TabIndex = 20;
            // 
            // tabPageUnknown
            // 
            this.tabPageUnknown.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnknown.Name = "tabPageUnknown";
            this.tabPageUnknown.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUnknown.Size = new System.Drawing.Size(444, 284);
            this.tabPageUnknown.TabIndex = 1;
            this.tabPageUnknown.Text = "Thông tin thêm";
            this.tabPageUnknown.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(444, 284);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Values from source";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.textBoxXsdName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxThirdType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxModelIndex, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxIconIndex, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxItemRank, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxGrade, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxQuality, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBoxQuality2, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.textBoxXsdInfo, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label13, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label14, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label15, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label16, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxVisual, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCooldown, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSuccess, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxClan, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxContrib1, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxContrib2, 4, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(438, 278);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "XSD name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Third type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Model index";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Icon index";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Item rank";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Grade";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Quality";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 26);
            this.label9.TabIndex = 7;
            this.label9.Text = "Quality 2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "XSD info";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxXsdName
            // 
            this.textBoxXsdName.Location = new System.Drawing.Point(73, 3);
            this.textBoxXsdName.Name = "textBoxXsdName";
            this.textBoxXsdName.Size = new System.Drawing.Size(100, 20);
            this.textBoxXsdName.TabIndex = 9;
            // 
            // textBoxThirdType
            // 
            this.textBoxThirdType.Location = new System.Drawing.Point(73, 29);
            this.textBoxThirdType.Name = "textBoxThirdType";
            this.textBoxThirdType.Size = new System.Drawing.Size(100, 20);
            this.textBoxThirdType.TabIndex = 10;
            // 
            // textBoxModelIndex
            // 
            this.textBoxModelIndex.Location = new System.Drawing.Point(73, 55);
            this.textBoxModelIndex.Name = "textBoxModelIndex";
            this.textBoxModelIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxModelIndex.TabIndex = 11;
            // 
            // textBoxIconIndex
            // 
            this.textBoxIconIndex.Location = new System.Drawing.Point(73, 81);
            this.textBoxIconIndex.Name = "textBoxIconIndex";
            this.textBoxIconIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxIconIndex.TabIndex = 12;
            // 
            // textBoxItemRank
            // 
            this.textBoxItemRank.Location = new System.Drawing.Point(73, 107);
            this.textBoxItemRank.Name = "textBoxItemRank";
            this.textBoxItemRank.Size = new System.Drawing.Size(100, 20);
            this.textBoxItemRank.TabIndex = 13;
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(73, 133);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrade.TabIndex = 14;
            // 
            // textBoxQuality
            // 
            this.textBoxQuality.Location = new System.Drawing.Point(73, 159);
            this.textBoxQuality.Name = "textBoxQuality";
            this.textBoxQuality.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuality.TabIndex = 15;
            // 
            // textBoxQuality2
            // 
            this.textBoxQuality2.Location = new System.Drawing.Point(73, 185);
            this.textBoxQuality2.Name = "textBoxQuality2";
            this.textBoxQuality2.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuality2.TabIndex = 16;
            // 
            // textBoxXsdInfo
            // 
            this.textBoxXsdInfo.Location = new System.Drawing.Point(73, 211);
            this.textBoxXsdInfo.Name = "textBoxXsdInfo";
            this.textBoxXsdInfo.Size = new System.Drawing.Size(100, 20);
            this.textBoxXsdInfo.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(179, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Visual effect";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(179, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 26);
            this.label12.TabIndex = 19;
            this.label12.Text = "Cooldown delay";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(179, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 26);
            this.label13.TabIndex = 20;
            this.label13.Text = "Success rate";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(179, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 26);
            this.label14.TabIndex = 21;
            this.label14.Text = "Clan";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(179, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 26);
            this.label15.TabIndex = 22;
            this.label15.Text = "Contrib1";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(179, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 26);
            this.label16.TabIndex = 23;
            this.label16.Text = "Contrib2";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxVisual
            // 
            this.textBoxVisual.Location = new System.Drawing.Point(267, 3);
            this.textBoxVisual.Name = "textBoxVisual";
            this.textBoxVisual.Size = new System.Drawing.Size(100, 20);
            this.textBoxVisual.TabIndex = 24;
            // 
            // textBoxCooldown
            // 
            this.textBoxCooldown.Location = new System.Drawing.Point(267, 29);
            this.textBoxCooldown.Name = "textBoxCooldown";
            this.textBoxCooldown.Size = new System.Drawing.Size(100, 20);
            this.textBoxCooldown.TabIndex = 25;
            // 
            // textBoxSuccess
            // 
            this.textBoxSuccess.Location = new System.Drawing.Point(267, 55);
            this.textBoxSuccess.Name = "textBoxSuccess";
            this.textBoxSuccess.Size = new System.Drawing.Size(100, 20);
            this.textBoxSuccess.TabIndex = 26;
            // 
            // textBoxClan
            // 
            this.textBoxClan.Location = new System.Drawing.Point(267, 81);
            this.textBoxClan.Name = "textBoxClan";
            this.textBoxClan.Size = new System.Drawing.Size(100, 20);
            this.textBoxClan.TabIndex = 27;
            // 
            // textBoxContrib1
            // 
            this.textBoxContrib1.Location = new System.Drawing.Point(267, 107);
            this.textBoxContrib1.Name = "textBoxContrib1";
            this.textBoxContrib1.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrib1.TabIndex = 28;
            // 
            // textBoxContrib2
            // 
            this.textBoxContrib2.Location = new System.Drawing.Point(267, 133);
            this.textBoxContrib2.Name = "textBoxContrib2";
            this.textBoxContrib2.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrib2.TabIndex = 29;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxStore);
            this.tabPage2.Controls.Add(this.checkBoxSell);
            this.tabPage2.Controls.Add(this.checkBoxTrade);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(444, 284);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Lựa chọn khác";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxStore
            // 
            this.checkBoxStore.AutoSize = true;
            this.checkBoxStore.Location = new System.Drawing.Point(7, 55);
            this.checkBoxStore.Name = "checkBoxStore";
            this.checkBoxStore.Size = new System.Drawing.Size(71, 17);
            this.checkBoxStore.TabIndex = 2;
            this.checkBoxStore.Text = "Can store";
            this.checkBoxStore.UseVisualStyleBackColor = true;
            // 
            // checkBoxSell
            // 
            this.checkBoxSell.AutoSize = true;
            this.checkBoxSell.Location = new System.Drawing.Point(7, 31);
            this.checkBoxSell.Name = "checkBoxSell";
            this.checkBoxSell.Size = new System.Drawing.Size(63, 17);
            this.checkBoxSell.TabIndex = 1;
            this.checkBoxSell.Text = "Can sell";
            this.checkBoxSell.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrade
            // 
            this.checkBoxTrade.AutoSize = true;
            this.checkBoxTrade.Location = new System.Drawing.Point(7, 7);
            this.checkBoxTrade.Name = "checkBoxTrade";
            this.checkBoxTrade.Size = new System.Drawing.Size(72, 17);
            this.checkBoxTrade.TabIndex = 0;
            this.checkBoxTrade.Text = "Can trade";
            this.checkBoxTrade.UseVisualStyleBackColor = true;
            // 
            // FormElixirs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 310);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormElixirs";
            this.Text = "Linh dược";
            this.Load += new System.EventHandler(this.FormElixirs_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBasic.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxElixirs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBasic;
        private System.Windows.Forms.TabPage tabPageUnknown;
        private System.ComponentModel.Design.ByteViewer byteViewer = new System.ComponentModel.Design.ByteViewer();
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSecondType;
        private System.Windows.Forms.ComboBox comboBoxSecondType;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.TextBox textBoxMaxValue;
        private System.Windows.Forms.Label labelMaxValue;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelIntox;
        private System.Windows.Forms.TextBox textBoxIntox;
        private System.Windows.Forms.Label labelMinValue;
        private System.Windows.Forms.TextBox textBoxMinValue;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxXsdName;
        private System.Windows.Forms.TextBox textBoxThirdType;
        private System.Windows.Forms.TextBox textBoxModelIndex;
        private System.Windows.Forms.TextBox textBoxIconIndex;
        private System.Windows.Forms.TextBox textBoxItemRank;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.TextBox textBoxQuality;
        private System.Windows.Forms.TextBox textBoxQuality2;
        private System.Windows.Forms.TextBox textBoxXsdInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxVisual;
        private System.Windows.Forms.TextBox textBoxCooldown;
        private System.Windows.Forms.TextBox textBoxSuccess;
        private System.Windows.Forms.TextBox textBoxClan;
        private System.Windows.Forms.TextBox textBoxContrib1;
        private System.Windows.Forms.TextBox textBoxContrib2;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.Label labelTxtLv;
        private System.Windows.Forms.Label labelThirdType;
        private System.Windows.Forms.ComboBox comboBoxThirdType;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxStore;
        private System.Windows.Forms.CheckBox checkBoxSell;
        private System.Windows.Forms.CheckBox checkBoxTrade;
    }
}
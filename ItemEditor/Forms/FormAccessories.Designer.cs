namespace ItemEditor
{
    partial class FormAccessories
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
            this.listBoxAccessories = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIcon = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelModelIndex = new System.Windows.Forms.Label();
            this.labelIconIndex = new System.Windows.Forms.Label();
            this.labelItemRank = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelCase = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.textBoxModelIndex = new System.Windows.Forms.TextBox();
            this.textBoxIconIndex = new System.Windows.Forms.TextBox();
            this.textBoxItemRank = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.textBoxCase = new System.Windows.Forms.TextBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.comboBox2ndType = new System.Windows.Forms.ComboBox();
            this.tbSecondaryType = new System.Windows.Forms.TextBox();
            this.tabPageRequirements = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTxtLv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.textBoxStr = new System.Windows.Forms.TextBox();
            this.textBoxEss = new System.Windows.Forms.TextBox();
            this.textBoxWis = new System.Windows.Forms.TextBox();
            this.textBoxCon = new System.Windows.Forms.TextBox();
            this.textBoxDex = new System.Windows.Forms.TextBox();
            this.labelFame = new System.Windows.Forms.Label();
            this.comboBoxFame = new System.Windows.Forms.ComboBox();
            this.tbKarma = new System.Windows.Forms.TextBox();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCashCheck = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxItemSet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMaxSockets = new System.Windows.Forms.TextBox();
            this.tabPageEffects = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxStore = new System.Windows.Forms.CheckBox();
            this.checkBoxNPC = new System.Windows.Forms.CheckBox();
            this.checkBoxTrade = new System.Windows.Forms.CheckBox();
            this.checkBoxDrop = new System.Windows.Forms.CheckBox();
            this.tabPageUnknown = new System.Windows.Forms.TabPage();
            this.specialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPageRequirements.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageDetails.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageEffects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAccessories
            // 
            this.listBoxAccessories.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxAccessories.FormattingEnabled = true;
            this.listBoxAccessories.Location = new System.Drawing.Point(0, 0);
            this.listBoxAccessories.Name = "listBoxAccessories";
            this.listBoxAccessories.Size = new System.Drawing.Size(212, 332);
            this.listBoxAccessories.TabIndex = 0;
            this.listBoxAccessories.SelectedIndexChanged += new System.EventHandler(this.listBoxAccessories_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageRequirements);
            this.tabControl1.Controls.Add(this.tabPageDetails);
            this.tabControl1.Controls.Add(this.tabPageEffects);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageUnknown);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(212, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(402, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(394, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chung";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btnIcon, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelType, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelModelIndex, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelIconIndex, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelItemRank, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelGroup, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.labelCase, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.labelGrade, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.textBoxModelIndex, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxIconIndex, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxItemRank, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.textBoxGroup, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.textBoxCase, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.textBoxGrade, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.comboBox2ndType, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbSecondaryType, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 300);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnIcon
            // 
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.Location = new System.Drawing.Point(179, 3);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(32, 32);
            this.btnIcon.TabIndex = 0;
            this.btnIcon.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 38);
            this.label12.TabIndex = 1;
            this.label12.Text = "Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(73, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelType.Location = new System.Drawing.Point(3, 38);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(64, 27);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "2nd type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelModelIndex
            // 
            this.labelModelIndex.AutoSize = true;
            this.labelModelIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelModelIndex.Location = new System.Drawing.Point(3, 65);
            this.labelModelIndex.Name = "labelModelIndex";
            this.labelModelIndex.Size = new System.Drawing.Size(64, 26);
            this.labelModelIndex.TabIndex = 5;
            this.labelModelIndex.Text = "Model index";
            this.labelModelIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIconIndex
            // 
            this.labelIconIndex.AutoSize = true;
            this.labelIconIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIconIndex.Location = new System.Drawing.Point(3, 91);
            this.labelIconIndex.Name = "labelIconIndex";
            this.labelIconIndex.Size = new System.Drawing.Size(64, 26);
            this.labelIconIndex.TabIndex = 6;
            this.labelIconIndex.Text = "Icon index";
            this.labelIconIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelItemRank
            // 
            this.labelItemRank.AutoSize = true;
            this.labelItemRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelItemRank.Location = new System.Drawing.Point(3, 117);
            this.labelItemRank.Name = "labelItemRank";
            this.labelItemRank.Size = new System.Drawing.Size(64, 26);
            this.labelItemRank.TabIndex = 7;
            this.labelItemRank.Text = "Item rank";
            this.labelItemRank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGroup.Location = new System.Drawing.Point(3, 143);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(64, 26);
            this.labelGroup.TabIndex = 8;
            this.labelGroup.Text = "Group";
            this.labelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCase
            // 
            this.labelCase.AutoSize = true;
            this.labelCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCase.Location = new System.Drawing.Point(3, 169);
            this.labelCase.Name = "labelCase";
            this.labelCase.Size = new System.Drawing.Size(64, 26);
            this.labelCase.TabIndex = 9;
            this.labelCase.Text = "Case";
            this.labelCase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGrade.Location = new System.Drawing.Point(3, 195);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(64, 26);
            this.labelGrade.TabIndex = 10;
            this.labelGrade.Text = "Grade";
            this.labelGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxModelIndex
            // 
            this.textBoxModelIndex.Location = new System.Drawing.Point(73, 68);
            this.textBoxModelIndex.Name = "textBoxModelIndex";
            this.textBoxModelIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxModelIndex.TabIndex = 11;
            this.textBoxModelIndex.TextChanged += new System.EventHandler(this.textBoxModelIndex_TextChanged);
            // 
            // textBoxIconIndex
            // 
            this.textBoxIconIndex.Location = new System.Drawing.Point(73, 94);
            this.textBoxIconIndex.Name = "textBoxIconIndex";
            this.textBoxIconIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxIconIndex.TabIndex = 12;
            this.textBoxIconIndex.TextChanged += new System.EventHandler(this.textBoxIconIndex_TextChanged);
            // 
            // textBoxItemRank
            // 
            this.textBoxItemRank.Location = new System.Drawing.Point(73, 120);
            this.textBoxItemRank.Name = "textBoxItemRank";
            this.textBoxItemRank.Size = new System.Drawing.Size(100, 20);
            this.textBoxItemRank.TabIndex = 13;
            this.textBoxItemRank.TextChanged += new System.EventHandler(this.textBoxItemRank_TextChanged);
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(73, 146);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(100, 20);
            this.textBoxGroup.TabIndex = 14;
            this.textBoxGroup.TextChanged += new System.EventHandler(this.textBoxGroup_TextChanged);
            // 
            // textBoxCase
            // 
            this.textBoxCase.Location = new System.Drawing.Point(73, 172);
            this.textBoxCase.Name = "textBoxCase";
            this.textBoxCase.Size = new System.Drawing.Size(100, 20);
            this.textBoxCase.TabIndex = 15;
            this.textBoxCase.TextChanged += new System.EventHandler(this.textBoxCase_TextChanged);
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(73, 198);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrade.TabIndex = 16;
            this.textBoxGrade.TextChanged += new System.EventHandler(this.textBoxGrade_TextChanged);
            // 
            // comboBox2ndType
            // 
            this.comboBox2ndType.FormattingEnabled = true;
            this.comboBox2ndType.Location = new System.Drawing.Point(179, 41);
            this.comboBox2ndType.Name = "comboBox2ndType";
            this.comboBox2ndType.Size = new System.Drawing.Size(100, 21);
            this.comboBox2ndType.TabIndex = 4;
            // 
            // tbSecondaryType
            // 
            this.tbSecondaryType.Location = new System.Drawing.Point(73, 41);
            this.tbSecondaryType.Name = "tbSecondaryType";
            this.tbSecondaryType.Size = new System.Drawing.Size(100, 20);
            this.tbSecondaryType.TabIndex = 17;
            this.tbSecondaryType.TextChanged += new System.EventHandler(this.tbSecondaryType_TextChanged);
            // 
            // tabPageRequirements
            // 
            this.tabPageRequirements.Controls.Add(this.tableLayoutPanel1);
            this.tabPageRequirements.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequirements.Name = "tabPageRequirements";
            this.tabPageRequirements.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageRequirements.Size = new System.Drawing.Size(394, 306);
            this.tabPageRequirements.TabIndex = 2;
            this.tabPageRequirements.Text = "Yêu cầu";
            this.tabPageRequirements.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTxtLv, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLevel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxStr, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEss, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxWis, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCon, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDex, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelFame, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxFame, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbKarma, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Strength";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTxtLv
            // 
            this.labelTxtLv.AutoSize = true;
            this.labelTxtLv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTxtLv.Location = new System.Drawing.Point(177, 0);
            this.labelTxtLv.Name = "labelTxtLv";
            this.labelTxtLv.Size = new System.Drawing.Size(208, 26);
            this.labelTxtLv.TabIndex = 2;
            this.labelTxtLv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Constitution";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dexterity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Essence";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wisdom";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(71, 3);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxLevel.TabIndex = 7;
            this.textBoxLevel.TextChanged += new System.EventHandler(this.textBoxLevel_TextChanged);
            // 
            // textBoxStr
            // 
            this.textBoxStr.Location = new System.Drawing.Point(71, 29);
            this.textBoxStr.Name = "textBoxStr";
            this.textBoxStr.Size = new System.Drawing.Size(100, 20);
            this.textBoxStr.TabIndex = 8;
            this.textBoxStr.TextChanged += new System.EventHandler(this.textBoxStr_TextChanged);
            // 
            // textBoxEss
            // 
            this.textBoxEss.Location = new System.Drawing.Point(71, 55);
            this.textBoxEss.Name = "textBoxEss";
            this.textBoxEss.Size = new System.Drawing.Size(100, 20);
            this.textBoxEss.TabIndex = 9;
            this.textBoxEss.TextChanged += new System.EventHandler(this.textBoxEss_TextChanged);
            // 
            // textBoxWis
            // 
            this.textBoxWis.Location = new System.Drawing.Point(71, 81);
            this.textBoxWis.Name = "textBoxWis";
            this.textBoxWis.Size = new System.Drawing.Size(100, 20);
            this.textBoxWis.TabIndex = 10;
            this.textBoxWis.TextChanged += new System.EventHandler(this.textBoxWis_TextChanged);
            // 
            // textBoxCon
            // 
            this.textBoxCon.Location = new System.Drawing.Point(71, 107);
            this.textBoxCon.Name = "textBoxCon";
            this.textBoxCon.Size = new System.Drawing.Size(100, 20);
            this.textBoxCon.TabIndex = 11;
            this.textBoxCon.TextChanged += new System.EventHandler(this.textBoxCon_TextChanged);
            // 
            // textBoxDex
            // 
            this.textBoxDex.Location = new System.Drawing.Point(71, 133);
            this.textBoxDex.Name = "textBoxDex";
            this.textBoxDex.Size = new System.Drawing.Size(100, 20);
            this.textBoxDex.TabIndex = 12;
            this.textBoxDex.TextChanged += new System.EventHandler(this.textBoxDex_TextChanged);
            // 
            // labelFame
            // 
            this.labelFame.AutoSize = true;
            this.labelFame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFame.Location = new System.Drawing.Point(3, 156);
            this.labelFame.Name = "labelFame";
            this.labelFame.Size = new System.Drawing.Size(62, 27);
            this.labelFame.TabIndex = 13;
            this.labelFame.Text = "Karma";
            this.labelFame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxFame
            // 
            this.comboBoxFame.FormattingEnabled = true;
            this.comboBoxFame.Location = new System.Drawing.Point(177, 159);
            this.comboBoxFame.Name = "comboBoxFame";
            this.comboBoxFame.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFame.TabIndex = 14;
            // 
            // tbKarma
            // 
            this.tbKarma.Location = new System.Drawing.Point(70, 158);
            this.tbKarma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbKarma.Name = "tbKarma";
            this.tbKarma.Size = new System.Drawing.Size(101, 20);
            this.tbKarma.TabIndex = 15;
            this.tbKarma.TextChanged += new System.EventHandler(this.tbKarma_TextChanged);
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.tableLayoutPanel2);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageDetails.Size = new System.Drawing.Size(394, 306);
            this.tabPageDetails.TabIndex = 3;
            this.tabPageDetails.Text = "Chi tiết";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxPrice, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCashCheck, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTime, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.textBoxItemSet, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMaxSockets, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 300);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Price";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cash check";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Time";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(76, 3);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxCashCheck
            // 
            this.textBoxCashCheck.Location = new System.Drawing.Point(76, 29);
            this.textBoxCashCheck.Name = "textBoxCashCheck";
            this.textBoxCashCheck.Size = new System.Drawing.Size(100, 20);
            this.textBoxCashCheck.TabIndex = 4;
            this.textBoxCashCheck.TextChanged += new System.EventHandler(this.textBoxCashCheck_TextChanged);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(76, 55);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTime.TabIndex = 5;
            this.textBoxTime.TextChanged += new System.EventHandler(this.textBoxTime_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 26);
            this.label10.TabIndex = 6;
            this.label10.Text = "Item set";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxItemSet
            // 
            this.textBoxItemSet.Location = new System.Drawing.Point(76, 107);
            this.textBoxItemSet.Name = "textBoxItemSet";
            this.textBoxItemSet.Size = new System.Drawing.Size(100, 20);
            this.textBoxItemSet.TabIndex = 7;
            this.textBoxItemSet.TextChanged += new System.EventHandler(this.textBoxItemSet_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 26);
            this.label11.TabIndex = 8;
            this.label11.Text = "Max sockets";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMaxSockets
            // 
            this.textBoxMaxSockets.Location = new System.Drawing.Point(76, 81);
            this.textBoxMaxSockets.Name = "textBoxMaxSockets";
            this.textBoxMaxSockets.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxSockets.TabIndex = 9;
            this.textBoxMaxSockets.TextChanged += new System.EventHandler(this.textBoxMaxSockets_TextChanged);
            // 
            // tabPageEffects
            // 
            this.tabPageEffects.Controls.Add(this.dataGridView1);
            this.tabPageEffects.Location = new System.Drawing.Point(4, 22);
            this.tabPageEffects.Name = "tabPageEffects";
            this.tabPageEffects.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageEffects.Size = new System.Drawing.Size(394, 306);
            this.tabPageEffects.TabIndex = 5;
            this.tabPageEffects.Text = "Options";
            this.tabPageEffects.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.effectBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.Width = 59;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // effectBindingSource
            // 
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxStore);
            this.tabPage2.Controls.Add(this.checkBoxNPC);
            this.tabPage2.Controls.Add(this.checkBoxTrade);
            this.tabPage2.Controls.Add(this.checkBoxDrop);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(394, 306);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Lựa chọn khác";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxStore
            // 
            this.checkBoxStore.AutoSize = true;
            this.checkBoxStore.Location = new System.Drawing.Point(7, 79);
            this.checkBoxStore.Name = "checkBoxStore";
            this.checkBoxStore.Size = new System.Drawing.Size(71, 17);
            this.checkBoxStore.TabIndex = 3;
            this.checkBoxStore.Text = "Can store";
            this.checkBoxStore.UseVisualStyleBackColor = true;
            this.checkBoxStore.CheckedChanged += new System.EventHandler(this.checkBoxStore_CheckedChanged);
            // 
            // checkBoxNPC
            // 
            this.checkBoxNPC.AutoSize = true;
            this.checkBoxNPC.Location = new System.Drawing.Point(7, 55);
            this.checkBoxNPC.Name = "checkBoxNPC";
            this.checkBoxNPC.Size = new System.Drawing.Size(100, 17);
            this.checkBoxNPC.TabIndex = 2;
            this.checkBoxNPC.Text = "Can sell to NPC";
            this.checkBoxNPC.UseVisualStyleBackColor = true;
            this.checkBoxNPC.CheckedChanged += new System.EventHandler(this.checkBoxNPC_CheckedChanged);
            // 
            // checkBoxTrade
            // 
            this.checkBoxTrade.AutoSize = true;
            this.checkBoxTrade.Location = new System.Drawing.Point(7, 31);
            this.checkBoxTrade.Name = "checkBoxTrade";
            this.checkBoxTrade.Size = new System.Drawing.Size(72, 17);
            this.checkBoxTrade.TabIndex = 1;
            this.checkBoxTrade.Text = "Can trade";
            this.checkBoxTrade.UseVisualStyleBackColor = true;
            this.checkBoxTrade.CheckedChanged += new System.EventHandler(this.checkBoxTrade_CheckedChanged);
            // 
            // checkBoxDrop
            // 
            this.checkBoxDrop.AutoSize = true;
            this.checkBoxDrop.Location = new System.Drawing.Point(7, 7);
            this.checkBoxDrop.Name = "checkBoxDrop";
            this.checkBoxDrop.Size = new System.Drawing.Size(69, 17);
            this.checkBoxDrop.TabIndex = 0;
            this.checkBoxDrop.Text = "Can drop";
            this.checkBoxDrop.UseVisualStyleBackColor = true;
            this.checkBoxDrop.CheckedChanged += new System.EventHandler(this.checkBoxDrop_CheckedChanged);
            // 
            // tabPageUnknown
            // 
            this.tabPageUnknown.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnknown.Name = "tabPageUnknown";
            this.tabPageUnknown.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageUnknown.Size = new System.Drawing.Size(394, 306);
            this.tabPageUnknown.TabIndex = 1;
            this.tabPageUnknown.Text = "Thông tin thêm";
            this.tabPageUnknown.UseVisualStyleBackColor = true;
            // 
            // specialBindingSource
            // 
            // 
            // FormAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 332);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBoxAccessories);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccessories";
            this.ShowIcon = false;
            this.Text = "Sửa Tín vật";
            this.Load += new System.EventHandler(this.FormAccessories_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAccessories_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPageRequirements.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageDetails.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageEffects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxAccessories;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageUnknown;
        private System.ComponentModel.Design.ByteViewer byteViewer = new System.ComponentModel.Design.ByteViewer();
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.TabPage tabPageRequirements;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTxtLv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.TextBox textBoxStr;
        private System.Windows.Forms.TextBox textBoxEss;
        private System.Windows.Forms.TextBox textBoxWis;
        private System.Windows.Forms.TextBox textBoxCon;
        private System.Windows.Forms.TextBox textBoxDex;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCashCheck;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxItemSet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMaxSockets;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxNPC;
        private System.Windows.Forms.CheckBox checkBoxTrade;
        private System.Windows.Forms.CheckBox checkBoxDrop;
        private System.Windows.Forms.CheckBox checkBoxStore;
        private System.Windows.Forms.TabPage tabPageEffects;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource effectBindingSource;
        private System.Windows.Forms.BindingSource specialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBox2ndType;
        private System.Windows.Forms.Label labelModelIndex;
        private System.Windows.Forms.Label labelIconIndex;
        private System.Windows.Forms.Label labelItemRank;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelCase;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.TextBox textBoxModelIndex;
        private System.Windows.Forms.TextBox textBoxIconIndex;
        private System.Windows.Forms.TextBox textBoxItemRank;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TextBox textBoxCase;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label labelFame;
        private System.Windows.Forms.ComboBox comboBoxFame;
        private System.Windows.Forms.TextBox tbSecondaryType;
        private System.Windows.Forms.TextBox tbKarma;
    }
}